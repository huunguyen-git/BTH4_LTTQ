using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH4_NguyenHuuNguyen_24521189
{
    public partial class frmBai04 : Form
    {
        private String currentFilePath = "";
        private bool isSynchronizing;

        public frmBai04()
        {
            InitializeComponent();

            // Đưa tất cả font vào toolStripComboBoxFont
            InstalledFontCollection installedFonts = new InstalledFontCollection();
            FontFamily[] fontFamilies = installedFonts.Families;
            foreach (FontFamily family in fontFamilies)
            {
                toolStripComboBoxFont.Items.Add(family.Name);
            }

            // Thiết lập mặc định
            setDefaultFormat();
        }

        private void setDefaultFormat()
        {
            toolStripComboBoxFont.SelectedIndex = toolStripComboBoxFont.Items.IndexOf("Tahoma");
            toolStripComboBoxFont.Text = "Tahoma";
            toolStripComboFontSize.SelectedIndex = toolStripComboFontSize.Items.IndexOf("14");
            toolStripComboFontSize.Text = "14";
            richTxtWritingArea.SelectionFont = new Font("Tahoma", 14, FontStyle.Regular);
        }

        private void NewPage_Click(object sender, EventArgs e)
        {
            richTxtWritingArea.Clear();
            setDefaultFormat();
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|Rich Text Files (*.rtf)|*.rtf";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (openFileDialog.FileName.EndsWith(".rtf"))
                    {
                        richTxtWritingArea.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.RichText);
                    }
                    else
                    {
                        richTxtWritingArea.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);
                    }

                    currentFilePath = openFileDialog.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Lỗi khi mở tệp",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void SaveFile_Click(Object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(currentFilePath))
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Rich Text Files (*.rtf)|*.rtf";
                saveFileDialog.DefaultExt = "rtf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    currentFilePath = saveFileDialog.FileName;
                }
                else
                {
                    return;
                }
            }

            try
            {
                richTxtWritingArea.SaveFile(currentFilePath, RichTextBoxStreamType.RichText);
                MessageBox.Show(
                    "Lưu văn bản thành công",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Đã xảy ra lỗi khi lưu file",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ApplyNewFont(Object sender, EventArgs e)
        {
            if (isSynchronizing)
            {
                return;
            }

            String fontName = toolStripComboBoxFont.Text;
            if (!float.TryParse(toolStripComboFontSize.Text, out float fontSize))
            {
                return;
            }

            Font currentFont = richTxtWritingArea.SelectionFont ?? richTxtWritingArea.Font;
            FontStyle currentStyle = currentFont.Style;

            Font newFont = new Font(fontName, fontSize, currentStyle);
            richTxtWritingArea.SelectionFont = newFont;
        }

        private void EditWithFontDialog(Object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTxtWritingArea.SelectionFont = fontDialog.Font;
                SynchronizeTools();
            }
        }

        private void SynchronizeTools()
        {
            isSynchronizing = true;
            Font currentFont = richTxtWritingArea.SelectionFont ?? richTxtWritingArea.Font;
            toolStripComboBoxFont.Text = currentFont.Name;
            toolStripComboFontSize.Text = currentFont.Size.ToString();
            toolStripBtnBold.Checked = currentFont.Bold;
            toolStripBtnItalic.Checked = currentFont.Italic;
            toolStripBtnUnderline.Checked = currentFont.Underline;
            isSynchronizing = false;
        }

        private void richTxtWritingArea_SelectionChanged(object sender, EventArgs e)
        {
            SynchronizeTools();
        }

        private void toolStripBtnBold_Click(object sender, EventArgs e)
        {
            Font currentFont = richTxtWritingArea.SelectionFont ?? richTxtWritingArea.Font;

            FontStyle newStyle = currentFont.Style ^ FontStyle.Bold;

            Font newFont = new Font(currentFont, newStyle);
            richTxtWritingArea.SelectionFont = newFont;
        }

        private void toolStripBtnItalic_Click(object sender, EventArgs e)
        {
            Font currentFont = richTxtWritingArea.SelectionFont ?? richTxtWritingArea.Font;

            FontStyle newStyle = currentFont.Style ^ FontStyle.Italic;

            Font newFont = new Font(currentFont, newStyle);
            richTxtWritingArea.SelectionFont = newFont;
        }

        private void toolStripBtnUnderline_Click(object sender, EventArgs e)
        {
            Font currentFont = richTxtWritingArea.SelectionFont ?? richTxtWritingArea.Font;

            FontStyle newStyle = currentFont.Style ^ FontStyle.Underline;

            Font newFont = new Font(currentFont, newStyle);
            richTxtWritingArea.SelectionFont = newFont;
        }
    }
}
