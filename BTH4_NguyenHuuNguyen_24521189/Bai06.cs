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
    public partial class frmBai06 : Form
    {
        private String strTrangThai = "";
        public frmBai06()
        {
            InitializeComponent();
        }

        private void btnNguon_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    txtNguon.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void btnDich_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    txtDich.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void btnSaoChep_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNguon.Text) ||
                String.IsNullOrEmpty(txtDich.Text))
            {
                MessageBox.Show(
                    "Vui lòng điền đủ đường dẫn nguồn và đích!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            btnSaoChep.Enabled = false;
            String[] paths = new String[] { txtNguon.Text, txtDich.Text };
            backgroundWorker1.RunWorkerAsync(paths);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            String[] paths = e.Argument as String[];
            String nguon = paths[0];
            String dich = paths[1];

            String[] allFiles = new String[] { };
            try
            {
                allFiles = Directory.GetFiles(nguon, "*.*", SearchOption.AllDirectories);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Đường dẫn nguồn hoặc đích không hợp lệ!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            foreach (String fileNguon in allFiles)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }

                String relativePath = fileNguon.Substring(nguon.Length + 1);
                String fileDich = Path.Combine(dich, relativePath);
                String thuMucCha = Path.GetDirectoryName(fileDich);

                if (!Directory.Exists(thuMucCha))
                {
                    Directory.CreateDirectory(thuMucCha);
                }
                SaoChepFiles(worker, fileNguon, fileDich);
            }
        }

        private void SaoChepFiles(BackgroundWorker worker, String fileNguon, String fileDich)
        {
            worker.ReportProgress(0, fileNguon);

            using (FileStream fsNguon = new FileStream(fileNguon, FileMode.Open, FileAccess.Read))
            using (FileStream fsDich = new FileStream(fileDich, FileMode.Create, FileAccess.Write))
            {
                long fileSize = fsNguon.Length;
                byte[] buffer = new byte[4096];
                int bytesRead;
                long totalBytesCopied = 0;

                while ((bytesRead = fsNguon.Read(buffer, 0, buffer.Length)) > 0)
                {
                    fsDich.Write(buffer, 0, bytesRead);
                    totalBytesCopied += bytesRead;

                    int percentProgress = (int)(((double)totalBytesCopied * 100) / fileSize);
                    worker.ReportProgress(percentProgress, fileNguon);
                }
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;

            if (e.UserState is String currentFile)
            {
                strTrangThai = "Đang sao chép: " + currentFile;
                lblTrangThai.Text = strTrangThai;
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnSaoChep.Enabled = true;

            if (e.Cancelled)
            {
                lblTrangThai.Text = "Đã huỷ quá trình sao chép";
            }
            else if (e.Error != null)
            {
                lblTrangThai.Text = "Đã xảy ra lỗi!";
            }
            else
            {
                lblTrangThai.Text = "Đã hoàn thành sao chép tất cả tập tin";
            }
            strTrangThai = "";
            progressBar1.Value = 0;
        }

        private void progressBar1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(progressBar1, strTrangThai);
        }
    }
}
