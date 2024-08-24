using System.Management.Automation;
using System.Text;

namespace SDPUI
{
    /**
     * CLI Handler Class Handles Command Line Input
     * var _ps = new PowerShellHandler();
       string output = _ps.Command("wsl rsync -ruv rasberry@192.168.0.169:./Data/ /mnt/c/RsyncTest");

     */
    internal class CLIHandler
    {
        private readonly PowerShell cli;
        public CLIHandler()
        {
            cli = PowerShell.Create();
        }

        /**
         * Sends command to Powershell to be executed. 
         * Returns Sring result of execution (i.e., error msg or output)
         */
        public string Command(string script)
        {
            string errorMsg = string.Empty;

            cli.AddScript(script); 

            //Makes sure ouput is a String
            cli.AddCommand("Out-String");

            //Collects error message if error
            PSDataCollection<PSObject> outputCollection = new();
            cli.Streams.Error.DataAdded += (object sender, DataAddedEventArgs e) =>
            {
                errorMsg = ((PSDataCollection<ErrorRecord>)sender)[e.Index].ToString();
            };

            //Collects output results
            IAsyncResult result = cli.BeginInvoke<PSObject, PSObject>(null, outputCollection);


            //Wait for powershell command to finish executing
            cli.EndInvoke(result);

            StringBuilder sb = new();

            //Convert output results into string
            foreach (var outputItem in outputCollection)
            {
                sb.AppendLine(outputItem.BaseObject.ToString());
            }

            //Clears the commands we added to the powershell runspace so it's empty the next time we use it
            cli.Commands.Clear();

            //If an error is encountered, return it
            if (!string.IsNullOrEmpty(errorMsg))
                return errorMsg;

            return sb.ToString().Trim();

        }
    }
}
