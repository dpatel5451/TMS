namespace TMS
{
	

	partial class Buyer
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
			this.initiateContractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.initiateOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reviewCompletedOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cRefreshButton = new System.Windows.Forms.Button();
			this.cTextBox = new System.Windows.Forms.RichTextBox();
			this.oLabel2 = new System.Windows.Forms.Label();
			this.oLabel3 = new System.Windows.Forms.Label();
			this.oLabel5 = new System.Windows.Forms.Label();
			this.oLabel1 = new System.Windows.Forms.Label();
			this.oLabel4 = new System.Windows.Forms.Label();
			this.oLabel6 = new System.Windows.Forms.Label();
			this.oName = new System.Windows.Forms.TextBox();
			this.oQuantity = new System.Windows.Forms.TextBox();
			this.oDestination = new System.Windows.Forms.TextBox();
			this.oOrderButton = new System.Windows.Forms.Button();
			this.rOrderLabel = new System.Windows.Forms.Label();
			this.rComboBox = new System.Windows.Forms.ComboBox();
			this.rDetailsButton = new System.Windows.Forms.Button();
			this.rrOrderDetailsLabel = new System.Windows.Forms.Label();
			this.rrName = new System.Windows.Forms.Label();
			this.rrNameValue = new System.Windows.Forms.Label();
			this.rrJob = new System.Windows.Forms.Label();
			this.rrJobValue = new System.Windows.Forms.Label();
			this.rrQuantity = new System.Windows.Forms.Label();
			this.rrQuantityValue = new System.Windows.Forms.Label();
			this.rrOrigin = new System.Windows.Forms.Label();
			this.rrOriginValue = new System.Windows.Forms.Label();
			this.rrDestination = new System.Windows.Forms.Label();
			this.rrDestinationValue = new System.Windows.Forms.Label();
			this.rrVan = new System.Windows.Forms.Label();
			this.rrVanTypeValue = new System.Windows.Forms.Label();
			this.rrCarriers = new System.Windows.Forms.Label();
			this.rrCarriersValue = new System.Windows.Forms.Label();
			this.rrGenerateButton = new System.Windows.Forms.Button();
			this.oType = new System.Windows.Forms.ComboBox();
			this.oOrigin = new System.Windows.Forms.TextBox();
			this.oVanType = new System.Windows.Forms.ComboBox();
			this.pLabel = new System.Windows.Forms.Label();
			this.pPass = new System.Windows.Forms.TextBox();
			this.pLoginButton = new System.Windows.Forms.Button();
			this.rrtotal = new System.Windows.Forms.Label();
			this.rrCostValue = new System.Windows.Forms.Label();
			this.rrEarned = new System.Windows.Forms.Label();
			this.rrEarnedValue = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.initiateContractToolStripMenuItem,
            this.initiateOrderToolStripMenuItem,
            this.reviewCompletedOrdersToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 28);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// initiateContractToolStripMenuItem
			// 
			this.initiateContractToolStripMenuItem.Name = "initiateContractToolStripMenuItem";
			this.initiateContractToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
			this.initiateContractToolStripMenuItem.Text = "Contract Marketplace";
			this.initiateContractToolStripMenuItem.Click += new System.EventHandler(this.InitiateContractToolStripMenuItem_Click);
			// 
			// initiateOrderToolStripMenuItem
			// 
			this.initiateOrderToolStripMenuItem.Name = "initiateOrderToolStripMenuItem";
			this.initiateOrderToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
			this.initiateOrderToolStripMenuItem.Text = "Initiate Order";
			this.initiateOrderToolStripMenuItem.Click += new System.EventHandler(this.InitiateOrderToolStripMenuItem_Click);
			// 
			// reviewCompletedOrdersToolStripMenuItem
			// 
			this.reviewCompletedOrdersToolStripMenuItem.Name = "reviewCompletedOrdersToolStripMenuItem";
			this.reviewCompletedOrdersToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
			this.reviewCompletedOrdersToolStripMenuItem.Text = "Review Completed Orders";
			this.reviewCompletedOrdersToolStripMenuItem.Click += new System.EventHandler(this.ReviewCompletedOrdersToolStripMenuItem_Click);
			// 
			// cRefreshButton
			// 
			this.cRefreshButton.Location = new System.Drawing.Point(629, 409);
			this.cRefreshButton.Name = "cRefreshButton";
			this.cRefreshButton.Size = new System.Drawing.Size(159, 29);
			this.cRefreshButton.TabIndex = 1;
			this.cRefreshButton.Text = "Refresh Requests";
			this.cRefreshButton.UseVisualStyleBackColor = true;
			this.cRefreshButton.Click += new System.EventHandler(this.CRefreshButton_Click);
			// 
			// cTextBox
			// 
			this.cTextBox.Location = new System.Drawing.Point(12, 49);
			this.cTextBox.Name = "cTextBox";
			this.cTextBox.Size = new System.Drawing.Size(766, 354);
			this.cTextBox.TabIndex = 2;
			this.cTextBox.Text = "";
			// 
			// oLabel2
			// 
			this.oLabel2.AutoSize = true;
			this.oLabel2.Location = new System.Drawing.Point(406, 65);
			this.oLabel2.Name = "oLabel2";
			this.oLabel2.Size = new System.Drawing.Size(67, 20);
			this.oLabel2.TabIndex = 3;
			this.oLabel2.Text = "Job Type";
			// 
			// oLabel3
			// 
			this.oLabel3.AutoSize = true;
			this.oLabel3.Location = new System.Drawing.Point(28, 146);
			this.oLabel3.Name = "oLabel3";
			this.oLabel3.Size = new System.Drawing.Size(65, 20);
			this.oLabel3.TabIndex = 4;
			this.oLabel3.Text = "Quantity";
			// 
			// oLabel5
			// 
			this.oLabel5.AutoSize = true;
			this.oLabel5.Location = new System.Drawing.Point(25, 243);
			this.oLabel5.Name = "oLabel5";
			this.oLabel5.Size = new System.Drawing.Size(68, 20);
			this.oLabel5.TabIndex = 5;
			this.oLabel5.Text = "Van Type";
			// 
			// oLabel1
			// 
			this.oLabel1.AutoSize = true;
			this.oLabel1.Location = new System.Drawing.Point(25, 65);
			this.oLabel1.Name = "oLabel1";
			this.oLabel1.Size = new System.Drawing.Size(91, 20);
			this.oLabel1.TabIndex = 6;
			this.oLabel1.Text = "Client Name";
			// 
			// oLabel4
			// 
			this.oLabel4.AutoSize = true;
			this.oLabel4.Location = new System.Drawing.Point(406, 149);
			this.oLabel4.Name = "oLabel4";
			this.oLabel4.Size = new System.Drawing.Size(50, 20);
			this.oLabel4.TabIndex = 7;
			this.oLabel4.Text = "Origin";
			// 
			// oLabel6
			// 
			this.oLabel6.AutoSize = true;
			this.oLabel6.Location = new System.Drawing.Point(388, 236);
			this.oLabel6.Name = "oLabel6";
			this.oLabel6.Size = new System.Drawing.Size(85, 20);
			this.oLabel6.TabIndex = 8;
			this.oLabel6.Text = "Destination";
			// 
			// oName
			// 
			this.oName.Location = new System.Drawing.Point(142, 62);
			this.oName.Name = "oName";
			this.oName.Size = new System.Drawing.Size(125, 27);
			this.oName.TabIndex = 9;
			// 
			// oQuantity
			// 
			this.oQuantity.Location = new System.Drawing.Point(142, 146);
			this.oQuantity.Name = "oQuantity";
			this.oQuantity.Size = new System.Drawing.Size(125, 27);
			this.oQuantity.TabIndex = 11;
			// 
			// oDestination
			// 
			this.oDestination.Location = new System.Drawing.Point(502, 236);
			this.oDestination.Name = "oDestination";
			this.oDestination.Size = new System.Drawing.Size(125, 27);
			this.oDestination.TabIndex = 13;
			// 
			// oOrderButton
			// 
			this.oOrderButton.Location = new System.Drawing.Point(610, 389);
			this.oOrderButton.Name = "oOrderButton";
			this.oOrderButton.Size = new System.Drawing.Size(94, 29);
			this.oOrderButton.TabIndex = 15;
			this.oOrderButton.Text = "Place Order";
			this.oOrderButton.UseVisualStyleBackColor = true;
			this.oOrderButton.Click += new System.EventHandler(this.OOrderButton_Click);
			// 
			// rOrderLabel
			// 
			this.rOrderLabel.AutoSize = true;
			this.rOrderLabel.Location = new System.Drawing.Point(25, 65);
			this.rOrderLabel.Name = "rOrderLabel";
			this.rOrderLabel.Size = new System.Drawing.Size(53, 20);
			this.rOrderLabel.TabIndex = 16;
			this.rOrderLabel.Text = "Orders";
			// 
			// rComboBox
			// 
			this.rComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.rComboBox.FormattingEnabled = true;
			this.rComboBox.Location = new System.Drawing.Point(122, 65);
			this.rComboBox.Name = "rComboBox";
			this.rComboBox.Size = new System.Drawing.Size(151, 28);
			this.rComboBox.TabIndex = 17;
			// 
			// rDetailsButton
			// 
			this.rDetailsButton.Location = new System.Drawing.Point(306, 65);
			this.rDetailsButton.Name = "rDetailsButton";
			this.rDetailsButton.Size = new System.Drawing.Size(94, 29);
			this.rDetailsButton.TabIndex = 18;
			this.rDetailsButton.Text = "Details";
			this.rDetailsButton.UseVisualStyleBackColor = true;
			this.rDetailsButton.Click += new System.EventHandler(this.RDetailsButton_Click);
			// 
			// rrOrderDetailsLabel
			// 
			this.rrOrderDetailsLabel.AutoSize = true;
			this.rrOrderDetailsLabel.Location = new System.Drawing.Point(28, 126);
			this.rrOrderDetailsLabel.Name = "rrOrderDetailsLabel";
			this.rrOrderDetailsLabel.Size = new System.Drawing.Size(97, 20);
			this.rrOrderDetailsLabel.TabIndex = 19;
			this.rrOrderDetailsLabel.Text = "Order Details";
			// 
			// rrName
			// 
			this.rrName.AutoSize = true;
			this.rrName.Location = new System.Drawing.Point(28, 166);
			this.rrName.Name = "rrName";
			this.rrName.Size = new System.Drawing.Size(119, 20);
			this.rrName.TabIndex = 20;
			this.rrName.Text = "Customer Name:";
			// 
			// rrNameValue
			// 
			this.rrNameValue.AutoSize = true;
			this.rrNameValue.Location = new System.Drawing.Point(154, 166);
			this.rrNameValue.Name = "rrNameValue";
			this.rrNameValue.Size = new System.Drawing.Size(59, 20);
			this.rrNameValue.TabIndex = 21;
			this.rrNameValue.Text = "[Name]";
			// 
			// rrJob
			// 
			this.rrJob.AutoSize = true;
			this.rrJob.Location = new System.Drawing.Point(354, 166);
			this.rrJob.Name = "rrJob";
			this.rrJob.Size = new System.Drawing.Size(70, 20);
			this.rrJob.TabIndex = 22;
			this.rrJob.Text = "Job Type:";
			// 
			// rrJobValue
			// 
			this.rrJobValue.AutoSize = true;
			this.rrJobValue.Location = new System.Drawing.Point(437, 166);
			this.rrJobValue.Name = "rrJobValue";
			this.rrJobValue.Size = new System.Drawing.Size(42, 20);
			this.rrJobValue.TabIndex = 23;
			this.rrJobValue.Text = "[Job]";
			// 
			// rrQuantity
			// 
			this.rrQuantity.AutoSize = true;
			this.rrQuantity.Location = new System.Drawing.Point(28, 213);
			this.rrQuantity.Name = "rrQuantity";
			this.rrQuantity.Size = new System.Drawing.Size(72, 20);
			this.rrQuantity.TabIndex = 24;
			this.rrQuantity.Text = "Quantity :";
			// 
			// rrQuantityValue
			// 
			this.rrQuantityValue.AutoSize = true;
			this.rrQuantityValue.Location = new System.Drawing.Point(106, 213);
			this.rrQuantityValue.Name = "rrQuantityValue";
			this.rrQuantityValue.Size = new System.Drawing.Size(75, 20);
			this.rrQuantityValue.TabIndex = 25;
			this.rrQuantityValue.Text = "[Quantity]";
			// 
			// rrOrigin
			// 
			this.rrOrigin.AutoSize = true;
			this.rrOrigin.Location = new System.Drawing.Point(354, 213);
			this.rrOrigin.Name = "rrOrigin";
			this.rrOrigin.Size = new System.Drawing.Size(57, 20);
			this.rrOrigin.TabIndex = 26;
			this.rrOrigin.Text = "Origin :";
			this.rrOrigin.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// rrOriginValue
			// 
			this.rrOriginValue.AutoSize = true;
			this.rrOriginValue.Location = new System.Drawing.Point(417, 213);
			this.rrOriginValue.Name = "rrOriginValue";
			this.rrOriginValue.Size = new System.Drawing.Size(60, 20);
			this.rrOriginValue.TabIndex = 27;
			this.rrOriginValue.Text = "[Origin]";
			// 
			// rrDestination
			// 
			this.rrDestination.AutoSize = true;
			this.rrDestination.Location = new System.Drawing.Point(28, 275);
			this.rrDestination.Name = "rrDestination";
			this.rrDestination.Size = new System.Drawing.Size(92, 20);
			this.rrDestination.TabIndex = 28;
			this.rrDestination.Text = "Destination :";
			// 
			// rrDestinationValue
			// 
			this.rrDestinationValue.AutoSize = true;
			this.rrDestinationValue.Location = new System.Drawing.Point(126, 275);
			this.rrDestinationValue.Name = "rrDestinationValue";
			this.rrDestinationValue.Size = new System.Drawing.Size(95, 20);
			this.rrDestinationValue.TabIndex = 29;
			this.rrDestinationValue.Text = "[Destination]";
			// 
			// rrVan
			// 
			this.rrVan.AutoSize = true;
			this.rrVan.Location = new System.Drawing.Point(350, 275);
			this.rrVan.Name = "rrVan";
			this.rrVan.Size = new System.Drawing.Size(75, 20);
			this.rrVan.TabIndex = 30;
			this.rrVan.Text = "Van Type :";
			// 
			// rrVanTypeValue
			// 
			this.rrVanTypeValue.AutoSize = true;
			this.rrVanTypeValue.Location = new System.Drawing.Point(427, 275);
			this.rrVanTypeValue.Name = "rrVanTypeValue";
			this.rrVanTypeValue.Size = new System.Drawing.Size(78, 20);
			this.rrVanTypeValue.TabIndex = 31;
			this.rrVanTypeValue.Text = "[Van Type]";
			// 
			// rrCarriers
			// 
			this.rrCarriers.AutoSize = true;
			this.rrCarriers.Location = new System.Drawing.Point(28, 329);
			this.rrCarriers.Name = "rrCarriers";
			this.rrCarriers.Size = new System.Drawing.Size(127, 20);
			this.rrCarriers.TabIndex = 32;
			this.rrCarriers.Text = "Carriers Selected :";
			// 
			// rrCarriersValue
			// 
			this.rrCarriersValue.AutoSize = true;
			this.rrCarriersValue.Location = new System.Drawing.Point(161, 329);
			this.rrCarriersValue.Name = "rrCarriersValue";
			this.rrCarriersValue.Size = new System.Drawing.Size(69, 20);
			this.rrCarriersValue.TabIndex = 33;
			this.rrCarriersValue.Text = "[Carriers]";
			// 
			// rrGenerateButton
			// 
			this.rrGenerateButton.Location = new System.Drawing.Point(610, 389);
			this.rrGenerateButton.Name = "rrGenerateButton";
			this.rrGenerateButton.Size = new System.Drawing.Size(136, 29);
			this.rrGenerateButton.TabIndex = 34;
			this.rrGenerateButton.Text = "Generate Invoice";
			this.rrGenerateButton.UseVisualStyleBackColor = true;
			this.rrGenerateButton.Click += new System.EventHandler(this.RRGenerateButton_Click);
			// 
			// oType
			// 
			this.oType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.oType.FormattingEnabled = true;
			this.oType.Items.AddRange(new object[] {
            "0",
            "1"});
			this.oType.Location = new System.Drawing.Point(502, 65);
			this.oType.Name = "oType";
			this.oType.Size = new System.Drawing.Size(151, 28);
			this.oType.TabIndex = 35;
			// 
			// oOrigin
			// 
			this.oOrigin.Location = new System.Drawing.Point(502, 149);
			this.oOrigin.Name = "oOrigin";
			this.oOrigin.Size = new System.Drawing.Size(125, 27);
			this.oOrigin.TabIndex = 36;
			// 
			// oVanType
			// 
			this.oVanType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.oVanType.FormattingEnabled = true;
			this.oVanType.Items.AddRange(new object[] {
            "0",
            "1"});
			this.oVanType.Location = new System.Drawing.Point(126, 236);
			this.oVanType.Name = "oVanType";
			this.oVanType.Size = new System.Drawing.Size(151, 28);
			this.oVanType.TabIndex = 38;
			// 
			// pLabel
			// 
			this.pLabel.AutoSize = true;
			this.pLabel.Location = new System.Drawing.Point(312, 169);
			this.pLabel.Name = "pLabel";
			this.pLabel.Size = new System.Drawing.Size(161, 20);
			this.pLabel.TabIndex = 39;
			this.pLabel.Text = "Please Enter Password :";
			// 
			// pPass
			// 
			this.pPass.Location = new System.Drawing.Point(331, 210);
			this.pPass.Name = "pPass";
			this.pPass.PasswordChar = '*';
			this.pPass.Size = new System.Drawing.Size(125, 27);
			this.pPass.TabIndex = 40;
			// 
			// pLoginButton
			// 
			this.pLoginButton.Location = new System.Drawing.Point(350, 259);
			this.pLoginButton.Name = "pLoginButton";
			this.pLoginButton.Size = new System.Drawing.Size(94, 29);
			this.pLoginButton.TabIndex = 41;
			this.pLoginButton.Text = "Login";
			this.pLoginButton.UseVisualStyleBackColor = true;
			this.pLoginButton.Click += new System.EventHandler(this.pLoginButton_Click);
			// 
			// rrtotal
			// 
			this.rrtotal.AutoSize = true;
			this.rrtotal.Location = new System.Drawing.Point(350, 329);
			this.rrtotal.Name = "rrtotal";
			this.rrtotal.Size = new System.Drawing.Size(80, 20);
			this.rrtotal.TabIndex = 42;
			this.rrtotal.Text = "Total cost :";
			// 
			// rrCostValue
			// 
			this.rrCostValue.AutoSize = true;
			this.rrCostValue.Location = new System.Drawing.Point(455, 329);
			this.rrCostValue.Name = "rrCostValue";
			this.rrCostValue.Size = new System.Drawing.Size(50, 20);
			this.rrCostValue.TabIndex = 43;
			this.rrCostValue.Text = "label1";
			// 
			// rrEarned
			// 
			this.rrEarned.AutoSize = true;
			this.rrEarned.Location = new System.Drawing.Point(28, 372);
			this.rrEarned.Name = "rrEarned";
			this.rrEarned.Size = new System.Drawing.Size(62, 20);
			this.rrEarned.TabIndex = 44;
			this.rrEarned.Text = "Earned :";
			// 
			// rrEarnedValue
			// 
			this.rrEarnedValue.AutoSize = true;
			this.rrEarnedValue.Location = new System.Drawing.Point(96, 372);
			this.rrEarnedValue.Name = "rrEarnedValue";
			this.rrEarnedValue.Size = new System.Drawing.Size(42, 20);
			this.rrEarnedValue.TabIndex = 45;
			this.rrEarnedValue.Text = "label";
			// 
			// Buyer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.rrEarnedValue);
			this.Controls.Add(this.rrEarned);
			this.Controls.Add(this.rrCostValue);
			this.Controls.Add(this.rrtotal);
			this.Controls.Add(this.pLoginButton);
			this.Controls.Add(this.pPass);
			this.Controls.Add(this.pLabel);
			this.Controls.Add(this.oVanType);
			this.Controls.Add(this.oOrigin);
			this.Controls.Add(this.oType);
			this.Controls.Add(this.rrGenerateButton);
			this.Controls.Add(this.rrCarriersValue);
			this.Controls.Add(this.rrCarriers);
			this.Controls.Add(this.rrVanTypeValue);
			this.Controls.Add(this.rrVan);
			this.Controls.Add(this.rrDestinationValue);
			this.Controls.Add(this.rrDestination);
			this.Controls.Add(this.rrOriginValue);
			this.Controls.Add(this.rrOrigin);
			this.Controls.Add(this.rrQuantityValue);
			this.Controls.Add(this.rrQuantity);
			this.Controls.Add(this.rrJobValue);
			this.Controls.Add(this.rrJob);
			this.Controls.Add(this.rrNameValue);
			this.Controls.Add(this.rrName);
			this.Controls.Add(this.rrOrderDetailsLabel);
			this.Controls.Add(this.rDetailsButton);
			this.Controls.Add(this.rComboBox);
			this.Controls.Add(this.rOrderLabel);
			this.Controls.Add(this.oOrderButton);
			this.Controls.Add(this.oDestination);
			this.Controls.Add(this.oQuantity);
			this.Controls.Add(this.oName);
			this.Controls.Add(this.oLabel6);
			this.Controls.Add(this.oLabel4);
			this.Controls.Add(this.oLabel1);
			this.Controls.Add(this.oLabel5);
			this.Controls.Add(this.oLabel3);
			this.Controls.Add(this.oLabel2);
			this.Controls.Add(this.cTextBox);
			this.Controls.Add(this.cRefreshButton);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Buyer";
			this.Text = "Buyer";
			this.Load += new System.EventHandler(this.Buyer_StartingPage_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem initiateContractToolStripMenuItem;
		private ToolStripMenuItem initiateOrderToolStripMenuItem;
		private ToolStripMenuItem reviewCompletedOrdersToolStripMenuItem;
		private Button cRefreshButton;
		private RichTextBox cTextBox;
		private Label oLabel2;
		private Label oLabel3;
		private Label oLabel5;
		private Label oLabel1;
		private Label oLabel4;
		private Label oLabel6;
		private TextBox oName;
		private TextBox oQuantity;
		private TextBox oDestination;
		private Button oOrderButton;
		private Label rOrderLabel;
		private ComboBox rComboBox;
		private Button rDetailsButton;
		private Label rrOrderDetailsLabel;
		private Label rrName;
		private Label rrNameValue;
		private Label rrJob;
		private Label rrJobValue;
		private Label rrQuantity;
		private Label rrQuantityValue;
		private Label rrOrigin;
		private Label rrOriginValue;
		private Label rrDestination;
		private Label rrDestinationValue;
		private Label rrVan;
		private Label rrVanTypeValue;
		private Label rrCarriers;
		private Label rrCarriersValue;
		private Button rrGenerateButton;
		private ComboBox oType;
		private TextBox oOrigin;
		private ComboBox oVanType;
		private Label pLabel;
		private TextBox pPass;
		private Button pLoginButton;
		private Label rrtotal;
		private Label rrCostValue;
		private Label rrEarned;
		private Label rrEarnedValue;
	}
}