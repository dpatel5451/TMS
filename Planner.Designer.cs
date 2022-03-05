namespace TMS
{


	partial class Planner
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
			this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.activeOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.generaateReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.rOrdersDropDown = new System.Windows.Forms.ComboBox();
			this.rOrder = new System.Windows.Forms.Label();
			this.gTime = new System.Windows.Forms.Label();
			this.gAllTimeRadio = new System.Windows.Forms.RadioButton();
			this.g2WeeksRadio = new System.Windows.Forms.RadioButton();
			this.gGenerateButton = new System.Windows.Forms.Button();
			this.rSelectCarriersButton = new System.Windows.Forms.Button();
			this.rrAvailableCarriers = new System.Windows.Forms.Label();
			this.rrCarriersDropDown = new System.Windows.Forms.ComboBox();
			this.rrAddCarrierButton = new System.Windows.Forms.Button();
			this.aViewButton = new System.Windows.Forms.Button();
			this.aOrigin = new System.Windows.Forms.Label();
			this.aOriginValue = new System.Windows.Forms.Label();
			this.aDest = new System.Windows.Forms.Label();
			this.aDestValue = new System.Windows.Forms.Label();
			this.aDate = new System.Windows.Forms.Label();
			this.aDateValue = new System.Windows.Forms.Label();
			this.aStart = new System.Windows.Forms.Label();
			this.aStartValue = new System.Windows.Forms.Label();
			this.aEnd = new System.Windows.Forms.Label();
			this.aEndValue = new System.Windows.Forms.Label();
			this.aCompleteButton = new System.Windows.Forms.Button();
			this.pLabel = new System.Windows.Forms.Label();
			this.pPass = new System.Windows.Forms.TextBox();
			this.pLoginButton = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordersToolStripMenuItem,
            this.activeOrdersToolStripMenuItem,
            this.generaateReportToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 28);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// ordersToolStripMenuItem
			// 
			this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
			this.ordersToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
			this.ordersToolStripMenuItem.Text = "Received Orders";
			this.ordersToolStripMenuItem.Click += new System.EventHandler(this.OrdersToolStripMenuItem_Click);
			// 
			// activeOrdersToolStripMenuItem
			// 
			this.activeOrdersToolStripMenuItem.Name = "activeOrdersToolStripMenuItem";
			this.activeOrdersToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
			this.activeOrdersToolStripMenuItem.Text = "Active Orders";
			this.activeOrdersToolStripMenuItem.Click += new System.EventHandler(this.ActiveOrdersToolStripMenuItem_Click);
			// 
			// generaateReportToolStripMenuItem
			// 
			this.generaateReportToolStripMenuItem.Name = "generaateReportToolStripMenuItem";
			this.generaateReportToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
			this.generaateReportToolStripMenuItem.Text = "Generate Report";
			this.generaateReportToolStripMenuItem.Click += new System.EventHandler(this.GenerateReportToolStripMenuItem_Click);
			// 
			// rOrdersDropDown
			// 
			this.rOrdersDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.rOrdersDropDown.FormattingEnabled = true;
			this.rOrdersDropDown.Location = new System.Drawing.Point(12, 69);
			this.rOrdersDropDown.Name = "rOrdersDropDown";
			this.rOrdersDropDown.Size = new System.Drawing.Size(151, 28);
			this.rOrdersDropDown.TabIndex = 1;
			// 
			// rOrder
			// 
			this.rOrder.AutoSize = true;
			this.rOrder.Location = new System.Drawing.Point(12, 46);
			this.rOrder.Name = "rOrder";
			this.rOrder.Size = new System.Drawing.Size(60, 20);
			this.rOrder.TabIndex = 2;
			this.rOrder.Text = "Orders :";
			// 
			// gTime
			// 
			this.gTime.AutoSize = true;
			this.gTime.Location = new System.Drawing.Point(325, 177);
			this.gTime.Name = "gTime";
			this.gTime.Size = new System.Drawing.Size(57, 20);
			this.gTime.TabIndex = 3;
			this.gTime.Text = "Time :  ";
			// 
			// gAllTimeRadio
			// 
			this.gAllTimeRadio.AutoSize = true;
			this.gAllTimeRadio.Location = new System.Drawing.Point(325, 221);
			this.gAllTimeRadio.Name = "gAllTimeRadio";
			this.gAllTimeRadio.Size = new System.Drawing.Size(85, 24);
			this.gAllTimeRadio.TabIndex = 4;
			this.gAllTimeRadio.TabStop = true;
			this.gAllTimeRadio.Text = "All Time";
			this.gAllTimeRadio.UseVisualStyleBackColor = true;
			// 
			// g2WeeksRadio
			// 
			this.g2WeeksRadio.AutoSize = true;
			this.g2WeeksRadio.Location = new System.Drawing.Point(325, 263);
			this.g2WeeksRadio.Name = "g2WeeksRadio";
			this.g2WeeksRadio.Size = new System.Drawing.Size(114, 24);
			this.g2WeeksRadio.TabIndex = 5;
			this.g2WeeksRadio.TabStop = true;
			this.g2WeeksRadio.Text = "Past 2 Weeks";
			this.g2WeeksRadio.UseVisualStyleBackColor = true;
			// 
			// gGenerateButton
			// 
			this.gGenerateButton.Location = new System.Drawing.Point(636, 388);
			this.gGenerateButton.Name = "gGenerateButton";
			this.gGenerateButton.Size = new System.Drawing.Size(138, 29);
			this.gGenerateButton.TabIndex = 6;
			this.gGenerateButton.Text = "Generate Report";
			this.gGenerateButton.UseVisualStyleBackColor = true;
			this.gGenerateButton.Click += new System.EventHandler(this.gGenerateButton_Click);
			// 
			// rSelectCarriersButton
			// 
			this.rSelectCarriersButton.Location = new System.Drawing.Point(183, 69);
			this.rSelectCarriersButton.Name = "rSelectCarriersButton";
			this.rSelectCarriersButton.Size = new System.Drawing.Size(118, 29);
			this.rSelectCarriersButton.TabIndex = 7;
			this.rSelectCarriersButton.Text = "Select Carriers";
			this.rSelectCarriersButton.UseVisualStyleBackColor = true;
			this.rSelectCarriersButton.Click += new System.EventHandler(this.rSelectCarriersButton_Click);
			// 
			// rrAvailableCarriers
			// 
			this.rrAvailableCarriers.AutoSize = true;
			this.rrAvailableCarriers.Location = new System.Drawing.Point(12, 143);
			this.rrAvailableCarriers.Name = "rrAvailableCarriers";
			this.rrAvailableCarriers.Size = new System.Drawing.Size(132, 20);
			this.rrAvailableCarriers.TabIndex = 8;
			this.rrAvailableCarriers.Text = "Available Carriers :";
			// 
			// rrCarriersDropDown
			// 
			this.rrCarriersDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.rrCarriersDropDown.FormattingEnabled = true;
			this.rrCarriersDropDown.Location = new System.Drawing.Point(150, 140);
			this.rrCarriersDropDown.Name = "rrCarriersDropDown";
			this.rrCarriersDropDown.Size = new System.Drawing.Size(151, 28);
			this.rrCarriersDropDown.TabIndex = 9;
			// 
			// rrAddCarrierButton
			// 
			this.rrAddCarrierButton.Location = new System.Drawing.Point(325, 139);
			this.rrAddCarrierButton.Name = "rrAddCarrierButton";
			this.rrAddCarrierButton.Size = new System.Drawing.Size(94, 29);
			this.rrAddCarrierButton.TabIndex = 10;
			this.rrAddCarrierButton.Text = "Add Carrier";
			this.rrAddCarrierButton.UseVisualStyleBackColor = true;
			this.rrAddCarrierButton.Click += new System.EventHandler(this.rrAddCarrierButton_Click);
			// 
			// aViewButton
			// 
			this.aViewButton.Location = new System.Drawing.Point(183, 69);
			this.aViewButton.Name = "aViewButton";
			this.aViewButton.Size = new System.Drawing.Size(118, 29);
			this.aViewButton.TabIndex = 11;
			this.aViewButton.Text = "View Details";
			this.aViewButton.UseVisualStyleBackColor = true;
			this.aViewButton.Click += new System.EventHandler(this.aViewButton_Click);
			// 
			// aOrigin
			// 
			this.aOrigin.AutoSize = true;
			this.aOrigin.Location = new System.Drawing.Point(12, 123);
			this.aOrigin.Name = "aOrigin";
			this.aOrigin.Size = new System.Drawing.Size(57, 20);
			this.aOrigin.TabIndex = 12;
			this.aOrigin.Text = "Origin :";
			// 
			// aOriginValue
			// 
			this.aOriginValue.AutoSize = true;
			this.aOriginValue.Location = new System.Drawing.Point(75, 123);
			this.aOriginValue.Name = "aOriginValue";
			this.aOriginValue.Size = new System.Drawing.Size(58, 20);
			this.aOriginValue.TabIndex = 13;
			this.aOriginValue.Text = "[origin]";
			// 
			// aDest
			// 
			this.aDest.AutoSize = true;
			this.aDest.Location = new System.Drawing.Point(193, 123);
			this.aDest.Name = "aDest";
			this.aDest.Size = new System.Drawing.Size(92, 20);
			this.aDest.TabIndex = 14;
			this.aDest.Text = "Destination :";
			// 
			// aDestValue
			// 
			this.aDestValue.AutoSize = true;
			this.aDestValue.Location = new System.Drawing.Point(291, 123);
			this.aDestValue.Name = "aDestValue";
			this.aDestValue.Size = new System.Drawing.Size(93, 20);
			this.aDestValue.TabIndex = 15;
			this.aDestValue.Text = "[destination]";
			// 
			// aDate
			// 
			this.aDate.AutoSize = true;
			this.aDate.Location = new System.Drawing.Point(12, 177);
			this.aDate.Name = "aDate";
			this.aDate.Size = new System.Drawing.Size(90, 20);
			this.aDate.TabIndex = 16;
			this.aDate.Text = "Order Date :";
			// 
			// aDateValue
			// 
			this.aDateValue.AutoSize = true;
			this.aDateValue.Location = new System.Drawing.Point(108, 177);
			this.aDateValue.Name = "aDateValue";
			this.aDateValue.Size = new System.Drawing.Size(49, 20);
			this.aDateValue.TabIndex = 17;
			this.aDateValue.Text = "[date]";
			// 
			// aStart
			// 
			this.aStart.AutoSize = true;
			this.aStart.Location = new System.Drawing.Point(12, 225);
			this.aStart.Name = "aStart";
			this.aStart.Size = new System.Drawing.Size(84, 20);
			this.aStart.TabIndex = 18;
			this.aStart.Text = "Start Time :";
			// 
			// aStartValue
			// 
			this.aStartValue.AutoSize = true;
			this.aStartValue.Location = new System.Drawing.Point(108, 225);
			this.aStartValue.Name = "aStartValue";
			this.aStartValue.Size = new System.Drawing.Size(49, 20);
			this.aStartValue.TabIndex = 19;
			this.aStartValue.Text = "[time]";
			// 
			// aEnd
			// 
			this.aEnd.AutoSize = true;
			this.aEnd.Location = new System.Drawing.Point(12, 285);
			this.aEnd.Name = "aEnd";
			this.aEnd.Size = new System.Drawing.Size(119, 20);
			this.aEnd.TabIndex = 20;
			this.aEnd.Text = "Estimated Time :";
			// 
			// aEndValue
			// 
			this.aEndValue.AutoSize = true;
			this.aEndValue.Location = new System.Drawing.Point(137, 285);
			this.aEndValue.Name = "aEndValue";
			this.aEndValue.Size = new System.Drawing.Size(44, 20);
			this.aEndValue.TabIndex = 21;
			this.aEndValue.Text = "[end]";
			// 
			// aCompleteButton
			// 
			this.aCompleteButton.Location = new System.Drawing.Point(207, 371);
			this.aCompleteButton.Name = "aCompleteButton";
			this.aCompleteButton.Size = new System.Drawing.Size(94, 29);
			this.aCompleteButton.TabIndex = 22;
			this.aCompleteButton.Text = "Complete Order";
			this.aCompleteButton.UseVisualStyleBackColor = true;
			this.aCompleteButton.Click += new System.EventHandler(this.aCompleteButton_Click);
			// 
			// pLabel
			// 
			this.pLabel.AutoSize = true;
			this.pLabel.Location = new System.Drawing.Point(325, 139);
			this.pLabel.Name = "pLabel";
			this.pLabel.Size = new System.Drawing.Size(161, 20);
			this.pLabel.TabIndex = 23;
			this.pLabel.Text = "Please Enter Password :";
			// 
			// pPass
			// 
			this.pPass.Location = new System.Drawing.Point(342, 177);
			this.pPass.Name = "pPass";
			this.pPass.PasswordChar = '*';
			this.pPass.Size = new System.Drawing.Size(125, 27);
			this.pPass.TabIndex = 24;
			// 
			// pLoginButton
			// 
			this.pLoginButton.Location = new System.Drawing.Point(354, 225);
			this.pLoginButton.Name = "pLoginButton";
			this.pLoginButton.Size = new System.Drawing.Size(94, 29);
			this.pLoginButton.TabIndex = 25;
			this.pLoginButton.Text = "Login";
			this.pLoginButton.UseVisualStyleBackColor = true;
			this.pLoginButton.Click += new System.EventHandler(this.pLoginButton_Click);
			// 
			// Planner
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.pLoginButton);
			this.Controls.Add(this.pPass);
			this.Controls.Add(this.pLabel);
			this.Controls.Add(this.aCompleteButton);
			this.Controls.Add(this.aEndValue);
			this.Controls.Add(this.aEnd);
			this.Controls.Add(this.aStartValue);
			this.Controls.Add(this.aStart);
			this.Controls.Add(this.aDateValue);
			this.Controls.Add(this.aDate);
			this.Controls.Add(this.aDestValue);
			this.Controls.Add(this.aDest);
			this.Controls.Add(this.aOriginValue);
			this.Controls.Add(this.aOrigin);
			this.Controls.Add(this.aViewButton);
			this.Controls.Add(this.rrAddCarrierButton);
			this.Controls.Add(this.rrCarriersDropDown);
			this.Controls.Add(this.rrAvailableCarriers);
			this.Controls.Add(this.rSelectCarriersButton);
			this.Controls.Add(this.gGenerateButton);
			this.Controls.Add(this.g2WeeksRadio);
			this.Controls.Add(this.gAllTimeRadio);
			this.Controls.Add(this.gTime);
			this.Controls.Add(this.rOrder);
			this.Controls.Add(this.rOrdersDropDown);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Planner";
			this.Text = "Planner";
			this.Load += new System.EventHandler(this.Planner_StartingPage_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem ordersToolStripMenuItem;
		private ComboBox rOrdersDropDown;
		private ToolStripMenuItem activeOrdersToolStripMenuItem;
		private ToolStripMenuItem generaateReportToolStripMenuItem;
		private Label rOrder;
		private Label gTime;
		private RadioButton gAllTimeRadio;
		private RadioButton g2WeeksRadio;
		private Button gGenerateButton;
		private Button rSelectCarriersButton;
		private Label rrAvailableCarriers;
		private ComboBox rrCarriersDropDown;
		private Button rrAddCarrierButton;
		private Button aViewButton;
		private Label aOrigin;
		private Label aOriginValue;
		private Label aDest;
		private Label aDestValue;
		private Label aDate;
		private Label aDateValue;
		private Label aStart;
		private Label aStartValue;
		private Label aEnd;
		private Label aEndValue;
		private Button aCompleteButton;
		private Label pLabel;
		private TextBox pPass;
		private Button pLoginButton;
	}
}