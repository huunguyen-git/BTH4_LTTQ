using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH4_NguyenHuuNguyen_24521189
{
    public partial class frmThemSinhVien : Form
    {
        private frmBai05 frmMain;
        public frmThemSinhVien(frmBai05 frmMain)
        {
            InitializeComponent();
            this.frmMain = frmMain;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtMSSV.Text) ||
                String.IsNullOrEmpty(txtTenSV.Text) ||
                String.IsNullOrEmpty(txtDiemTB.Text))
            {
                MessageBox.Show(
                    "Vui lòng điền đầy đủ thông tin",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            float fDiemTB;
            if (!float.TryParse(txtDiemTB.Text, out fDiemTB) ||
                fDiemTB < 0 || fDiemTB > 10)
            {
                MessageBox.Show(
                    "Điểm trung bình phải là số thập phân từ 0 đến 10",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Add((frmMain.originalItems.Count + 1).ToString());
                item.SubItems.Add(txtMSSV.Text);
                item.SubItems.Add(txtTenSV.Text);
                item.SubItems.Add(comboBoxKhoa.Text);
                item.SubItems.Add(txtDiemTB.Text);
                frmMain.originalItems.Add(item);
                frmMain.listViewDSSV.Items.Add((ListViewItem)item.Clone());
                frmMain.toolStripTxtTimKiem.Text = "";
                Close();
            }
        }

        private void txtMSSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
