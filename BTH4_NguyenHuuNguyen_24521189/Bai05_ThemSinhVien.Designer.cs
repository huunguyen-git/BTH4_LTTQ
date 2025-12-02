namespace BTH4_NguyenHuuNguyen_24521189
{
    partial class frmThemSinhVien
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
            lblMSSV = new Label();
            txtMSSV = new TextBox();
            txtTenSV = new TextBox();
            lblTenSV = new Label();
            lblKhoa = new Label();
            txtDiemTB = new TextBox();
            lblDiemTB = new Label();
            comboBoxKhoa = new ComboBox();
            btnThemMoi = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // lblMSSV
            // 
            lblMSSV.AutoSize = true;
            lblMSSV.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMSSV.Location = new Point(65, 72);
            lblMSSV.Name = "lblMSSV";
            lblMSSV.Size = new Size(191, 32);
            lblMSSV.TabIndex = 0;
            lblMSSV.Text = "Mã Số Sinh Viên";
            // 
            // txtMSSV
            // 
            txtMSSV.BorderStyle = BorderStyle.FixedSingle;
            txtMSSV.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMSSV.Location = new Point(276, 72);
            txtMSSV.Name = "txtMSSV";
            txtMSSV.Size = new Size(342, 34);
            txtMSSV.TabIndex = 1;
            txtMSSV.KeyPress += txtMSSV_KeyPress;
            // 
            // txtTenSV
            // 
            txtTenSV.BorderStyle = BorderStyle.FixedSingle;
            txtTenSV.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenSV.Location = new Point(276, 136);
            txtTenSV.Name = "txtTenSV";
            txtTenSV.Size = new Size(473, 34);
            txtTenSV.TabIndex = 3;
            // 
            // lblTenSV
            // 
            lblTenSV.AutoSize = true;
            lblTenSV.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTenSV.Location = new Point(65, 136);
            lblTenSV.Name = "lblTenSV";
            lblTenSV.Size = new Size(161, 32);
            lblTenSV.TabIndex = 2;
            lblTenSV.Text = "Tên Sinh Viên";
            // 
            // lblKhoa
            // 
            lblKhoa.AutoSize = true;
            lblKhoa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKhoa.Location = new Point(65, 200);
            lblKhoa.Name = "lblKhoa";
            lblKhoa.Size = new Size(68, 32);
            lblKhoa.TabIndex = 4;
            lblKhoa.Text = "Khoa";
            // 
            // txtDiemTB
            // 
            txtDiemTB.BorderStyle = BorderStyle.FixedSingle;
            txtDiemTB.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDiemTB.Location = new Point(276, 269);
            txtDiemTB.Name = "txtDiemTB";
            txtDiemTB.Size = new Size(158, 34);
            txtDiemTB.TabIndex = 7;
            // 
            // lblDiemTB
            // 
            lblDiemTB.AutoSize = true;
            lblDiemTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiemTB.Location = new Point(65, 269);
            lblDiemTB.Name = "lblDiemTB";
            lblDiemTB.Size = new Size(105, 32);
            lblDiemTB.TabIndex = 6;
            lblDiemTB.Text = "Điểm TB";
            // 
            // comboBoxKhoa
            // 
            comboBoxKhoa.BackColor = SystemColors.ScrollBar;
            comboBoxKhoa.FormattingEnabled = true;
            comboBoxKhoa.Items.AddRange(new object[] { "Khoa học Máy tính", "Công nghệ Phần mềm", "Hệ thống Thông tin", "Mạng máy tính và An toàn thông tin", "Kỹ thuật Máy tính", "Thương mại Điện tử" });
            comboBoxKhoa.Location = new Point(276, 203);
            comboBoxKhoa.Name = "comboBoxKhoa";
            comboBoxKhoa.Size = new Size(473, 33);
            comboBoxKhoa.TabIndex = 8;
            // 
            // btnThemMoi
            // 
            btnThemMoi.AutoSize = true;
            btnThemMoi.BackColor = Color.DarkSeaGreen;
            btnThemMoi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThemMoi.Location = new Point(441, 334);
            btnThemMoi.Name = "btnThemMoi";
            btnThemMoi.Size = new Size(161, 42);
            btnThemMoi.TabIndex = 9;
            btnThemMoi.Text = "Thêm Mới";
            btnThemMoi.UseVisualStyleBackColor = false;
            btnThemMoi.Click += btnThemMoi_Click;
            // 
            // btnThoat
            // 
            btnThoat.AutoSize = true;
            btnThoat.BackColor = Color.Tomato;
            btnThoat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(608, 334);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(121, 42);
            btnThoat.TabIndex = 10;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // frmThemSinhVien
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 405);
            Controls.Add(btnThoat);
            Controls.Add(btnThemMoi);
            Controls.Add(comboBoxKhoa);
            Controls.Add(txtDiemTB);
            Controls.Add(lblDiemTB);
            Controls.Add(lblKhoa);
            Controls.Add(txtTenSV);
            Controls.Add(lblTenSV);
            Controls.Add(txtMSSV);
            Controls.Add(lblMSSV);
            Name = "frmThemSinhVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm Sinh Viên";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMSSV;
        public TextBox txtMSSV;
        public TextBox txtTenSV;
        private Label lblTenSV;
        private Label lblKhoa;
        public TextBox txtDiemTB;
        private Label lblDiemTB;
        public ComboBox comboBoxKhoa;
        private Button btnThemMoi;
        private Button btnThoat;
    }
}