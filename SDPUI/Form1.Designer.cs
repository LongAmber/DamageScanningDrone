namespace SDPUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSync = new Button();
            lblSync = new Label();
            btnCam = new Button();
            lblCam = new Label();
            openFileDialog1 = new OpenFileDialog();
            fBrowse = new FolderBrowserDialog();
            txtBrowse = new TextBox();
            lblTitle1 = new Label();
            btnBrowse = new Button();
            txtbSync = new TextBox();
            btnStream = new Button();
            btnModel = new Button();
            lblWeb = new Label();
            btnFlight = new Button();
            lblFlight = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnSync
            // 
            btnSync.BackColor = SystemColors.ActiveBorder;
            btnSync.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSync.Location = new Point(58, 154);
            btnSync.Name = "btnSync";
            btnSync.Size = new Size(145, 58);
            btnSync.TabIndex = 0;
            btnSync.Text = "Sync Files";
            btnSync.UseVisualStyleBackColor = false;
            btnSync.Click += btnSync_Click;
            // 
            // lblSync
            // 
            lblSync.AutoSize = true;
            lblSync.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSync.Location = new Point(209, 182);
            lblSync.Name = "lblSync";
            lblSync.Size = new Size(168, 30);
            lblSync.TabIndex = 1;
            lblSync.Text = "File Sync Results";
            // 
            // btnCam
            // 
            btnCam.BackColor = SystemColors.ActiveBorder;
            btnCam.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCam.Location = new Point(58, 70);
            btnCam.Name = "btnCam";
            btnCam.Size = new Size(211, 62);
            btnCam.TabIndex = 2;
            btnCam.Text = "Capture Photo";
            btnCam.UseVisualStyleBackColor = false;
            btnCam.Click += btnCam_Click;
            // 
            // lblCam
            // 
            lblCam.AutoSize = true;
            lblCam.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCam.Location = new Point(275, 102);
            lblCam.Name = "lblCam";
            lblCam.Size = new Size(142, 30);
            lblCam.TabIndex = 3;
            lblCam.Text = "Photo Results";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // fBrowse
            // 
            fBrowse.RootFolder = Environment.SpecialFolder.MyComputer;
            fBrowse.SelectedPath = "C:\\RsyncTest";
            // 
            // txtBrowse
            // 
            txtBrowse.Location = new Point(564, 183);
            txtBrowse.Name = "txtBrowse";
            txtBrowse.Size = new Size(174, 31);
            txtBrowse.TabIndex = 4;
            // 
            // lblTitle1
            // 
            lblTitle1.AutoSize = true;
            lblTitle1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle1.Location = new Point(652, 121);
            lblTitle1.Name = "lblTitle1";
            lblTitle1.Size = new Size(189, 30);
            lblTitle1.TabIndex = 5;
            lblTitle1.Text = "Browse 3D Model";
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = SystemColors.ActiveBorder;
            btnBrowse.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBrowse.Location = new Point(746, 177);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(95, 40);
            btnBrowse.TabIndex = 6;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // txtbSync
            // 
            txtbSync.Location = new Point(58, 233);
            txtbSync.Multiline = true;
            txtbSync.Name = "txtbSync";
            txtbSync.ScrollBars = ScrollBars.Vertical;
            txtbSync.Size = new Size(450, 243);
            txtbSync.TabIndex = 8;
            // 
            // btnStream
            // 
            btnStream.BackColor = SystemColors.ActiveBorder;
            btnStream.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStream.Location = new Point(690, 268);
            btnStream.Name = "btnStream";
            btnStream.RightToLeft = RightToLeft.Yes;
            btnStream.Size = new Size(171, 40);
            btnStream.TabIndex = 9;
            btnStream.Text = "View Live Feed";
            btnStream.UseVisualStyleBackColor = false;
            btnStream.Click += btnStream_Click;
            // 
            // btnModel
            // 
            btnModel.BackColor = SystemColors.ActiveBorder;
            btnModel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnModel.Location = new Point(865, 158);
            btnModel.Name = "btnModel";
            btnModel.Size = new Size(156, 56);
            btnModel.TabIndex = 10;
            btnModel.Text = "3D Model";
            btnModel.UseVisualStyleBackColor = false;
            btnModel.Click += btnModel_Click_1;
            // 
            // lblWeb
            // 
            lblWeb.AutoSize = true;
            lblWeb.Location = new Point(890, 277);
            lblWeb.Name = "lblWeb";
            lblWeb.Size = new Size(172, 25);
            lblWeb.TabIndex = 11;
            lblWeb.Text = "Feed Status: Inactive";
            // 
            // btnFlight
            // 
            btnFlight.BackColor = SystemColors.ActiveBorder;
            btnFlight.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFlight.Location = new Point(746, 323);
            btnFlight.Name = "btnFlight";
            btnFlight.RightToLeft = RightToLeft.Yes;
            btnFlight.Size = new Size(115, 40);
            btnFlight.TabIndex = 12;
            btnFlight.Text = "Fly Drone";
            btnFlight.UseVisualStyleBackColor = false;
            btnFlight.Click += btnFlight_Click;
            // 
            // lblFlight
            // 
            lblFlight.AutoSize = true;
            lblFlight.Location = new Point(890, 338);
            lblFlight.Name = "lblFlight";
            lblFlight.Size = new Size(178, 25);
            lblFlight.TabIndex = 13;
            lblFlight.Text = "Flight Status: Inactive";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(388, 9);
            label1.Name = "label1";
            label1.Size = new Size(503, 46);
            label1.TabIndex = 14;
            label1.Text = "Damage Scanning Drone";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1165, 534);
            Controls.Add(label1);
            Controls.Add(lblFlight);
            Controls.Add(btnFlight);
            Controls.Add(lblWeb);
            Controls.Add(btnModel);
            Controls.Add(btnStream);
            Controls.Add(txtbSync);
            Controls.Add(btnBrowse);
            Controls.Add(lblTitle1);
            Controls.Add(txtBrowse);
            Controls.Add(lblCam);
            Controls.Add(btnCam);
            Controls.Add(lblSync);
            Controls.Add(btnSync);
            Name = "Form1";
            Text = "Damage Scanning Drone";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSync;
        private Label lblSync;
        private Label lblCam;
        private Button btnCam;
        private OpenFileDialog openFileDialog1;
        private FolderBrowserDialog fBrowse;
        private TextBox txtBrowse;
        private Label lblTitle1;
        private Button btnBrowse;
        private TextBox txtbSync;
        private Button btnStream;
        private Button btnModel;
        private Label lblWeb;
        private Button btnFlight;
        private Label lblFlight;
        private Label label1;
    }
}
