﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string bgcolour;
        string tcolour;
        string temp;

        private void rb_placeholdit_CheckedChanged(object sender, EventArgs e)
        {
            l_text.Enabled = true;
            tb_text.Enabled = true;
        }

        private void rb_placekitten_CheckedChanged(object sender, EventArgs e)
        {
            l_text.Enabled = false;
            tb_text.Enabled = false;
        }

        private void bt_go_Click(object sender, EventArgs e)
        {
            if (rb_placeholdit.Checked == true)
            {
                pb_image.Load("http://placehold.it/" + tb_width.Value + "x" + tb_height.Value + "/" + bgcolour + "/" + tcolour + "?text=" + tb_text.Text);
                bt_save.Enabled = true;
            }
            else if (rb_placekitten.Checked == true)
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
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            pb_image.Image.Save(saveFileDialog1.FileName, ImageFormat.Png);

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
    }
}