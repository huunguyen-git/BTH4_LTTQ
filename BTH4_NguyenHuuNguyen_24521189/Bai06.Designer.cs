namespace BTH4_NguyenHuuNguyen_24521189
{
    partial class frmBai06
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
            components = new System.ComponentModel.Container();
            grpSaoChep = new GroupBox();
            btnSaoChep = new Button();
            btnDich = new Button();
            btnNguon = new Button();
            txtDich = new TextBox();
            txtNguon = new TextBox();
            lblDich = new Label();
            lblNguon = new Label();
            grpTienTrinh = new GroupBox();
            progressBar1 = new ProgressBar();
            toolTip1 = new ToolTip(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            lblTrangThai = new Label();
            grpSaoChep.SuspendLayout();
            grpTienTrinh.SuspendLayout();
            SuspendLayout();
            // 
            // grpSaoChep
            // 
            grpSaoChep.Controls.Add(btnSaoChep);
            grpSaoChep.Controls.Add(btnDich);
            grpSaoChep.Controls.Add(btnNguon);
            grpSaoChep.Controls.Add(txtDich);
            grpSaoChep.Controls.Add(txtNguon);
            grpSaoChep.Controls.Add(lblDich);
            grpSaoChep.Controls.Add(lblNguon);
            grpSaoChep.ForeColor = Color.Blue;
            grpSaoChep.Location = new Point(37, 22);
            grpSaoChep.Name = "grpSaoChep";
            grpSaoChep.Size = new Size(917, 215);
            grpSaoChep.TabIndex = 0;
            grpSaoChep.TabStop = false;
            grpSaoChep.Text = "Sao chép tập tin";
            // 
            // btnSaoChep
            // 
            btnSaoChep.BackColor = SystemColors.ControlLight;
            btnSaoChep.FlatStyle = FlatStyle.Flat;
            btnSaoChep.ForeColor = Color.Black;
            btnSaoChep.Location = new Point(352, 164);
            btnSaoChep.Name = "btnSaoChep";
            btnSaoChep.Size = new Size(200, 34);
            btnSaoChep.TabIndex = 8;
            btnSaoChep.Text = "Sao Chép";
            toolTip1.SetToolTip(btnSaoChep, "Tiến hành sao chép");
            btnSaoChep.UseVisualStyleBackColor = false;
            btnSaoChep.Click += btnSaoChep_Click;
            // 
            // btnDich
            // 
            btnDich.BackColor = SystemColors.ActiveBorder;
            btnDich.FlatStyle = FlatStyle.Flat;
            btnDich.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDich.ForeColor = Color.Blue;
            btnDich.Location = new Point(801, 115);
            btnDich.Name = "btnDich";
            btnDich.Size = new Size(33, 28);
            btnDich.TabIndex = 7;
            btnDich.Text = "...";
            toolTip1.SetToolTip(btnDich, "Chọn đường dẫn đích");
            btnDich.UseVisualStyleBackColor = false;
            btnDich.Click += btnDich_Click;
            // 
            // btnNguon
            // 
            btnNguon.BackColor = SystemColors.ActiveBorder;
            btnNguon.FlatStyle = FlatStyle.Flat;
            btnNguon.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNguon.ForeColor = Color.Blue;
            btnNguon.Location = new Point(801, 54);
            btnNguon.Name = "btnNguon";
            btnNguon.Size = new Size(33, 28);
            btnNguon.TabIndex = 6;
            btnNguon.Text = "...";
            toolTip1.SetToolTip(btnNguon, "Chọn đường dẫn nguồn");
            btnNguon.UseVisualStyleBackColor = false;
            btnNguon.Click += btnNguon_Click;
            // 
            // txtDich
            // 
            txtDich.BorderStyle = BorderStyle.FixedSingle;
            txtDich.Location = new Point(332, 109);
            txtDich.Name = "txtDich";
            txtDich.Size = new Size(441, 31);
            txtDich.TabIndex = 5;
            toolTip1.SetToolTip(txtDich, "Nhập đường dẫn đích");
            // 
            // txtNguon
            // 
            txtNguon.BackColor = SystemColors.Window;
            txtNguon.BorderStyle = BorderStyle.FixedSingle;
            txtNguon.Location = new Point(332, 51);
            txtNguon.Name = "txtNguon";
            txtNguon.Size = new Size(441, 31);
            txtNguon.TabIndex = 4;
            toolTip1.SetToolTip(txtNguon, "Nhập đường dẫn nguồn");
            // 
            // lblDich
            // 
            lblDich.AutoSize = true;
            lblDich.ForeColor = Color.Black;
            lblDich.Location = new Point(57, 115);
            lblDich.Name = "lblDich";
            lblDich.Size = new Size(219, 25);
            lblDich.TabIndex = 3;
            lblDich.Text = "Đường Dẫn Thư Mục Đích";
            // 
            // lblNguon
            // 
            lblNguon.AutoSize = true;
            lblNguon.ForeColor = Color.Black;
            lblNguon.Location = new Point(57, 54);
            lblNguon.Name = "lblNguon";
            lblNguon.Size = new Size(239, 25);
            lblNguon.TabIndex = 2;
            lblNguon.Text = "Đường Dẫn Thư Mục Nguồn";
            // 
            // grpTienTrinh
            // 
            grpTienTrinh.Controls.Add(progressBar1);
            grpTienTrinh.ForeColor = Color.Blue;
            grpTienTrinh.Location = new Point(37, 263);
            grpTienTrinh.Name = "grpTienTrinh";
            grpTienTrinh.Size = new Size(917, 118);
            grpTienTrinh.TabIndex = 1;
            grpTienTrinh.TabStop = false;
            grpTienTrinh.Text = "Tiến Trình Sao Chép";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(43, 50);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(843, 34);
            progressBar1.TabIndex = 0;
            progressBar1.MouseHover += progressBar1_MouseHover;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // lblTrangThai
            // 
            lblTrangThai.BackColor = SystemColors.Control;
            lblTrangThai.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTrangThai.Location = new Point(2, 394);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(964, 34);
            lblTrangThai.TabIndex = 2;
            lblTrangThai.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmBai06
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 425);
            Controls.Add(lblTrangThai);
            Controls.Add(grpTienTrinh);
            Controls.Add(grpSaoChep);
            Name = "frmBai06";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sao chép tập tin";
            grpSaoChep.ResumeLayout(false);
            grpSaoChep.PerformLayout();
            grpTienTrinh.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpSaoChep;
        private TextBox txtDich;
        private TextBox txtNguon;
        private Label lblDich;
        private Label lblNguon;
        private GroupBox grpTienTrinh;
        private Button btnSaoChep;
        private Button btnDich;
        private Button btnNguon;
        private ProgressBar progressBar1;
        private ToolTip toolTip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lblTrangThai;
    }
}