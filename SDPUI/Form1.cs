using Renci.SshNet;


namespace SDPUI
{
    public partial class Form1 : Form
    {
        private int photoCount = 0;
        private bool isFeedOn = false;
        private readonly CLIHandler cli = new();
        
                //Raspberry Pi Login Info
        private const string USER_PI = "user";   //peronal PI = "rasberry" SDP PI = "user", SDP2.0 = "uber"
        private const string IP_ADDRESS_PI = "10.185.33.3"; //Personal IP = 192.168.0.169 Other Ip's: AmberHome = "192.168.0.135"; eduroam = "10.185.164.72", 10.185.59.161; Amber Hotspot = "172.20.10.5"
        private const string PASSWORD_PI = "rpi";  //personal and SDP2.0 = "password" SDP = "rpi"
       
                //CLI Commmands
        private const string RSYNC = "wsl rsync -ruv --delete " + USER_PI + "@" + IP_ADDRESS_PI + ":./Sensors/ /mnt/c/SDP_DroneData";
        private const string CAM_CAPTURE = "python Documents/code/camtion.py";
        private const string START_STREAM = "python Documents/code/camStream.py";
        private const string STOP_STREAM = "pkill -9 -f \"python Documents/code/camStream.py\"";
        private const string URL_STREAM = "start http://" + IP_ADDRESS_PI + ":5000/stream";
        private const string PROMPT_CLI = "start powershell";
        private const string MODEL = "invoke-item \""; //\"C:\\SDP_DroneData\\3DModels\\3DModelTest.obj\"";
        

        public Form1()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
        }

        /**
         * Synchrognizes the local and remote directory as specific locations.
         * Note: Goes off the premises there's an ssh key in place
         */
        private void btnSync_Click(object sender, EventArgs e)
        {
            lblSync.Text = "File Processing...";
            string output = cli.Command(RSYNC);
            lblSync.Text = "Sync Completed";
            txtbSync.Text = output;
        }

        /**
         * Connects to Pi via SSH and Runs the Python Script for capturing photos
         */
        private void btnCam_Click(object sender, EventArgs e)
        {
            lblCam.Text = "Cam Processing";
            //Sign into Pi Via SSH
            using (var client = new SshClient(IP_ADDRESS_PI, USER_PI, PASSWORD_PI))
            {
                client.Connect();
                client.RunCommand(CAM_CAPTURE); // Run PI Python Script
                client.Disconnect();
            }
            photoCount++;

            lblCam.Text = photoCount + " Photo Captured";

        }

        /**
         * Browse The File Directory and Display the image
         */

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtBrowse.Text = openFileDialog1.FileName;
            }
        }

        /**
          * Creates background task to run camerafeed
          */
        private void btnStream_Click(object sender, EventArgs e)
        {
            lblWeb.Text = "Feed Status: Active";
            Thread thread = new Thread(new ThreadStart(this.StreamTask));
            thread.SetApartmentState(ApartmentState.STA);
            thread.IsBackground = true;
            thread.Start();
            cli.Command(URL_STREAM);
        }

        /**
         * Activates camera and display the feed
         */
        private void StreamTask()
        {
            isFeedOn = true;

            //Sign into Pi Via SSH and Run Script
            using (var client = new SshClient(IP_ADDRESS_PI, USER_PI, PASSWORD_PI))
            {
                client.Connect();
                client.RunCommand(START_STREAM);
                client.Disconnect();
            }    
        }

        /**
         * Close camera feed stream
         */
        private void StopStream()
        {
            if (isFeedOn)
            {
                //Sign into Pi Via SSH and Run Script
                using (var client = new SshClient(IP_ADDRESS_PI, USER_PI, PASSWORD_PI))
                {
                    client.Connect();
                    client.RunCommand(STOP_STREAM);
                    client.Disconnect();
                }
                lblWeb.Text = "Feed Status: Inactive";
                isFeedOn = false;
            }
        }

        /**
         * Close stream if running on exit.
         */
        private void Form1_FormClosing(object sender, EventArgs e)
        {
            StopStream();
        }

        /**
         * Display 3D Model and stops live stream if running
         */
        private void btnModel_Click_1(object sender, EventArgs e)
        {
            //CLIHandler cli_Model = new CLIHandler();
            cli.Command(MODEL + txtBrowse.Text + "\"");
            StopStream();
        }

        /**
         * Opens a Powershell command prompt in another window and display Instructions on connecting to drone.
         */
        private void btnFlight_Click(object sender, EventArgs e)
        {
            cli.Command(PROMPT_CLI);
            
            //Powershell Instructions to connect to drone
            MessageBox.Show("To connect to drone please enter: wsl; ssh " + USER_PI + "@" + IP_ADDRESS_PI + 
                "/n Navigate to drone controls file and run file using: python filename.py");
            
            
        }
    }
}
