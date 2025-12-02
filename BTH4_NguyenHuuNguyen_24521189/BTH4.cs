namespace BTH4_NguyenHuuNguyen_24521189
{
    public partial class frmBTH4 : Form
    {
        public frmBTH4()
        {
            InitializeComponent();
        }

        private void btnMo_Click(object sender, EventArgs e)
        {
            try
            {
                String choice = comboBox1.SelectedItem.ToString();
                switch (choice)
                {
                    case "Bài 03":
                        frmBai03 bai03 = new frmBai03();
                        bai03.ShowDialog();
                        break;
                    case "Bài 04":
                        frmBai04 bai04 = new frmBai04();
                        bai04.ShowDialog();
                        break;
                    case "Bài 05":
                        frmBai05 bai05 = new frmBai05();
                        bai05.ShowDialog();
                        break;
                    case "Bài 06":
                        frmBai06 bai06 = new frmBai06();
                        bai06.ShowDialog();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                        "Vui lòng chọn bài tập muốn mở!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
        }
    }
}
