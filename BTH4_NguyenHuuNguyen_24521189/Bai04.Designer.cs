namespace BTH4_NguyenHuuNguyen_24521189
{
    partial class frmBai04
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBai04));
            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            tạoVănBảnMớiToolStripMenuItem = new ToolStripMenuItem();
            mởTậpTinToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            lưuNộiDungVănBảnToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            địnhDạngToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripBtnNewPage = new ToolStripButton();
            toolStripBtnOpen = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripComboBoxFont = new ToolStripComboBox();
            toolStripComboFontSize = new ToolStripComboBox();
            toolStripBtnBold = new ToolStripButton();
            toolStripBtnItalic = new ToolStripButton();
            toolStripBtnUnderline = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripProgressBar1 = new ToolStripProgressBar();
            richTxtWritingArea = new RichTextBox();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.SkyBlue;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, địnhDạngToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tạoVănBảnMớiToolStripMenuItem, mởTậpTinToolStripMenuItem, toolStripMenuItem1, lưuNộiDungVănBảnToolStripMenuItem, thoátToolStripMenuItem });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(103, 29);
            hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // tạoVănBảnMớiToolStripMenuItem
            // 
            tạoVănBảnMớiToolStripMenuItem.Image = Properties.Resources.blank_page;
            tạoVănBảnMớiToolStripMenuItem.Name = "tạoVănBảnMớiToolStripMenuItem";
            tạoVănBảnMớiToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            tạoVănBảnMớiToolStripMenuItem.Size = new Size(349, 34);
            tạoVănBảnMớiToolStripMenuItem.Text = "Tạo văn bản mới";
            tạoVănBảnMớiToolStripMenuItem.Click += NewPage_Click;
            // 
            // mởTậpTinToolStripMenuItem
            // 
            mởTậpTinToolStripMenuItem.Image = Properties.Resources.open_folder;
            mởTậpTinToolStripMenuItem.Name = "mởTậpTinToolStripMenuItem";
            mởTậpTinToolStripMenuItem.Size = new Size(349, 34);
            mởTậpTinToolStripMenuItem.Text = "Mở tập tin";
            mởTậpTinToolStripMenuItem.Click += OpenFile_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(346, 6);
            // 
            // lưuNộiDungVănBảnToolStripMenuItem
            // 
            lưuNộiDungVănBảnToolStripMenuItem.Image = Properties.Resources.save;
            lưuNộiDungVănBảnToolStripMenuItem.Name = "lưuNộiDungVănBảnToolStripMenuItem";
            lưuNộiDungVănBảnToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            lưuNộiDungVănBảnToolStripMenuItem.Size = new Size(349, 34);
            lưuNộiDungVănBảnToolStripMenuItem.Text = "Lưu nội dung văn bản";
            lưuNộiDungVănBảnToolStripMenuItem.Click += SaveFile_Click;
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(349, 34);
            thoátToolStripMenuItem.Text = "Thoát";
            // 
            // địnhDạngToolStripMenuItem
            // 
            địnhDạngToolStripMenuItem.Name = "địnhDạngToolStripMenuItem";
            địnhDạngToolStripMenuItem.Size = new Size(111, 29);
            địnhDạngToolStripMenuItem.Text = "Định dạng";
            địnhDạngToolStripMenuItem.Click += EditWithFontDialog;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.SkyBlue;
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripBtnNewPage, toolStripBtnOpen, toolStripSeparator1, toolStripComboBoxFont, toolStripComboFontSize, toolStripBtnBold, toolStripBtnItalic, toolStripBtnUnderline, toolStripSeparator2, toolStripProgressBar1 });
            toolStrip1.Location = new Point(0, 33);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 33);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripBtnNewPage
            // 
            toolStripBtnNewPage.BackColor = Color.White;
            toolStripBtnNewPage.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripBtnNewPage.Image = (Image)resources.GetObject("toolStripBtnNewPage.Image");
            toolStripBtnNewPage.ImageTransparentColor = Color.Magenta;
            toolStripBtnNewPage.Name = "toolStripBtnNewPage";
            toolStripBtnNewPage.Size = new Size(34, 28);
            toolStripBtnNewPage.Text = "toolStripButton1";
            toolStripBtnNewPage.ToolTipText = "New";
            toolStripBtnNewPage.Click += NewPage_Click;
            // 
            // toolStripBtnOpen
            // 
            toolStripBtnOpen.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripBtnOpen.Image = (Image)resources.GetObject("toolStripBtnOpen.Image");
            toolStripBtnOpen.ImageTransparentColor = Color.Magenta;
            toolStripBtnOpen.Name = "toolStripBtnOpen";
            toolStripBtnOpen.Size = new Size(34, 28);
            toolStripBtnOpen.Text = "toolStripButton2";
            toolStripBtnOpen.ToolTipText = "Save";
            toolStripBtnOpen.Click += SaveFile_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 33);
            // 
            // toolStripComboBoxFont
            // 
            toolStripComboBoxFont.Name = "toolStripComboBoxFont";
            toolStripComboBoxFont.Size = new Size(200, 33);
            toolStripComboBoxFont.SelectedIndexChanged += ApplyNewFont;
            // 
            // toolStripComboFontSize
            // 
            toolStripComboFontSize.Items.AddRange(new object[] { "8", "9", "10", "11", "12", "14", "16", "18", "20", "22", "24", "26", "28", "36", "48", "72" });
            toolStripComboFontSize.Name = "toolStripComboFontSize";
            toolStripComboFontSize.Size = new Size(100, 33);
            toolStripComboFontSize.SelectedIndexChanged += ApplyNewFont;
            // 
            // toolStripBtnBold
            // 
            toolStripBtnBold.BackColor = SystemColors.ActiveBorder;
            toolStripBtnBold.CheckOnClick = true;
            toolStripBtnBold.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripBtnBold.Image = (Image)resources.GetObject("toolStripBtnBold.Image");
            toolStripBtnBold.ImageTransparentColor = Color.Magenta;
            toolStripBtnBold.Name = "toolStripBtnBold";
            toolStripBtnBold.Size = new Size(34, 28);
            toolStripBtnBold.Text = "toolStripButton3";
            toolStripBtnBold.ToolTipText = "Bold";
            toolStripBtnBold.Click += toolStripBtnBold_Click;
            // 
            // toolStripBtnItalic
            // 
            toolStripBtnItalic.BackColor = SystemColors.ActiveBorder;
            toolStripBtnItalic.CheckOnClick = true;
            toolStripBtnItalic.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripBtnItalic.Image = (Image)resources.GetObject("toolStripBtnItalic.Image");
            toolStripBtnItalic.ImageTransparentColor = Color.Magenta;
            toolStripBtnItalic.Name = "toolStripBtnItalic";
            toolStripBtnItalic.Size = new Size(34, 28);
            toolStripBtnItalic.Text = "toolStripButton4";
            toolStripBtnItalic.ToolTipText = "Italic";
            toolStripBtnItalic.Click += toolStripBtnItalic_Click;
            // 
            // toolStripBtnUnderline
            // 
            toolStripBtnUnderline.BackColor = SystemColors.ActiveBorder;
            toolStripBtnUnderline.CheckOnClick = true;
            toolStripBtnUnderline.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripBtnUnderline.Image = (Image)resources.GetObject("toolStripBtnUnderline.Image");
            toolStripBtnUnderline.ImageTransparentColor = Color.Magenta;
            toolStripBtnUnderline.Name = "toolStripBtnUnderline";
            toolStripBtnUnderline.Size = new Size(34, 28);
            toolStripBtnUnderline.Text = "toolStripButton5";
            toolStripBtnUnderline.ToolTipText = "Underline";
            toolStripBtnUnderline.Click += toolStripBtnUnderline_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 33);
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.BackColor = SystemColors.GradientActiveCaption;
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(250, 28);
            // 
            // richTxtWritingArea
            // 
            richTxtWritingArea.BorderStyle = BorderStyle.None;
            richTxtWritingArea.Dock = DockStyle.Fill;
            richTxtWritingArea.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTxtWritingArea.Location = new Point(0, 66);
            richTxtWritingArea.Name = "richTxtWritingArea";
            richTxtWritingArea.Size = new Size(800, 384);
            richTxtWritingArea.TabIndex = 2;
            richTxtWritingArea.Text = "";
            richTxtWritingArea.SelectionChanged += richTxtWritingArea_SelectionChanged;
            // 
            // frmBai04
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTxtWritingArea);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmBai04";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bai04";
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
        private ToolStripMenuItem địnhDạngToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripBtnNewPage;
        private ToolStripButton toolStripBtnOpen;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripComboBox toolStripComboBoxFont;
        private ToolStripComboBox toolStripComboFontSize;
        private ToolStripButton toolStripBtnBold;
        private ToolStripButton toolStripBtnItalic;
        private ToolStripButton toolStripBtnUnderline;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripProgressBar toolStripProgressBar1;
        private ToolStripMenuItem tạoVănBảnMớiToolStripMenuItem;
        private ToolStripMenuItem mởTậpTinToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem lưuNộiDungVănBảnToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private RichTextBox richTxtWritingArea;
    }
}