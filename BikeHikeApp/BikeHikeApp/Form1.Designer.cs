namespace BikeHikeApp
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
      this.lstCustomers = new System.Windows.Forms.ListBox();
      this.cmdLoadCustomers = new System.Windows.Forms.Button();
      this.txtCID = new System.Windows.Forms.TextBox();
      this.txtEmail = new System.Windows.Forms.TextBox();
      this.txtCustomerOnRental = new System.Windows.Forms.TextBox();
      this.txtDescription = new System.Windows.Forms.TextBox();
      this.txtYear = new System.Windows.Forms.TextBox();
      this.cmdLoadBikes = new System.Windows.Forms.Button();
      this.lstBikes = new System.Windows.Forms.ListBox();
      this.txtPricePerHour = new System.Windows.Forms.TextBox();
      this.cmdForRent = new System.Windows.Forms.Button();
      this.lstForRent = new System.Windows.Forms.CheckedListBox();
      this.cmdRental = new System.Windows.Forms.Button();
      this.txtBikeOnRental = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.txtDuration = new System.Windows.Forms.TextBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.cmdReturn = new System.Windows.Forms.Button();
      this.txtCustRentalInfo1 = new System.Windows.Forms.TextBox();
      this.txtCustRentalInfo2 = new System.Windows.Forms.TextBox();
      this.txtBikeRentalInfo = new System.Windows.Forms.TextBox();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.resetDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // lstCustomers
      // 
      this.lstCustomers.FormattingEnabled = true;
      this.lstCustomers.ItemHeight = 32;
      this.lstCustomers.Location = new System.Drawing.Point(12, 105);
      this.lstCustomers.Name = "lstCustomers";
      this.lstCustomers.Size = new System.Drawing.Size(289, 356);
      this.lstCustomers.TabIndex = 0;
      this.lstCustomers.SelectedIndexChanged += new System.EventHandler(this.lstCustomers_SelectedIndexChanged);
      // 
      // cmdLoadCustomers
      // 
      this.cmdLoadCustomers.Location = new System.Drawing.Point(53, 47);
      this.cmdLoadCustomers.Name = "cmdLoadCustomers";
      this.cmdLoadCustomers.Size = new System.Drawing.Size(200, 46);
      this.cmdLoadCustomers.TabIndex = 1;
      this.cmdLoadCustomers.Text = "Load Customers";
      this.cmdLoadCustomers.UseVisualStyleBackColor = true;
      this.cmdLoadCustomers.Click += new System.EventHandler(this.cmdLoadCustomers_Click);
      // 
      // txtCID
      // 
      this.txtCID.Location = new System.Drawing.Point(37, 501);
      this.txtCID.Name = "txtCID";
      this.txtCID.ReadOnly = true;
      this.txtCID.Size = new System.Drawing.Size(238, 39);
      this.txtCID.TabIndex = 2;
      // 
      // txtEmail
      // 
      this.txtEmail.Location = new System.Drawing.Point(37, 537);
      this.txtEmail.Name = "txtEmail";
      this.txtEmail.ReadOnly = true;
      this.txtEmail.Size = new System.Drawing.Size(238, 39);
      this.txtEmail.TabIndex = 3;
      // 
      // txtCustomerOnRental
      // 
      this.txtCustomerOnRental.Location = new System.Drawing.Point(37, 573);
      this.txtCustomerOnRental.Name = "txtCustomerOnRental";
      this.txtCustomerOnRental.ReadOnly = true;
      this.txtCustomerOnRental.Size = new System.Drawing.Size(238, 39);
      this.txtCustomerOnRental.TabIndex = 4;
      // 
      // txtDescription
      // 
      this.txtDescription.Location = new System.Drawing.Point(801, 537);
      this.txtDescription.Name = "txtDescription";
      this.txtDescription.ReadOnly = true;
      this.txtDescription.Size = new System.Drawing.Size(238, 39);
      this.txtDescription.TabIndex = 9;
      // 
      // txtYear
      // 
      this.txtYear.Location = new System.Drawing.Point(801, 501);
      this.txtYear.Name = "txtYear";
      this.txtYear.ReadOnly = true;
      this.txtYear.Size = new System.Drawing.Size(238, 39);
      this.txtYear.TabIndex = 8;
      // 
      // cmdLoadBikes
      // 
      this.cmdLoadBikes.Location = new System.Drawing.Point(817, 47);
      this.cmdLoadBikes.Name = "cmdLoadBikes";
      this.cmdLoadBikes.Size = new System.Drawing.Size(200, 46);
      this.cmdLoadBikes.TabIndex = 6;
      this.cmdLoadBikes.Text = "All Bikes";
      this.cmdLoadBikes.UseVisualStyleBackColor = true;
      this.cmdLoadBikes.Click += new System.EventHandler(this.cmdLoadBikes_Click);
      // 
      // lstBikes
      // 
      this.lstBikes.FormattingEnabled = true;
      this.lstBikes.ItemHeight = 32;
      this.lstBikes.Location = new System.Drawing.Point(776, 105);
      this.lstBikes.Name = "lstBikes";
      this.lstBikes.Size = new System.Drawing.Size(289, 356);
      this.lstBikes.TabIndex = 5;
      this.lstBikes.SelectedIndexChanged += new System.EventHandler(this.lstBikes_SelectedIndexChanged);
      // 
      // txtPricePerHour
      // 
      this.txtPricePerHour.Location = new System.Drawing.Point(801, 573);
      this.txtPricePerHour.Name = "txtPricePerHour";
      this.txtPricePerHour.ReadOnly = true;
      this.txtPricePerHour.Size = new System.Drawing.Size(238, 39);
      this.txtPricePerHour.TabIndex = 10;
      // 
      // cmdForRent
      // 
      this.cmdForRent.Location = new System.Drawing.Point(431, 47);
      this.cmdForRent.Name = "cmdForRent";
      this.cmdForRent.Size = new System.Drawing.Size(200, 46);
      this.cmdForRent.TabIndex = 12;
      this.cmdForRent.Text = "Bikes For Rent";
      this.cmdForRent.UseVisualStyleBackColor = true;
      this.cmdForRent.Click += new System.EventHandler(this.cmdForRent_Click);
      // 
      // lstForRent
      // 
      this.lstForRent.FormattingEnabled = true;
      this.lstForRent.Location = new System.Drawing.Point(383, 105);
      this.lstForRent.Name = "lstForRent";
      this.lstForRent.Size = new System.Drawing.Size(308, 310);
      this.lstForRent.TabIndex = 13;
      // 
      // cmdRental
      // 
      this.cmdRental.Location = new System.Drawing.Point(47, 73);
      this.cmdRental.Name = "cmdRental";
      this.cmdRental.Size = new System.Drawing.Size(200, 46);
      this.cmdRental.TabIndex = 14;
      this.cmdRental.Text = "Rent Bikes...";
      this.cmdRental.UseVisualStyleBackColor = true;
      this.cmdRental.Click += new System.EventHandler(this.cmdRental_Click);
      // 
      // txtBikeOnRental
      // 
      this.txtBikeOnRental.Location = new System.Drawing.Point(801, 611);
      this.txtBikeOnRental.Name = "txtBikeOnRental";
      this.txtBikeOnRental.ReadOnly = true;
      this.txtBikeOnRental.Size = new System.Drawing.Size(238, 39);
      this.txtBikeOnRental.TabIndex = 15;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(99, 19);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(183, 32);
      this.label1.TabIndex = 16;
      this.label1.Text = "duration (hrs)";
      // 
      // txtDuration
      // 
      this.txtDuration.Location = new System.Drawing.Point(23, 16);
      this.txtDuration.Name = "txtDuration";
      this.txtDuration.Size = new System.Drawing.Size(70, 39);
      this.txtDuration.TabIndex = 17;
      this.txtDuration.Text = "1.0";
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.White;
      this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel1.Controls.Add(this.cmdRental);
      this.panel1.Controls.Add(this.txtDuration);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Location = new System.Drawing.Point(383, 445);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(308, 144);
      this.panel1.TabIndex = 18;
      // 
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.Color.White;
      this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel2.Controls.Add(this.cmdReturn);
      this.panel2.Location = new System.Drawing.Point(383, 606);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(308, 79);
      this.panel2.TabIndex = 19;
      // 
      // cmdReturn
      // 
      this.cmdReturn.Location = new System.Drawing.Point(47, 17);
      this.cmdReturn.Name = "cmdReturn";
      this.cmdReturn.Size = new System.Drawing.Size(200, 46);
      this.cmdReturn.TabIndex = 15;
      this.cmdReturn.Text = "Return...";
      this.cmdReturn.UseVisualStyleBackColor = true;
      this.cmdReturn.Click += new System.EventHandler(this.cmdReturn_Click);
      // 
      // txtCustRentalInfo1
      // 
      this.txtCustRentalInfo1.Location = new System.Drawing.Point(53, 611);
      this.txtCustRentalInfo1.Name = "txtCustRentalInfo1";
      this.txtCustRentalInfo1.ReadOnly = true;
      this.txtCustRentalInfo1.Size = new System.Drawing.Size(222, 39);
      this.txtCustRentalInfo1.TabIndex = 20;
      // 
      // txtCustRentalInfo2
      // 
      this.txtCustRentalInfo2.Location = new System.Drawing.Point(53, 649);
      this.txtCustRentalInfo2.Name = "txtCustRentalInfo2";
      this.txtCustRentalInfo2.ReadOnly = true;
      this.txtCustRentalInfo2.Size = new System.Drawing.Size(222, 39);
      this.txtCustRentalInfo2.TabIndex = 21;
      // 
      // txtBikeRentalInfo
      // 
      this.txtBikeRentalInfo.Location = new System.Drawing.Point(817, 649);
      this.txtBikeRentalInfo.Name = "txtBikeRentalInfo";
      this.txtBikeRentalInfo.ReadOnly = true;
      this.txtBikeRentalInfo.Size = new System.Drawing.Size(222, 39);
      this.txtBikeRentalInfo.TabIndex = 22;
      // 
      // menuStrip1
      // 
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1088, 38);
      this.menuStrip1.TabIndex = 23;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetDatabaseToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(56, 34);
      this.fileToolStripMenuItem.Text = "&File";
      // 
      // resetDatabaseToolStripMenuItem
      // 
      this.resetDatabaseToolStripMenuItem.Name = "resetDatabaseToolStripMenuItem";
      this.resetDatabaseToolStripMenuItem.Size = new System.Drawing.Size(288, 34);
      this.resetDatabaseToolStripMenuItem.Text = "Reset database";
      this.resetDatabaseToolStripMenuItem.Click += new System.EventHandler(this.resetDatabaseToolStripMenuItem_Click);
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(285, 6);
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(288, 34);
      this.exitToolStripMenuItem.Text = "E&xit";
      this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Yellow;
      this.ClientSize = new System.Drawing.Size(1088, 702);
      this.Controls.Add(this.txtBikeRentalInfo);
      this.Controls.Add(this.txtCustRentalInfo2);
      this.Controls.Add(this.txtCustRentalInfo1);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.txtBikeOnRental);
      this.Controls.Add(this.lstForRent);
      this.Controls.Add(this.cmdForRent);
      this.Controls.Add(this.txtPricePerHour);
      this.Controls.Add(this.txtDescription);
      this.Controls.Add(this.txtYear);
      this.Controls.Add(this.cmdLoadBikes);
      this.Controls.Add(this.lstBikes);
      this.Controls.Add(this.txtCustomerOnRental);
      this.Controls.Add(this.txtEmail);
      this.Controls.Add(this.txtCID);
      this.Controls.Add(this.cmdLoadCustomers);
      this.Controls.Add(this.lstCustomers);
      this.Controls.Add(this.menuStrip1);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
      this.MainMenuStrip = this.menuStrip1;
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "BikeHike App";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListBox lstCustomers;
    private System.Windows.Forms.Button cmdLoadCustomers;
    private System.Windows.Forms.TextBox txtCID;
    private System.Windows.Forms.TextBox txtEmail;
    private System.Windows.Forms.TextBox txtCustomerOnRental;
    private System.Windows.Forms.TextBox txtDescription;
    private System.Windows.Forms.TextBox txtYear;
    private System.Windows.Forms.Button cmdLoadBikes;
    private System.Windows.Forms.ListBox lstBikes;
    private System.Windows.Forms.TextBox txtPricePerHour;
    private System.Windows.Forms.Button cmdForRent;
    private System.Windows.Forms.CheckedListBox lstForRent;
    private System.Windows.Forms.Button cmdRental;
    private System.Windows.Forms.TextBox txtBikeOnRental;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtDuration;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Button cmdReturn;
    private System.Windows.Forms.TextBox txtCustRentalInfo1;
    private System.Windows.Forms.TextBox txtCustRentalInfo2;
    private System.Windows.Forms.TextBox txtBikeRentalInfo;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem resetDatabaseToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
  }
}

