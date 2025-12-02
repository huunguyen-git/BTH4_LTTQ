namespace BTH4_NguyenHuuNguyen_24521189
{
    partial class frmBai05
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBai05));
            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            thêmMớiToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripBtnThemMoi = new ToolStripButton();
            toolStripLabelTimKiem = new ToolStripLabel();
            toolStripTxtTimKiem = new ToolStripTextBox();
            listViewDSSV = new ListView();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thêmMớiToolStripMenuItem, thoátToolStripMenuItem });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(113, 29);
            hệThốngToolStripMenuItem.Text = "Chức năng";
            // 
            // thêmMớiToolStripMenuItem
            // 
            thêmMớiToolStripMenuItem.Name = "thêmMớiToolStripMenuItem";
            thêmMớiToolStripMenuItem.Size = new Size(194, 34);
            thêmMớiToolStripMenuItem.Text = "Thêm mới";
            thêmMớiToolStripMenuItem.Click += toolStripBtnThemMoi_Click;
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(194, 34);
            thoátToolStripMenuItem.Text = "Thoát";
            thoátToolStripMenuItem.Click += thoátToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripBtnThemMoi, toolStripLabelTimKiem, toolStripTxtTimKiem });
            toolStrip1.Location = new Point(0, 33);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 50);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripBtnThemMoi
            // 
            toolStripBtnThemMoi.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStripBtnThemMoi.Image = (Image)resources.GetObject("toolStripBtnThemMoi.Image");
            toolStripBtnThemMoi.ImageScaling = ToolStripItemImageScaling.None;
            toolStripBtnThemMoi.ImageTransparentColor = Color.Magenta;
            toolStripBtnThemMoi.Name = "toolStripBtnThemMoi";
            toolStripBtnThemMoi.Size = new Size(179, 45);
            toolStripBtnThemMoi.Text = "Thêm mới";
            toolStripBtnThemMoi.Click += toolStripBtnThemMoi_Click;
            // 
            // toolStripLabelTimKiem
            // 
            toolStripLabelTimKiem.AutoSize = false;
            toolStripLabelTimKiem.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStripLabelTimKiem.Name = "toolStripLabelTimKiem";
            toolStripLabelTimKiem.Size = new Size(300, 45);
            toolStripLabelTimKiem.Text = "Tìm Kiếm Theo Tên";
            toolStripLabelTimKiem.TextAlign = ContentAlignment.MiddleRight;
            // 
            // toolStripTxtTimKiem
            // 
            toolStripTxtTimKiem.Name = "toolStripTxtTimKiem";
            toolStripTxtTimKiem.Size = new Size(270, 50);
            toolStripTxtTimKiem.TextChanged += toolStripTxtTimKiem_TextChanged;
            // 
            // listViewDSSV
            // 
            listViewDSSV.Columns.AddRange(new ColumnHeader[] { columnHeader2, columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader11 });
            listViewDSSV.Dock = DockStyle.Fill;
            listViewDSSV.GridLines = true;
            listViewDSSV.Location = new Point(0, 83);
            listViewDSSV.Name = "listViewDSSV";
            listViewDSSV.Size = new Size(800, 474);
            listViewDSSV.TabIndex = 2;
            listViewDSSV.UseCompatibleStateImageBehavior = false;
            listViewDSSV.View = View.Details;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Số TT";
            columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Mã Số SV";
            columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Tên Sinh Viên";
            columnHeader9.Width = 250;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Khoa";
            columnHeader10.Width = 200;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Điểm TB";
            columnHeader11.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "";
            // 
            // frmBai05
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 557);
            Controls.Add(listViewDSSV);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmBai05";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý sinh viên";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem thêmMớiToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripBtnThemMoi;
        private ToolStripLabel toolStripLabelTimKiem;
        public ToolStripTextBox toolStripTxtTimKiem;
        public ListView listViewDSSV;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader2;
    }
}