namespace TMS
{

	

	partial class TMS
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
			this.label1 = new System.Windows.Forms.Label();
			this.UserType = new System.Windows.Forms.ComboBox();
			this.Submit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(283, 160);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(166, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Please Select User Type:";
			// 
			// UserType
			// 
			this.UserType.DisplayMember = "(none)";
			this.UserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.UserType.FormattingEnabled = true;
			this.UserType.Items.AddRange(new object[] {
            "Admin",
            "Buyer",
            "Planner"});
			this.UserType.Location = new System.Drawing.Point(298, 200);
			this.UserType.Name = "UserType";
			this.UserType.Size = new System.Drawing.Size(151, 28);
			this.UserType.TabIndex = 1;
			// 
			// Submit
			// 
			this.Submit.Location = new System.Drawing.Point(323, 257);
			this.Submit.Name = "Submit";
			this.Submit.Size = new System.Drawing.Size(94, 29);
			this.Submit.TabIndex = 2;
			this.Submit.Text = "Submit";
			this.Submit.UseVisualStyleBackColor = true;
			this.Submit.Click += new System.EventHandler(this.Submit_Click);
			// 
			// TMS_StartingPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.Submit);
			this.Controls.Add(this.UserType);
			this.Controls.Add(this.label1);
			this.Name = "TMS_StartingPage";
			this.Text = "TMS";
			this.Load += new System.EventHandler(this.TMS_StartingPage_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label label1;
		private ComboBox UserType;
		private Button Submit;
	}
}