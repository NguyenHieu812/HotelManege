namespace Ql_KhachSan
{
    partial class ManageHotel
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
            this.hOMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dịchVụToolStripMenuItem = new System.Windows.Forms.ToolStripComboBox();
            this.phiếuĐặtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loạiPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuThuêToolStripMenuItem = new System.Windows.Forms.ToolStripComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hOMEToolStripMenuItem,
            this.kháchHàngToolStripMenuItem,
            this.dịchVụToolStripMenuItem,
            this.phiếuĐặtToolStripMenuItem,
            this.nhânViênToolStripMenuItem,
            this.loạiPhòngToolStripMenuItem,
            this.listPhòngToolStripMenuItem,
            this.phiếuThuêToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(115, 164);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // hOMEToolStripMenuItem
            // 
            this.hOMEToolStripMenuItem.Name = "hOMEToolStripMenuItem";
            this.hOMEToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.hOMEToolStripMenuItem.Size = new System.Drawing.Size(111, 19);
            this.hOMEToolStripMenuItem.Text = "HOME";
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(111, 19);
            this.kháchHàngToolStripMenuItem.Text = "Khách Hàng";
            // 
            // dịchVụToolStripMenuItem
            // 
            this.dịchVụToolStripMenuItem.Items.AddRange(new object[] {
            "Phiếu sử dụng dịch vụ",
            "Chi tiết sử dụng dịch vụ"});
            this.dịchVụToolStripMenuItem.Name = "dịchVụToolStripMenuItem";
            this.dịchVụToolStripMenuItem.Size = new System.Drawing.Size(114, 23);
            this.dịchVụToolStripMenuItem.Text = "Dịch vụ ";
            this.dịchVụToolStripMenuItem.Click += new System.EventHandler(this.dịchVụToolStripMenuItem_Click);
            // 
            // phiếuĐặtToolStripMenuItem
            // 
            this.phiếuĐặtToolStripMenuItem.Name = "phiếuĐặtToolStripMenuItem";
            this.phiếuĐặtToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.phiếuĐặtToolStripMenuItem.Size = new System.Drawing.Size(111, 19);
            this.phiếuĐặtToolStripMenuItem.Text = "Phiếu Đặt";
            this.phiếuĐặtToolStripMenuItem.Click += new System.EventHandler(this.phiếuĐặtToolStripMenuItem_Click);
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(116, 19);
            this.nhânViênToolStripMenuItem.Text = "Nhân Viên";
            // 
            // loạiPhòngToolStripMenuItem
            // 
            this.loạiPhòngToolStripMenuItem.Name = "loạiPhòngToolStripMenuItem";
            this.loạiPhòngToolStripMenuItem.Size = new System.Drawing.Size(116, 19);
            this.loạiPhòngToolStripMenuItem.Text = "Loại Phòng";
            // 
            // listPhòngToolStripMenuItem
            // 
            this.listPhòngToolStripMenuItem.Name = "listPhòngToolStripMenuItem";
            this.listPhòngToolStripMenuItem.Size = new System.Drawing.Size(116, 19);
            this.listPhòngToolStripMenuItem.Text = "List Phòng";
            // 
            // phiếuThuêToolStripMenuItem
            // 
            this.phiếuThuêToolStripMenuItem.Items.AddRange(new object[] {
            "Chi tiết phiếu thuê"});
            this.phiếuThuêToolStripMenuItem.Name = "phiếuThuêToolStripMenuItem";
            this.phiếuThuêToolStripMenuItem.Size = new System.Drawing.Size(114, 23);
            this.phiếuThuêToolStripMenuItem.Text = "Phiếu Thuê";
            // 
            // ManageHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 400);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "ManageHotel";
            this.Text = "ManageHotel";
            this.Load += new System.EventHandler(this.ManageHotel_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hOMEToolStripMenuItem;
        private ToolStripMenuItem kháchHàngToolStripMenuItem;
        private ToolStripMenuItem phiếuĐặtToolStripMenuItem;
        private ToolStripMenuItem nhânViênToolStripMenuItem;
        private ToolStripMenuItem loạiPhòngToolStripMenuItem;
        private ToolStripMenuItem listPhòngToolStripMenuItem;
        private ToolStripComboBox dịchVụToolStripMenuItem;
        private ToolStripComboBox phiếuThuêToolStripMenuItem;
    }
}