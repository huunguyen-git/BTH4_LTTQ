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
    public partial class frmBai05 : Form
    {
        public List<ListViewItem> originalItems = new List<ListViewItem>();
        public frmBai05()
        {
            InitializeComponent();
            foreach (ListViewItem item in listViewDSSV.Items)
            {
                originalItems.Add((ListViewItem)item.Clone());
            }
        }

        private void toolStripBtnThemMoi_Click(object sender, EventArgs e)
        {
            frmThemSinhVien frmThemSV = new frmThemSinhVien(this);
            frmThemSV.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripTxtTimKiem_TextChanged(object sender, EventArgs e)
        {
            listViewDSSV.Items.Clear();
            
            if (String.IsNullOrEmpty(toolStripTxtTimKiem.Text))
            {
                foreach (ListViewItem item in originalItems)
                {
                    listViewDSSV.Items.Add((ListViewItem)item.Clone());
                }
                return;
            }

            foreach (ListViewItem item in originalItems)
            {
                String itemName = item.SubItems[3].Text.ToLower();
                String searchText = toolStripTxtTimKiem.Text.ToLower();
                if (itemName.Contains(searchText))
                {
                    listViewDSSV.Items.Add((ListViewItem)item.Clone());
                }
            }
        }
    }
}
