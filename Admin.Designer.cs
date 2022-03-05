namespace TMS
{



	partial class Admin
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.generalConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reviewLogFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.alterTMSDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gLog = new System.Windows.Forms.Label();
			this.gIp = new System.Windows.Forms.Label();
			this.gPortTMS = new System.Windows.Forms.Label();
			this.gLogFileDirectory = new System.Windows.Forms.TextBox();
			this.gPortTextBox = new System.Windows.Forms.TextBox();
			this.gIPTextBox = new System.Windows.Forms.TextBox();
			this.rLogData = new System.Windows.Forms.Label();
			this.rLogBox = new System.Windows.Forms.RichTextBox();
			this.bBackup = new System.Windows.Forms.Label();
			this.bBackupLocation = new System.Windows.Forms.TextBox();
			this.bBackupButton = new System.Windows.Forms.Button();
			this.gSaveButton = new System.Windows.Forms.Button();
			this.gUserTMS = new System.Windows.Forms.Label();
			this.gUserNameTMS = new System.Windows.Forms.TextBox();
			this.gPass = new System.Windows.Forms.Label();
			this.gPassword = new System.Windows.Forms.TextBox();
			this.aQueryText = new System.Windows.Forms.RichTextBox();
			this.aRunButton = new System.Windows.Forms.Button();
			this.pPass = new System.Windows.Forms.TextBox();
			this.pLabel = new System.Windows.Forms.Label();
			this.pLoginButton = new System.Windows.Forms.Button();
			this.rClearButton = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalConfigurationToolStripMenuItem,
            this.reviewLogFilesToolStripMenuItem,
            this.alterTMSDataToolStripMenuItem,
            this.backupToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 28);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// generalConfigurationToolStripMenuItem
			// 
			this.generalConfigurationToolStripMenuItem.Name = "generalConfigurationToolStripMenuItem";
			this.generalConfigurationToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
			this.generalConfigurationToolStripMenuItem.Text = "General Configuration";
			this.generalConfigurationToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopLeft;
			this.generalConfigurationToolStripMenuItem.Click += new System.EventHandler(this.GeneralConfigurationToolStripMenuItem_Click);
			// 
			// reviewLogFilesToolStripMenuItem
			// 
			this.reviewLogFilesToolStripMenuItem.Name = "reviewLogFilesToolStripMenuItem";
			this.reviewLogFilesToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
			this.reviewLogFilesToolStripMenuItem.Text = "Review Log Files";
			this.reviewLogFilesToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopLeft;
			this.reviewLogFilesToolStripMenuItem.Click += new System.EventHandler(this.ReviewLogFilesToolStripMenuItem_Click);
			// 
			// alterTMSDataToolStripMenuItem
			// 
			this.alterTMSDataToolStripMenuItem.Name = "alterTMSDataToolStripMenuItem";
			this.alterTMSDataToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
			this.alterTMSDataToolStripMenuItem.Text = "Alter TMS Data";
			this.alterTMSDataToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopLeft;
			this.alterTMSDataToolStripMenuItem.Click += new System.EventHandler(this.AlterTMSDataToolStripMenuItem_Click);
			// 
			// backupToolStripMenuItem
			// 
			this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
			this.backupToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
			this.backupToolStripMenuItem.Text = "Backup";
			this.backupToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopLeft;
			this.backupToolStripMenuItem.Click += new System.EventHandler(this.BackupToolStripMenuItem_Click);
			// 
			// gLog
			// 
			this.gLog.AutoSize = true;
			this.gLog.Location = new System.Drawing.Point(12, 65);
			this.gLog.Name = "gLog";
			this.gLog.Size = new System.Drawing.Size(133, 20);
			this.gLog.TabIndex = 1;
			this.gLog.Text = "Log File Directory :";
			// 
			// gIp
			// 
			this.gIp.AutoSize = true;
			this.gIp.Location = new System.Drawing.Point(12, 123);
			this.gIp.Name = "gIp";
			this.gIp.Size = new System.Drawing.Size(191, 20);
			this.gIp.TabIndex = 2;
			this.gIp.Text = "IP Address(TMS Database) :";
			// 
			// gPortTMS
			// 
			this.gPortTMS.AutoSize = true;
			this.gPortTMS.Location = new System.Drawing.Point(12, 182);
			this.gPortTMS.Name = "gPortTMS";
			this.gPortTMS.Size = new System.Drawing.Size(148, 20);
			this.gPortTMS.TabIndex = 3;
			this.gPortTMS.Text = "Port(TMS Database) :";
			// 
			// gLogFileDirectory
			// 
			this.gLogFileDirectory.Location = new System.Drawing.Point(225, 65);
			this.gLogFileDirectory.Name = "gLogFileDirectory";
			this.gLogFileDirectory.Size = new System.Drawing.Size(282, 27);
			this.gLogFileDirectory.TabIndex = 4;
			// 
			// gPortTextBox
			// 
			this.gPortTextBox.Location = new System.Drawing.Point(225, 182);
			this.gPortTextBox.Name = "gPortTextBox";
			this.gPortTextBox.Size = new System.Drawing.Size(119, 27);
			this.gPortTextBox.TabIndex = 6;
			// 
			// gIPTextBox
			// 
			this.gIPTextBox.Location = new System.Drawing.Point(225, 123);
			this.gIPTextBox.Name = "gIPTextBox";
			this.gIPTextBox.Size = new System.Drawing.Size(125, 27);
			this.gIPTextBox.TabIndex = 7;
			// 
			// rLogData
			// 
			this.rLogData.AutoSize = true;
			this.rLogData.Location = new System.Drawing.Point(12, 65);
			this.rLogData.Name = "rLogData";
			this.rLogData.Size = new System.Drawing.Size(103, 20);
			this.rLogData.TabIndex = 8;
			this.rLogData.Text = "Logged Data: ";
			// 
			// rLogBox
			// 
			this.rLogBox.AcceptsTab = true;
			this.rLogBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
			this.rLogBox.Location = new System.Drawing.Point(131, 65);
			this.rLogBox.Name = "rLogBox";
			this.rLogBox.ReadOnly = true;
			this.rLogBox.Size = new System.Drawing.Size(630, 331);
			this.rLogBox.TabIndex = 9;
			this.rLogBox.Text = "";
			// 
			// bBackup
			// 
			this.bBackup.AutoSize = true;
			this.bBackup.Location = new System.Drawing.Point(12, 65);
			this.bBackup.Name = "bBackup";
			this.bBackup.Size = new System.Drawing.Size(125, 20);
			this.bBackup.TabIndex = 10;
			this.bBackup.Text = "Backup Location :";
			// 
			// bBackupLocation
			// 
			this.bBackupLocation.Location = new System.Drawing.Point(151, 65);
			this.bBackupLocation.Name = "bBackupLocation";
			this.bBackupLocation.Size = new System.Drawing.Size(193, 27);
			this.bBackupLocation.TabIndex = 11;
			// 
			// bBackupButton
			// 
			this.bBackupButton.Location = new System.Drawing.Point(380, 65);
			this.bBackupButton.Name = "bBackupButton";
			this.bBackupButton.Size = new System.Drawing.Size(94, 29);
			this.bBackupButton.TabIndex = 12;
			this.bBackupButton.Text = "Backup";
			this.bBackupButton.UseVisualStyleBackColor = true;
			this.bBackupButton.Click += new System.EventHandler(this.BBackupButton_Click);
			// 
			// gSaveButton
			// 
			this.gSaveButton.Location = new System.Drawing.Point(610, 360);
			this.gSaveButton.Name = "gSaveButton";
			this.gSaveButton.Size = new System.Drawing.Size(94, 29);
			this.gSaveButton.TabIndex = 13;
			this.gSaveButton.Text = "Save";
			this.gSaveButton.UseVisualStyleBackColor = true;
			this.gSaveButton.Click += new System.EventHandler(this.GSaveButton_Click);
			// 
			// gUserTMS
			// 
			this.gUserTMS.AutoSize = true;
			this.gUserTMS.Location = new System.Drawing.Point(12, 237);
			this.gUserTMS.Name = "gUserTMS";
			this.gUserTMS.Size = new System.Drawing.Size(151, 20);
			this.gUserTMS.TabIndex = 14;
			this.gUserTMS.Text = "User(TMS Database) :";
			// 
			// gUserNameTMS
			// 
			this.gUserNameTMS.Location = new System.Drawing.Point(225, 237);
			this.gUserNameTMS.Name = "gUserNameTMS";
			this.gUserNameTMS.Size = new System.Drawing.Size(125, 27);
			this.gUserNameTMS.TabIndex = 15;
			// 
			// gPass
			// 
			this.gPass.AutoSize = true;
			this.gPass.Location = new System.Drawing.Point(17, 291);
			this.gPass.Name = "gPass";
			this.gPass.Size = new System.Drawing.Size(187, 20);
			this.gPass.TabIndex = 16;
			this.gPass.Text = "Password (TMS Database) :";
			// 
			// gPassword
			// 
			this.gPassword.Location = new System.Drawing.Point(225, 291);
			this.gPassword.Name = "gPassword";
			this.gPassword.Size = new System.Drawing.Size(125, 27);
			this.gPassword.TabIndex = 17;
			// 
			// aQueryText
			// 
			this.aQueryText.Location = new System.Drawing.Point(17, 48);
			this.aQueryText.Name = "aQueryText";
			this.aQueryText.Size = new System.Drawing.Size(755, 341);
			this.aQueryText.TabIndex = 18;
			this.aQueryText.Text = "";
			// 
			// aRunButton
			// 
			this.aRunButton.Location = new System.Drawing.Point(610, 395);
			this.aRunButton.Name = "aRunButton";
			this.aRunButton.Size = new System.Drawing.Size(121, 29);
			this.aRunButton.TabIndex = 19;
			this.aRunButton.Text = "Run SQL Query";
			this.aRunButton.UseVisualStyleBackColor = true;
			this.aRunButton.Click += new System.EventHandler(this.aRunButton_Click);
			// 
			// pPass
			// 
			this.pPass.Location = new System.Drawing.Point(335, 215);
			this.pPass.Name = "pPass";
			this.pPass.PasswordChar = '*';
			this.pPass.Size = new System.Drawing.Size(125, 27);
			this.pPass.TabIndex = 20;
			// 
			// pLabel
			// 
			this.pLabel.AutoSize = true;
			this.pLabel.Location = new System.Drawing.Point(315, 182);
			this.pLabel.Name = "pLabel";
			this.pLabel.Size = new System.Drawing.Size(157, 20);
			this.pLabel.TabIndex = 21;
			this.pLabel.Text = "Please Enter Password:";
			// 
			// pLoginButton
			// 
			this.pLoginButton.Location = new System.Drawing.Point(347, 270);
			this.pLoginButton.Name = "pLoginButton";
			this.pLoginButton.Size = new System.Drawing.Size(94, 29);
			this.pLoginButton.TabIndex = 22;
			this.pLoginButton.Text = "Login";
			this.pLoginButton.UseVisualStyleBackColor = true;
			this.pLoginButton.Click += new System.EventHandler(this.pLoginButton_Click);
			// 
			// rClearButton
			// 
			this.rClearButton.Location = new System.Drawing.Point(626, 409);
			this.rClearButton.Name = "rClearButton";
			this.rClearButton.Size = new System.Drawing.Size(146, 29);
			this.rClearButton.TabIndex = 23;
			this.rClearButton.Text = "Clear Logged Data";
			this.rClearButton.UseVisualStyleBackColor = true;
			this.rClearButton.Click += new System.EventHandler(this.rClearButton_Click);
			// 
			// Admin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.rClearButton);
			this.Controls.Add(this.pLoginButton);
			this.Controls.Add(this.pLabel);
			this.Controls.Add(this.pPass);
			this.Controls.Add(this.aRunButton);
			this.Controls.Add(this.aQueryText);
			this.Controls.Add(this.gPassword);
			this.Controls.Add(this.gPass);
			this.Controls.Add(this.gUserNameTMS);
			this.Controls.Add(this.gUserTMS);
			this.Controls.Add(this.gSaveButton);
			this.Controls.Add(this.bBackupButton);
			this.Controls.Add(this.bBackupLocation);
			this.Controls.Add(this.bBackup);
			this.Controls.Add(this.rLogBox);
			this.Controls.Add(this.rLogData);
			this.Controls.Add(this.gIPTextBox);
			this.Controls.Add(this.gPortTextBox);
			this.Controls.Add(this.gLogFileDirectory);
			this.Controls.Add(this.gPortTMS);
			this.Controls.Add(this.gIp);
			this.Controls.Add(this.gLog);
			this.Controls.Add(this.menuStrip1);
			this.Name = "Admin";
			this.Text = "Admin";
			this.Load += new System.EventHandler(this.Admin_StartingPage_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem generalConfigurationToolStripMenuItem;
		private ToolStripMenuItem reviewLogFilesToolStripMenuItem;
		private ToolStripMenuItem alterTMSDataToolStripMenuItem;
		private ToolStripMenuItem backupToolStripMenuItem;
		private Label gLog;
		private Label gIp;
		private Label gPortTMS;
		private TextBox gLogFileDirectory;
		private TextBox gPortTextBox;
		private TextBox gIPTextBox;
		private Label rLogData;
		private RichTextBox rLogBox;
		private Label bBackup;
		private TextBox bBackupLocation;
		private Button bBackupButton;
		private Button gSaveButton;
		private Label gUserTMS;
		private TextBox gUserNameTMS;
		private Label gPass;
		private TextBox gPassword;
		private RichTextBox aQueryText;
		private Button aRunButton;
		private TextBox pPass;
		private Label pLabel;
		private Button pLoginButton;
		private Button rClearButton;
	}
}