namespace WindowsAppForOctopusDeployment
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtboxPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkboxRememberMe = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbxPackageVersion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chkboxShowPassword = new System.Windows.Forms.CheckBox();
            this.rtbConsole = new System.Windows.Forms.RichTextBox();
            this.btnGetChannels = new System.Windows.Forms.Button();
            this.cmbChannels = new System.Windows.Forms.ComboBox();
            this.cmbEnvironments = new System.Windows.Forms.ComboBox();
            this.btnGetEnv = new System.Windows.Forms.Button();
            this.cmbRelease = new System.Windows.Forms.ComboBox();
            this.btnGetRelease = new System.Windows.Forms.Button();
            this.btnCreateRelease = new System.Windows.Forms.Button();
            this.btnDeploy = new System.Windows.Forms.Button();
            this.lblReleaseName = new System.Windows.Forms.Label();
            this.txtbxReleaseName = new System.Windows.Forms.TextBox();
            this.lblBDL = new System.Windows.Forms.Label();
            this.txtbxBDL = new System.Windows.Forms.TextBox();
            this.lblDSU = new System.Windows.Forms.Label();
            this.lblDRS = new System.Windows.Forms.Label();
            this.lblGFM = new System.Windows.Forms.Label();
            this.txtbxDSU = new System.Windows.Forms.TextBox();
            this.txtbxDBR = new System.Windows.Forms.TextBox();
            this.txtbxUGF = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.chkbxSelectAll = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.Location = new System.Drawing.Point(144, 14);
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.Size = new System.Drawing.Size(235, 20);
            this.txtboxPassword.TabIndex = 2;
            this.txtboxPassword.UseSystemPasswordChar = true;
            this.txtboxPassword.TextChanged += new System.EventHandler(this.txtboxPassword_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "API-KEY:";
            // 
            // chkboxRememberMe
            // 
            this.chkboxRememberMe.AutoSize = true;
            this.chkboxRememberMe.ForeColor = System.Drawing.SystemColors.GrayText;
            this.chkboxRememberMe.Location = new System.Drawing.Point(50, 51);
            this.chkboxRememberMe.Name = "chkboxRememberMe";
            this.chkboxRememberMe.Size = new System.Drawing.Size(95, 17);
            this.chkboxRememberMe.TabIndex = 4;
            this.chkboxRememberMe.Text = "Remember Me";
            this.chkboxRememberMe.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Package Version:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Release:";
            // 
            // txtbxPackageVersion
            // 
            this.txtbxPackageVersion.Location = new System.Drawing.Point(144, 129);
            this.txtbxPackageVersion.Name = "txtbxPackageVersion";
            this.txtbxPackageVersion.Size = new System.Drawing.Size(235, 20);
            this.txtbxPackageVersion.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Channel:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Environment:";
            // 
            // chkboxShowPassword
            // 
            this.chkboxShowPassword.AutoSize = true;
            this.chkboxShowPassword.ForeColor = System.Drawing.Color.Gray;
            this.chkboxShowPassword.Location = new System.Drawing.Point(305, 51);
            this.chkboxShowPassword.Name = "chkboxShowPassword";
            this.chkboxShowPassword.Size = new System.Drawing.Size(74, 17);
            this.chkboxShowPassword.TabIndex = 14;
            this.chkboxShowPassword.Text = "Show Key";
            this.chkboxShowPassword.UseVisualStyleBackColor = true;
            this.chkboxShowPassword.CheckedChanged += new System.EventHandler(this.chkboxShowPassword_CheckedChanged);
            // 
            // rtbConsole
            // 
            this.rtbConsole.Location = new System.Drawing.Point(144, 354);
            this.rtbConsole.Name = "rtbConsole";
            this.rtbConsole.Size = new System.Drawing.Size(425, 122);
            this.rtbConsole.TabIndex = 15;
            this.rtbConsole.Text = "";
            // 
            // btnGetChannels
            // 
            this.btnGetChannels.Location = new System.Drawing.Point(430, 89);
            this.btnGetChannels.Name = "btnGetChannels";
            this.btnGetChannels.Size = new System.Drawing.Size(139, 23);
            this.btnGetChannels.TabIndex = 16;
            this.btnGetChannels.Text = "Populate Channels";
            this.btnGetChannels.UseVisualStyleBackColor = true;
            this.btnGetChannels.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cmbChannels
            // 
            this.cmbChannels.FormattingEnabled = true;
            this.cmbChannels.Location = new System.Drawing.Point(144, 86);
            this.cmbChannels.Name = "cmbChannels";
            this.cmbChannels.Size = new System.Drawing.Size(235, 21);
            this.cmbChannels.TabIndex = 17;
            this.cmbChannels.SelectedIndexChanged += new System.EventHandler(this.cbxChannelList_SelectedIndexChanged);
            // 
            // cmbEnvironments
            // 
            this.cmbEnvironments.FormattingEnabled = true;
            this.cmbEnvironments.Location = new System.Drawing.Point(144, 269);
            this.cmbEnvironments.Name = "cmbEnvironments";
            this.cmbEnvironments.Size = new System.Drawing.Size(235, 21);
            this.cmbEnvironments.TabIndex = 18;
            this.cmbEnvironments.SelectedIndexChanged += new System.EventHandler(this.cmbEnvironments_SelectedIndexChanged);
            // 
            // btnGetEnv
            // 
            this.btnGetEnv.Location = new System.Drawing.Point(430, 269);
            this.btnGetEnv.Name = "btnGetEnv";
            this.btnGetEnv.Size = new System.Drawing.Size(139, 23);
            this.btnGetEnv.TabIndex = 19;
            this.btnGetEnv.Text = "Populate Environments";
            this.btnGetEnv.UseVisualStyleBackColor = true;
            this.btnGetEnv.Click += new System.EventHandler(this.GetEnv_Click);
            // 
            // cmbRelease
            // 
            this.cmbRelease.FormattingEnabled = true;
            this.cmbRelease.Location = new System.Drawing.Point(144, 224);
            this.cmbRelease.Name = "cmbRelease";
            this.cmbRelease.Size = new System.Drawing.Size(235, 21);
            this.cmbRelease.TabIndex = 20;
            this.cmbRelease.SelectedIndexChanged += new System.EventHandler(this.cmbRelease_SelectedIndexChanged);
            // 
            // btnGetRelease
            // 
            this.btnGetRelease.Location = new System.Drawing.Point(430, 224);
            this.btnGetRelease.Name = "btnGetRelease";
            this.btnGetRelease.Size = new System.Drawing.Size(139, 23);
            this.btnGetRelease.TabIndex = 21;
            this.btnGetRelease.Text = "Populate Release";
            this.btnGetRelease.UseVisualStyleBackColor = true;
            this.btnGetRelease.Click += new System.EventHandler(this.btnRelease_Click);
            // 
            // btnCreateRelease
            // 
            this.btnCreateRelease.Location = new System.Drawing.Point(430, 148);
            this.btnCreateRelease.Name = "btnCreateRelease";
            this.btnCreateRelease.Size = new System.Drawing.Size(139, 23);
            this.btnCreateRelease.TabIndex = 22;
            this.btnCreateRelease.Text = "Create Release";
            this.btnCreateRelease.UseVisualStyleBackColor = true;
            this.btnCreateRelease.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDeploy
            // 
            this.btnDeploy.Location = new System.Drawing.Point(288, 321);
            this.btnDeploy.Name = "btnDeploy";
            this.btnDeploy.Size = new System.Drawing.Size(139, 27);
            this.btnDeploy.TabIndex = 23;
            this.btnDeploy.Text = "Deploy Release";
            this.btnDeploy.UseVisualStyleBackColor = true;
            this.btnDeploy.Click += new System.EventHandler(this.btnDeploy_Click);
            // 
            // lblReleaseName
            // 
            this.lblReleaseName.AutoSize = true;
            this.lblReleaseName.Location = new System.Drawing.Point(47, 180);
            this.lblReleaseName.Name = "lblReleaseName";
            this.lblReleaseName.Size = new System.Drawing.Size(80, 13);
            this.lblReleaseName.TabIndex = 24;
            this.lblReleaseName.Text = "Release Name:";
            // 
            // txtbxReleaseName
            // 
            this.txtbxReleaseName.Location = new System.Drawing.Point(144, 173);
            this.txtbxReleaseName.Name = "txtbxReleaseName";
            this.txtbxReleaseName.Size = new System.Drawing.Size(235, 20);
            this.txtbxReleaseName.TabIndex = 25;
            // 
            // lblBDL
            // 
            this.lblBDL.AutoSize = true;
            this.lblBDL.Location = new System.Drawing.Point(47, 499);
            this.lblBDL.Name = "lblBDL";
            this.lblBDL.Size = new System.Drawing.Size(169, 13);
            this.lblBDL.TabIndex = 26;
            this.lblBDL.Text = "Block on Dataloss (true or false)? :";
            // 
            // txtbxBDL
            // 
            this.txtbxBDL.Location = new System.Drawing.Point(334, 492);
            this.txtbxBDL.Name = "txtbxBDL";
            this.txtbxBDL.Size = new System.Drawing.Size(235, 20);
            this.txtbxBDL.TabIndex = 27;
            // 
            // lblDSU
            // 
            this.lblDSU.AutoSize = true;
            this.lblDSU.Location = new System.Drawing.Point(47, 536);
            this.lblDSU.Name = "lblDSU";
            this.lblDSU.Size = new System.Drawing.Size(256, 13);
            this.lblDSU.TabIndex = 28;
            this.lblDSU.Text = "Deploy Schema Update to target DB (true or false)? :";
            // 
            // lblDRS
            // 
            this.lblDRS.AutoSize = true;
            this.lblDRS.Location = new System.Drawing.Point(47, 572);
            this.lblDRS.Name = "lblDRS";
            this.lblDRS.Size = new System.Drawing.Size(288, 13);
            this.lblDRS.TabIndex = 29;
            this.lblDRS.Text = "DBRestoreSource\t(options: none, baseline, prune, testdb)? :";
            // 
            // lblGFM
            // 
            this.lblGFM.AutoSize = true;
            this.lblGFM.Location = new System.Drawing.Point(47, 607);
            this.lblGFM.Name = "lblGFM";
            this.lblGFM.Size = new System.Drawing.Size(167, 13);
            this.lblGFM.TabIndex = 30;
            this.lblGFM.Text = "Use Guidedfailure (true or false)? :";
            // 
            // txtbxDSU
            // 
            this.txtbxDSU.Location = new System.Drawing.Point(334, 529);
            this.txtbxDSU.Name = "txtbxDSU";
            this.txtbxDSU.Size = new System.Drawing.Size(235, 20);
            this.txtbxDSU.TabIndex = 31;
            // 
            // txtbxDBR
            // 
            this.txtbxDBR.Location = new System.Drawing.Point(334, 565);
            this.txtbxDBR.Name = "txtbxDBR";
            this.txtbxDBR.Size = new System.Drawing.Size(235, 20);
            this.txtbxDBR.TabIndex = 32;
            // 
            // txtbxUGF
            // 
            this.txtbxUGF.Location = new System.Drawing.Point(334, 600);
            this.txtbxUGF.Name = "txtbxUGF";
            this.txtbxUGF.Size = new System.Drawing.Size(235, 20);
            this.txtbxUGF.TabIndex = 33;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(605, 354);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(260, 274);
            this.checkedListBox1.TabIndex = 34;
            // 
            // chkbxSelectAll
            // 
            this.chkbxSelectAll.AutoSize = true;
            this.chkbxSelectAll.Location = new System.Drawing.Point(785, 331);
            this.chkbxSelectAll.Name = "chkbxSelectAll";
            this.chkbxSelectAll.Size = new System.Drawing.Size(70, 17);
            this.chkbxSelectAll.TabIndex = 37;
            this.chkbxSelectAll.Text = "Select All";
            this.chkbxSelectAll.UseVisualStyleBackColor = true;
            this.chkbxSelectAll.CheckedChanged += new System.EventHandler(this.chkbxSelectAll_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(605, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Steps to be Skipped:";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(903, 643);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkbxSelectAll);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.txtbxUGF);
            this.Controls.Add(this.txtbxDBR);
            this.Controls.Add(this.txtbxDSU);
            this.Controls.Add(this.lblGFM);
            this.Controls.Add(this.lblDRS);
            this.Controls.Add(this.lblDSU);
            this.Controls.Add(this.txtbxBDL);
            this.Controls.Add(this.lblBDL);
            this.Controls.Add(this.txtbxReleaseName);
            this.Controls.Add(this.lblReleaseName);
            this.Controls.Add(this.btnDeploy);
            this.Controls.Add(this.btnCreateRelease);
            this.Controls.Add(this.btnGetRelease);
            this.Controls.Add(this.cmbRelease);
            this.Controls.Add(this.btnGetEnv);
            this.Controls.Add(this.cmbEnvironments);
            this.Controls.Add(this.cmbChannels);
            this.Controls.Add(this.btnGetChannels);
            this.Controls.Add(this.rtbConsole);
            this.Controls.Add(this.chkboxShowPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbxPackageVersion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkboxRememberMe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtboxPassword);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Octopus Deployment Tool V2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtboxPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkboxRememberMe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbxPackageVersion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkboxShowPassword;
        private System.Windows.Forms.RichTextBox rtbConsole;
        private System.Windows.Forms.Button btnGetChannels;
        private System.Windows.Forms.ComboBox cmbChannels;
        private System.Windows.Forms.ComboBox cmbEnvironments;
        private System.Windows.Forms.Button btnGetEnv;
        private System.Windows.Forms.ComboBox cmbRelease;
        private System.Windows.Forms.Button btnGetRelease;
        private System.Windows.Forms.Button btnCreateRelease;
        private System.Windows.Forms.Button btnDeploy;
        private System.Windows.Forms.Label lblReleaseName;
        private System.Windows.Forms.TextBox txtbxReleaseName;
        private System.Windows.Forms.Label lblBDL;
        private System.Windows.Forms.TextBox txtbxBDL;
        private System.Windows.Forms.Label lblDSU;
        private System.Windows.Forms.Label lblDRS;
        private System.Windows.Forms.Label lblGFM;
        private System.Windows.Forms.TextBox txtbxDSU;
        private System.Windows.Forms.TextBox txtbxDBR;
        private System.Windows.Forms.TextBox txtbxUGF;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckBox chkbxSelectAll;
        private System.Windows.Forms.Label label1;
    }
}

