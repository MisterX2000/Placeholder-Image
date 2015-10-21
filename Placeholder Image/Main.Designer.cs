namespace Placeholder_Image
{
    partial class Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.gb_size = new System.Windows.Forms.GroupBox();
            this.tb_height = new System.Windows.Forms.NumericUpDown();
            this.l_width = new System.Windows.Forms.Label();
            this.l_height = new System.Windows.Forms.Label();
            this.tb_width = new System.Windows.Forms.NumericUpDown();
            this.l_text = new System.Windows.Forms.Label();
            this.tb_text = new System.Windows.Forms.TextBox();
            this.pb_image = new System.Windows.Forms.PictureBox();
            this.bt_go = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.bt_save = new System.Windows.Forms.Button();
            this.l_bgcolour = new System.Windows.Forms.Label();
            this.tb_bgcolour = new System.Windows.Forms.TextBox();
            this.bt_bgcolour = new System.Windows.Forms.Button();
            this.l_tcolour = new System.Windows.Forms.Label();
            this.tb_tcolour = new System.Windows.Forms.TextBox();
            this.bt_tcolour = new System.Windows.Forms.Button();
            this.cb_gray = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_placeholdit = new System.Windows.Forms.TabPage();
            this.tp_placekitten = new System.Windows.Forms.TabPage();
            this.bt_reset = new System.Windows.Forms.Button();
            this.bt_about = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_size.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tp_placeholdit.SuspendLayout();
            this.tp_placekitten.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_size
            // 
            this.gb_size.Controls.Add(this.tb_height);
            this.gb_size.Controls.Add(this.l_width);
            this.gb_size.Controls.Add(this.l_height);
            this.gb_size.Controls.Add(this.tb_width);
            this.gb_size.Location = new System.Drawing.Point(12, 12);
            this.gb_size.Name = "gb_size";
            this.gb_size.Size = new System.Drawing.Size(200, 74);
            this.gb_size.TabIndex = 0;
            this.gb_size.TabStop = false;
            this.gb_size.Text = "Size";
            // 
            // tb_height
            // 
            this.tb_height.Location = new System.Drawing.Point(50, 45);
            this.tb_height.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.tb_height.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tb_height.Name = "tb_height";
            this.tb_height.Size = new System.Drawing.Size(144, 20);
            this.tb_height.TabIndex = 5;
            this.tb_height.Value = new decimal(new int[] {
            285,
            0,
            0,
            0});
            // 
            // l_width
            // 
            this.l_width.AutoSize = true;
            this.l_width.Location = new System.Drawing.Point(6, 21);
            this.l_width.Name = "l_width";
            this.l_width.Size = new System.Drawing.Size(38, 13);
            this.l_width.TabIndex = 1;
            this.l_width.Text = "Width:";
            // 
            // l_height
            // 
            this.l_height.AutoSize = true;
            this.l_height.Location = new System.Drawing.Point(6, 47);
            this.l_height.Name = "l_height";
            this.l_height.Size = new System.Drawing.Size(41, 13);
            this.l_height.TabIndex = 1;
            this.l_height.Text = "Height:";
            // 
            // tb_width
            // 
            this.tb_width.Location = new System.Drawing.Point(50, 19);
            this.tb_width.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.tb_width.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tb_width.Name = "tb_width";
            this.tb_width.Size = new System.Drawing.Size(144, 20);
            this.tb_width.TabIndex = 5;
            this.tb_width.Value = new decimal(new int[] {
            252,
            0,
            0,
            0});
            // 
            // l_text
            // 
            this.l_text.AutoSize = true;
            this.l_text.Location = new System.Drawing.Point(6, 9);
            this.l_text.Name = "l_text";
            this.l_text.Size = new System.Drawing.Size(31, 13);
            this.l_text.TabIndex = 1;
            this.l_text.Text = "Text:";
            // 
            // tb_text
            // 
            this.tb_text.Location = new System.Drawing.Point(47, 6);
            this.tb_text.Name = "tb_text";
            this.tb_text.Size = new System.Drawing.Size(139, 20);
            this.tb_text.TabIndex = 2;
            // 
            // pb_image
            // 
            this.pb_image.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_image.Location = new System.Drawing.Point(218, 12);
            this.pb_image.Name = "pb_image";
            this.pb_image.Size = new System.Drawing.Size(254, 287);
            this.pb_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_image.TabIndex = 3;
            this.pb_image.TabStop = false;
            this.pb_image.MouseEnter += new System.EventHandler(this.pb_image_MouseEnter);
            this.pb_image.MouseLeave += new System.EventHandler(this.pb_image_MouseLeave);
            // 
            // bt_go
            // 
            this.bt_go.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_go.Location = new System.Drawing.Point(12, 276);
            this.bt_go.Name = "bt_go";
            this.bt_go.Size = new System.Drawing.Size(58, 23);
            this.bt_go.TabIndex = 4;
            this.bt_go.Text = "Go!";
            this.bt_go.UseVisualStyleBackColor = true;
            this.bt_go.Click += new System.EventHandler(this.bt_go_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "png";
            this.saveFileDialog1.FileName = "Placeholder";
            this.saveFileDialog1.Filter = "Portable Network Graphics|*.png";
            this.saveFileDialog1.Title = "Save an Image File";
            // 
            // bt_save
            // 
            this.bt_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_save.Enabled = false;
            this.bt_save.Location = new System.Drawing.Point(142, 276);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(60, 23);
            this.bt_save.TabIndex = 6;
            this.bt_save.Text = "Save";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // l_bgcolour
            // 
            this.l_bgcolour.AutoSize = true;
            this.l_bgcolour.Location = new System.Drawing.Point(6, 35);
            this.l_bgcolour.Name = "l_bgcolour";
            this.l_bgcolour.Size = new System.Drawing.Size(58, 13);
            this.l_bgcolour.TabIndex = 1;
            this.l_bgcolour.Text = "BG Colour:";
            // 
            // tb_bgcolour
            // 
            this.tb_bgcolour.Location = new System.Drawing.Point(70, 32);
            this.tb_bgcolour.Name = "tb_bgcolour";
            this.tb_bgcolour.Size = new System.Drawing.Size(93, 20);
            this.tb_bgcolour.TabIndex = 2;
            // 
            // bt_bgcolour
            // 
            this.bt_bgcolour.Location = new System.Drawing.Point(169, 32);
            this.bt_bgcolour.Name = "bt_bgcolour";
            this.bt_bgcolour.Size = new System.Drawing.Size(20, 20);
            this.bt_bgcolour.TabIndex = 7;
            this.bt_bgcolour.Text = "D";
            this.bt_bgcolour.UseVisualStyleBackColor = true;
            this.bt_bgcolour.Click += new System.EventHandler(this.bt_bgcolour_Click);
            // 
            // l_tcolour
            // 
            this.l_tcolour.AutoSize = true;
            this.l_tcolour.Location = new System.Drawing.Point(6, 61);
            this.l_tcolour.Name = "l_tcolour";
            this.l_tcolour.Size = new System.Drawing.Size(50, 13);
            this.l_tcolour.TabIndex = 1;
            this.l_tcolour.Text = "T Colour:";
            // 
            // tb_tcolour
            // 
            this.tb_tcolour.Location = new System.Drawing.Point(70, 58);
            this.tb_tcolour.Name = "tb_tcolour";
            this.tb_tcolour.Size = new System.Drawing.Size(93, 20);
            this.tb_tcolour.TabIndex = 2;
            // 
            // bt_tcolour
            // 
            this.bt_tcolour.Location = new System.Drawing.Point(169, 58);
            this.bt_tcolour.Name = "bt_tcolour";
            this.bt_tcolour.Size = new System.Drawing.Size(20, 20);
            this.bt_tcolour.TabIndex = 7;
            this.bt_tcolour.Text = "D";
            this.bt_tcolour.UseVisualStyleBackColor = true;
            this.bt_tcolour.Click += new System.EventHandler(this.bt_tcolour_Click);
            // 
            // cb_gray
            // 
            this.cb_gray.AutoSize = true;
            this.cb_gray.Location = new System.Drawing.Point(6, 6);
            this.cb_gray.Name = "cb_gray";
            this.cb_gray.Size = new System.Drawing.Size(73, 17);
            this.cb_gray.TabIndex = 8;
            this.cb_gray.Text = "Grayscale";
            this.cb_gray.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_placeholdit);
            this.tabControl1.Controls.Add(this.tp_placekitten);
            this.tabControl1.Location = new System.Drawing.Point(12, 92);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 125);
            this.tabControl1.TabIndex = 9;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tp_placeholdit
            // 
            this.tp_placeholdit.Controls.Add(this.label1);
            this.tp_placeholdit.Controls.Add(this.l_text);
            this.tp_placeholdit.Controls.Add(this.tb_tcolour);
            this.tp_placeholdit.Controls.Add(this.tb_text);
            this.tp_placeholdit.Controls.Add(this.l_tcolour);
            this.tp_placeholdit.Controls.Add(this.tb_bgcolour);
            this.tp_placeholdit.Controls.Add(this.bt_tcolour);
            this.tp_placeholdit.Controls.Add(this.bt_bgcolour);
            this.tp_placeholdit.Controls.Add(this.l_bgcolour);
            this.tp_placeholdit.Location = new System.Drawing.Point(4, 22);
            this.tp_placeholdit.Name = "tp_placeholdit";
            this.tp_placeholdit.Padding = new System.Windows.Forms.Padding(3);
            this.tp_placeholdit.Size = new System.Drawing.Size(192, 99);
            this.tp_placeholdit.TabIndex = 0;
            this.tp_placeholdit.Text = "placehold.it";
            this.tp_placeholdit.UseVisualStyleBackColor = true;
            // 
            // tp_placekitten
            // 
            this.tp_placekitten.Controls.Add(this.cb_gray);
            this.tp_placekitten.Location = new System.Drawing.Point(4, 22);
            this.tp_placekitten.Name = "tp_placekitten";
            this.tp_placekitten.Padding = new System.Windows.Forms.Padding(3);
            this.tp_placekitten.Size = new System.Drawing.Size(192, 84);
            this.tp_placekitten.TabIndex = 1;
            this.tp_placekitten.Text = "placekitten";
            this.tp_placekitten.UseVisualStyleBackColor = true;
            // 
            // bt_reset
            // 
            this.bt_reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_reset.Location = new System.Drawing.Point(76, 276);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(60, 23);
            this.bt_reset.TabIndex = 10;
            this.bt_reset.Text = "Reset";
            this.bt_reset.UseVisualStyleBackColor = true;
            this.bt_reset.Click += new System.EventHandler(this.bt_reset_Click);
            // 
            // bt_about
            // 
            this.bt_about.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_about.Location = new System.Drawing.Point(451, 13);
            this.bt_about.Name = "bt_about";
            this.bt_about.Size = new System.Drawing.Size(20, 20);
            this.bt_about.TabIndex = 11;
            this.bt_about.Text = "?";
            this.bt_about.UseVisualStyleBackColor = true;
            this.bt_about.Click += new System.EventHandler(this.bt_about_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(6, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Colours must be in Hex format";
            // 
            // Main
            // 
            this.AcceptButton = this.bt_go;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.bt_about);
            this.Controls.Add(this.bt_reset);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.bt_go);
            this.Controls.Add(this.pb_image);
            this.Controls.Add(this.gb_size);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 350);
            this.Name = "Main";
            this.Text = "Placeholder Image";
            this.gb_size.ResumeLayout(false);
            this.gb_size.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tp_placeholdit.ResumeLayout(false);
            this.tp_placeholdit.PerformLayout();
            this.tp_placekitten.ResumeLayout(false);
            this.tp_placekitten.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_size;
        private System.Windows.Forms.Label l_width;
        private System.Windows.Forms.Label l_height;
        private System.Windows.Forms.Label l_text;
        private System.Windows.Forms.TextBox tb_text;
        private System.Windows.Forms.PictureBox pb_image;
        private System.Windows.Forms.Button bt_go;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.NumericUpDown tb_width;
        private System.Windows.Forms.NumericUpDown tb_height;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Label l_bgcolour;
        private System.Windows.Forms.TextBox tb_bgcolour;
        private System.Windows.Forms.Button bt_bgcolour;
        private System.Windows.Forms.Label l_tcolour;
        private System.Windows.Forms.TextBox tb_tcolour;
        private System.Windows.Forms.Button bt_tcolour;
        private System.Windows.Forms.CheckBox cb_gray;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_placeholdit;
        private System.Windows.Forms.TabPage tp_placekitten;
        private System.Windows.Forms.Button bt_reset;
        private System.Windows.Forms.Button bt_about;
        private System.Windows.Forms.Label label1;
    }
}

