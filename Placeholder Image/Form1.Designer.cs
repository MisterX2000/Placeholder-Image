namespace Placeholder_Image
{
    partial class Form1
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
            this.gb_service = new System.Windows.Forms.GroupBox();
            this.rb_placekitten = new System.Windows.Forms.RadioButton();
            this.rb_placeholdit = new System.Windows.Forms.RadioButton();
            this.l_width = new System.Windows.Forms.Label();
            this.l_height = new System.Windows.Forms.Label();
            this.l_text = new System.Windows.Forms.Label();
            this.tb_text = new System.Windows.Forms.TextBox();
            this.pb_image = new System.Windows.Forms.PictureBox();
            this.bt_go = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tb_width = new System.Windows.Forms.NumericUpDown();
            this.tb_height = new System.Windows.Forms.NumericUpDown();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.bt_save = new System.Windows.Forms.Button();
            this.l_bgcolour = new System.Windows.Forms.Label();
            this.tb_bgcolour = new System.Windows.Forms.TextBox();
            this.bt_bgcolour = new System.Windows.Forms.Button();
            this.l_tcolour = new System.Windows.Forms.Label();
            this.tb_tcolour = new System.Windows.Forms.TextBox();
            this.bt_tcolour = new System.Windows.Forms.Button();
            this.cb_bw = new System.Windows.Forms.CheckBox();
            this.gb_service.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_height)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_service
            // 
            this.gb_service.Controls.Add(this.rb_placekitten);
            this.gb_service.Controls.Add(this.rb_placeholdit);
            this.gb_service.Location = new System.Drawing.Point(12, 12);
            this.gb_service.Name = "gb_service";
            this.gb_service.Size = new System.Drawing.Size(200, 100);
            this.gb_service.TabIndex = 0;
            this.gb_service.TabStop = false;
            this.gb_service.Text = "Service";
            // 
            // rb_placekitten
            // 
            this.rb_placekitten.AutoSize = true;
            this.rb_placekitten.Location = new System.Drawing.Point(6, 42);
            this.rb_placekitten.Name = "rb_placekitten";
            this.rb_placekitten.Size = new System.Drawing.Size(77, 17);
            this.rb_placekitten.TabIndex = 1;
            this.rb_placekitten.Text = "placekitten";
            this.rb_placekitten.UseVisualStyleBackColor = true;
            this.rb_placekitten.CheckedChanged += new System.EventHandler(this.rb_placekitten_CheckedChanged);
            // 
            // rb_placeholdit
            // 
            this.rb_placeholdit.AutoSize = true;
            this.rb_placeholdit.Checked = true;
            this.rb_placeholdit.Location = new System.Drawing.Point(6, 19);
            this.rb_placeholdit.Name = "rb_placeholdit";
            this.rb_placeholdit.Size = new System.Drawing.Size(79, 17);
            this.rb_placeholdit.TabIndex = 0;
            this.rb_placeholdit.TabStop = true;
            this.rb_placeholdit.Text = "placehold.it";
            this.rb_placeholdit.UseVisualStyleBackColor = true;
            this.rb_placeholdit.CheckedChanged += new System.EventHandler(this.rb_placeholdit_CheckedChanged);
            // 
            // l_width
            // 
            this.l_width.AutoSize = true;
            this.l_width.Location = new System.Drawing.Point(12, 120);
            this.l_width.Name = "l_width";
            this.l_width.Size = new System.Drawing.Size(38, 13);
            this.l_width.TabIndex = 1;
            this.l_width.Text = "Width:";
            // 
            // l_height
            // 
            this.l_height.AutoSize = true;
            this.l_height.Location = new System.Drawing.Point(12, 146);
            this.l_height.Name = "l_height";
            this.l_height.Size = new System.Drawing.Size(41, 13);
            this.l_height.TabIndex = 1;
            this.l_height.Text = "Height:";
            // 
            // l_text
            // 
            this.l_text.AutoSize = true;
            this.l_text.Location = new System.Drawing.Point(12, 173);
            this.l_text.Name = "l_text";
            this.l_text.Size = new System.Drawing.Size(31, 13);
            this.l_text.TabIndex = 1;
            this.l_text.Text = "Text:";
            // 
            // tb_text
            // 
            this.tb_text.Location = new System.Drawing.Point(59, 170);
            this.tb_text.Name = "tb_text";
            this.tb_text.Size = new System.Drawing.Size(153, 20);
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
            // 
            // bt_go
            // 
            this.bt_go.Location = new System.Drawing.Point(12, 276);
            this.bt_go.Name = "bt_go";
            this.bt_go.Size = new System.Drawing.Size(90, 23);
            this.bt_go.TabIndex = 4;
            this.bt_go.Text = "Go!";
            this.bt_go.UseVisualStyleBackColor = true;
            this.bt_go.Click += new System.EventHandler(this.bt_go_Click);
            // 
            // tb_width
            // 
            this.tb_width.Location = new System.Drawing.Point(59, 118);
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
            this.tb_width.Size = new System.Drawing.Size(153, 20);
            this.tb_width.TabIndex = 5;
            this.tb_width.Value = new decimal(new int[] {
            252,
            0,
            0,
            0});
            // 
            // tb_height
            // 
            this.tb_height.Location = new System.Drawing.Point(59, 144);
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
            this.tb_height.Size = new System.Drawing.Size(153, 20);
            this.tb_height.TabIndex = 5;
            this.tb_height.Value = new decimal(new int[] {
            285,
            0,
            0,
            0});
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "png";
            this.saveFileDialog1.Filter = "Portable Network Graphics|*.png";
            this.saveFileDialog1.Title = "Save an Image File";
            // 
            // bt_save
            // 
            this.bt_save.Enabled = false;
            this.bt_save.Location = new System.Drawing.Point(122, 276);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(90, 23);
            this.bt_save.TabIndex = 6;
            this.bt_save.Text = "Save";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // l_bgcolour
            // 
            this.l_bgcolour.AutoSize = true;
            this.l_bgcolour.Location = new System.Drawing.Point(12, 199);
            this.l_bgcolour.Name = "l_bgcolour";
            this.l_bgcolour.Size = new System.Drawing.Size(58, 13);
            this.l_bgcolour.TabIndex = 1;
            this.l_bgcolour.Text = "BG Colour:";
            // 
            // tb_bgcolour
            // 
            this.tb_bgcolour.Location = new System.Drawing.Point(76, 196);
            this.tb_bgcolour.Name = "tb_bgcolour";
            this.tb_bgcolour.Size = new System.Drawing.Size(110, 20);
            this.tb_bgcolour.TabIndex = 2;
            // 
            // bt_bgcolour
            // 
            this.bt_bgcolour.Location = new System.Drawing.Point(192, 195);
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
            this.l_tcolour.Location = new System.Drawing.Point(12, 225);
            this.l_tcolour.Name = "l_tcolour";
            this.l_tcolour.Size = new System.Drawing.Size(50, 13);
            this.l_tcolour.TabIndex = 1;
            this.l_tcolour.Text = "T Colour:";
            // 
            // tb_tcolour
            // 
            this.tb_tcolour.Location = new System.Drawing.Point(76, 222);
            this.tb_tcolour.Name = "tb_tcolour";
            this.tb_tcolour.Size = new System.Drawing.Size(110, 20);
            this.tb_tcolour.TabIndex = 2;
            // 
            // bt_tcolour
            // 
            this.bt_tcolour.Location = new System.Drawing.Point(192, 221);
            this.bt_tcolour.Name = "bt_tcolour";
            this.bt_tcolour.Size = new System.Drawing.Size(20, 20);
            this.bt_tcolour.TabIndex = 7;
            this.bt_tcolour.Text = "D";
            this.bt_tcolour.UseVisualStyleBackColor = true;
            this.bt_tcolour.Click += new System.EventHandler(this.bt_tcolour_Click);
            // 
            // cb_bw
            // 
            this.cb_bw.AutoSize = true;
            this.cb_bw.Enabled = false;
            this.cb_bw.Location = new System.Drawing.Point(12, 248);
            this.cb_bw.Name = "cb_bw";
            this.cb_bw.Size = new System.Drawing.Size(49, 17);
            this.cb_bw.TabIndex = 8;
            this.cb_bw.Text = "B/W";
            this.cb_bw.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.cb_bw);
            this.Controls.Add(this.bt_tcolour);
            this.Controls.Add(this.bt_bgcolour);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.tb_height);
            this.Controls.Add(this.tb_width);
            this.Controls.Add(this.bt_go);
            this.Controls.Add(this.pb_image);
            this.Controls.Add(this.tb_tcolour);
            this.Controls.Add(this.l_tcolour);
            this.Controls.Add(this.tb_bgcolour);
            this.Controls.Add(this.l_bgcolour);
            this.Controls.Add(this.tb_text);
            this.Controls.Add(this.l_text);
            this.Controls.Add(this.l_height);
            this.Controls.Add(this.l_width);
            this.Controls.Add(this.gb_service);
            this.MinimumSize = new System.Drawing.Size(500, 350);
            this.Name = "Form1";
            this.Text = "Placeholder Image";
            this.gb_service.ResumeLayout(false);
            this.gb_service.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_height)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_service;
        private System.Windows.Forms.RadioButton rb_placekitten;
        private System.Windows.Forms.RadioButton rb_placeholdit;
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
        private System.Windows.Forms.CheckBox cb_bw;
    }
}

