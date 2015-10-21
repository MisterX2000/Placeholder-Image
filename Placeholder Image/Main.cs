using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Placeholder_Image
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        string bgcolour;
        string tcolour;
        string temp;

        private void bt_go_Click(object sender, EventArgs e)
        {
            magic();
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            try
            {
                pb_image.Image.Save(saveFileDialog1.FileName, ImageFormat.Png);
            }
            catch { }

        }

        private void bt_bgcolour_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            temp = ColorTranslator.ToHtml(colorDialog1.Color);
            //Löscht das # von der Hex Farbe
            bgcolour = temp.Substring(1, temp.Length - 1);
            tb_bgcolour.Text = bgcolour;
        }

        private void bt_tcolour_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            temp = ColorTranslator.ToHtml(colorDialog1.Color);
            //Löscht das # von der Hex Farbe
            tcolour = temp.Substring(1, temp.Length - 1);
            tb_tcolour.Text = tcolour;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tp_placeholdit)
            {
                tabControl1.Size = new Size(200, 125);
            }
            else if (tabControl1.SelectedTab == tp_placekitten)
            {
                tabControl1.Size = new Size(200, 50);
            }
        }

        private void magic()
        {
            this.Width = this.MinimumSize.Width + (int)tb_width.Value - 252;
            this.Height = this.MinimumSize.Height + (int)tb_height.Value - 285;

            if (tabControl1.SelectedTab == tp_placeholdit)
            {
                pb_image.Load("http://placehold.it/" + tb_width.Value + "x" + tb_height.Value + "/" + bgcolour + "/" + tcolour + "?text=" + tb_text.Text);
                bt_save.Enabled = true;
            }
            else if (tabControl1.SelectedTab == tp_placekitten)
            {
                if (cb_gray.Checked)
                {
                    try
                    {
                        pb_image.Load("http://placekitten.com/g/" + tb_width.Value + "/" + tb_height.Value);
                        bt_save.Enabled = true;
                    }
                    catch
                    {
                        MessageBox.Show("404\nImage not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        bt_save.Enabled = false;
                    }
                }
                else
                {
                    try
                    {
                        pb_image.Load("http://placekitten.com/" + tb_width.Value + "/" + tb_height.Value);
                        bt_save.Enabled = true;
                    }
                    catch
                    {
                        MessageBox.Show("404\nImage not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        bt_save.Enabled = false;
                    }
                }
            }
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            tb_bgcolour.Text = "";
            tb_tcolour.Text = "";
            tb_text.Text = "";
            tb_width.Value = 252;
            tb_height.Value = 285;
            cb_gray.Checked = false;
            tabControl1.SelectedTab = tp_placeholdit;
            magic();
        }

        private void pb_image_MouseEnter(object sender, EventArgs e)
        {
            //bt_about.Visible = true;
        }

        private void pb_image_MouseLeave(object sender, EventArgs e)
        {
            //bt_about.Visible = false;
        }

        private void bt_about_Click(object sender, EventArgs e)
        {
            About AboutWindow = new About();
            AboutWindow.Show();
        }
    }
}
