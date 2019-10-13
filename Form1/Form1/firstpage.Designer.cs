namespace Form1.Usercontrolsfile
{
    partial class Add
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add));
            this.trendbutton = new ns1.BunifuThinButton2();
            this.recbutton = new ns1.BunifuThinButton2();
            this.kidsbutton = new ns1.BunifuThinButton2();
            this.cizgi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Trendpanel = new ns1.BunifuGradientPanel();
            this.take3 = new ns1.BunifuFlatButton();
            this.take2 = new ns1.BunifuFlatButton();
            this.takeone = new ns1.BunifuFlatButton();
            this.TrendBookPublisher3 = new ns1.BunifuCustomLabel();
            this.TrendBookAuthor3 = new ns1.BunifuCustomLabel();
            this.TrendBookName3 = new ns1.BunifuCustomLabel();
            this.TrendBookPublisher2 = new ns1.BunifuCustomLabel();
            this.TrendBookAuthor2 = new ns1.BunifuCustomLabel();
            this.TrendBookName2 = new ns1.BunifuCustomLabel();
            this.TrendBookPublisher = new ns1.BunifuCustomLabel();
            this.TrendBookAuthor = new ns1.BunifuCustomLabel();
            this.TrendBookName = new ns1.BunifuCustomLabel();
            this.firstpageselected = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.Trendpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // trendbutton
            // 
            this.trendbutton.ActiveBorderThickness = 1;
            this.trendbutton.ActiveCornerRadius = 20;
            this.trendbutton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.trendbutton.ActiveForecolor = System.Drawing.Color.Transparent;
            this.trendbutton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.trendbutton.BackColor = System.Drawing.Color.Transparent;
            this.trendbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("trendbutton.BackgroundImage")));
            this.trendbutton.ButtonText = "Trends";
            this.trendbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trendbutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trendbutton.ForeColor = System.Drawing.Color.SeaGreen;
            this.trendbutton.IdleBorderThickness = 1;
            this.trendbutton.IdleCornerRadius = 20;
            this.trendbutton.IdleFillColor = System.Drawing.Color.Transparent;
            this.trendbutton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.trendbutton.IdleLineColor = System.Drawing.Color.Transparent;
            this.trendbutton.Location = new System.Drawing.Point(115, 60);
            this.trendbutton.Margin = new System.Windows.Forms.Padding(5);
            this.trendbutton.Name = "trendbutton";
            this.trendbutton.Size = new System.Drawing.Size(180, 40);
            this.trendbutton.TabIndex = 0;
            this.trendbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.trendbutton.Click += new System.EventHandler(this.trendbutton_Click);
            // 
            // recbutton
            // 
            this.recbutton.ActiveBorderThickness = 1;
            this.recbutton.ActiveCornerRadius = 20;
            this.recbutton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.recbutton.ActiveForecolor = System.Drawing.Color.Transparent;
            this.recbutton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.recbutton.BackColor = System.Drawing.Color.Transparent;
            this.recbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("recbutton.BackgroundImage")));
            this.recbutton.ButtonText = "Recomended";
            this.recbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.recbutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recbutton.ForeColor = System.Drawing.Color.SeaGreen;
            this.recbutton.IdleBorderThickness = 1;
            this.recbutton.IdleCornerRadius = 20;
            this.recbutton.IdleFillColor = System.Drawing.Color.Transparent;
            this.recbutton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.recbutton.IdleLineColor = System.Drawing.Color.Transparent;
            this.recbutton.Location = new System.Drawing.Point(410, 60);
            this.recbutton.Margin = new System.Windows.Forms.Padding(5);
            this.recbutton.Name = "recbutton";
            this.recbutton.Size = new System.Drawing.Size(180, 40);
            this.recbutton.TabIndex = 1;
            this.recbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.recbutton.Click += new System.EventHandler(this.recbutton_Click);
            // 
            // kidsbutton
            // 
            this.kidsbutton.ActiveBorderThickness = 1;
            this.kidsbutton.ActiveCornerRadius = 20;
            this.kidsbutton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.kidsbutton.ActiveForecolor = System.Drawing.Color.Transparent;
            this.kidsbutton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.kidsbutton.BackColor = System.Drawing.Color.Transparent;
            this.kidsbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kidsbutton.BackgroundImage")));
            this.kidsbutton.ButtonText = "For Kids";
            this.kidsbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kidsbutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kidsbutton.ForeColor = System.Drawing.Color.SeaGreen;
            this.kidsbutton.IdleBorderThickness = 1;
            this.kidsbutton.IdleCornerRadius = 20;
            this.kidsbutton.IdleFillColor = System.Drawing.Color.Transparent;
            this.kidsbutton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.kidsbutton.IdleLineColor = System.Drawing.Color.Transparent;
            this.kidsbutton.Location = new System.Drawing.Point(705, 60);
            this.kidsbutton.Margin = new System.Windows.Forms.Padding(5);
            this.kidsbutton.Name = "kidsbutton";
            this.kidsbutton.Size = new System.Drawing.Size(180, 40);
            this.kidsbutton.TabIndex = 2;
            this.kidsbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.kidsbutton.Click += new System.EventHandler(this.kidsbutton_Click);
            // 
            // cizgi
            // 
            this.cizgi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cizgi.Location = new System.Drawing.Point(352, 60);
            this.cizgi.Name = "cizgi";
            this.cizgi.Size = new System.Drawing.Size(2, 40);
            this.cizgi.TabIndex = 3;
            this.cizgi.Text = "label1";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(653, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(115, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(410, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(180, 180);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Location = new System.Drawing.Point(705, 40);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(180, 180);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // Trendpanel
            // 
            this.Trendpanel.BackColor = System.Drawing.Color.Transparent;
            this.Trendpanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Trendpanel.BackgroundImage")));
            this.Trendpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Trendpanel.Controls.Add(this.take3);
            this.Trendpanel.Controls.Add(this.take2);
            this.Trendpanel.Controls.Add(this.takeone);
            this.Trendpanel.Controls.Add(this.TrendBookPublisher3);
            this.Trendpanel.Controls.Add(this.TrendBookAuthor3);
            this.Trendpanel.Controls.Add(this.TrendBookName3);
            this.Trendpanel.Controls.Add(this.TrendBookPublisher2);
            this.Trendpanel.Controls.Add(this.TrendBookAuthor2);
            this.Trendpanel.Controls.Add(this.TrendBookName2);
            this.Trendpanel.Controls.Add(this.TrendBookPublisher);
            this.Trendpanel.Controls.Add(this.TrendBookAuthor);
            this.Trendpanel.Controls.Add(this.TrendBookName);
            this.Trendpanel.Controls.Add(this.pictureBox1);
            this.Trendpanel.Controls.Add(this.pictureBox3);
            this.Trendpanel.Controls.Add(this.pictureBox2);
            this.Trendpanel.ForeColor = System.Drawing.Color.Transparent;
            this.Trendpanel.GradientBottomLeft = System.Drawing.Color.Transparent;
            this.Trendpanel.GradientBottomRight = System.Drawing.Color.Transparent;
            this.Trendpanel.GradientTopLeft = System.Drawing.Color.Transparent;
            this.Trendpanel.GradientTopRight = System.Drawing.Color.Transparent;
            this.Trendpanel.Location = new System.Drawing.Point(0, 100);
            this.Trendpanel.Name = "Trendpanel";
            this.Trendpanel.Quality = 10;
            this.Trendpanel.Size = new System.Drawing.Size(1000, 550);
            this.Trendpanel.TabIndex = 8;
            
            // 
            // take3
            // 
            this.take3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.take3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.take3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.take3.BorderRadius = 5;
            this.take3.ButtonText = "Take Book";
            this.take3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.take3.DisabledColor = System.Drawing.Color.Gray;
            this.take3.Iconcolor = System.Drawing.Color.Transparent;
            this.take3.Iconimage = null;
            this.take3.Iconimage_right = null;
            this.take3.Iconimage_right_Selected = null;
            this.take3.Iconimage_Selected = null;
            this.take3.IconMarginLeft = 0;
            this.take3.IconMarginRight = 0;
            this.take3.IconRightVisible = true;
            this.take3.IconRightZoom = 0D;
            this.take3.IconVisible = true;
            this.take3.IconZoom = 90D;
            this.take3.IsTab = false;
            this.take3.Location = new System.Drawing.Point(705, 413);
            this.take3.Name = "take3";
            this.take3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.take3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.take3.OnHoverTextColor = System.Drawing.Color.White;
            this.take3.selected = false;
            this.take3.Size = new System.Drawing.Size(180, 46);
            this.take3.TabIndex = 19;
            this.take3.Text = "Take Book";
            this.take3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.take3.Textcolor = System.Drawing.Color.White;
            this.take3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.take3.Click += new System.EventHandler(this.take3_Click);
            // 
            // take2
            // 
            this.take2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.take2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.take2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.take2.BorderRadius = 5;
            this.take2.ButtonText = "Take Book";
            this.take2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.take2.DisabledColor = System.Drawing.Color.Gray;
            this.take2.Iconcolor = System.Drawing.Color.Transparent;
            this.take2.Iconimage = null;
            this.take2.Iconimage_right = null;
            this.take2.Iconimage_right_Selected = null;
            this.take2.Iconimage_Selected = null;
            this.take2.IconMarginLeft = 0;
            this.take2.IconMarginRight = 0;
            this.take2.IconRightVisible = true;
            this.take2.IconRightZoom = 0D;
            this.take2.IconVisible = true;
            this.take2.IconZoom = 90D;
            this.take2.IsTab = false;
            this.take2.Location = new System.Drawing.Point(410, 413);
            this.take2.Name = "take2";
            this.take2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.take2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.take2.OnHoverTextColor = System.Drawing.Color.White;
            this.take2.selected = false;
            this.take2.Size = new System.Drawing.Size(180, 46);
            this.take2.TabIndex = 18;
            this.take2.Text = "Take Book";
            this.take2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.take2.Textcolor = System.Drawing.Color.White;
            this.take2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.take2.Click += new System.EventHandler(this.take2_Click);
            // 
            // takeone
            // 
            this.takeone.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.takeone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.takeone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.takeone.BorderRadius = 5;
            this.takeone.ButtonText = "Take Book";
            this.takeone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.takeone.DisabledColor = System.Drawing.Color.Gray;
            this.takeone.Iconcolor = System.Drawing.Color.Transparent;
            this.takeone.Iconimage = null;
            this.takeone.Iconimage_right = null;
            this.takeone.Iconimage_right_Selected = null;
            this.takeone.Iconimage_Selected = null;
            this.takeone.IconMarginLeft = 0;
            this.takeone.IconMarginRight = 0;
            this.takeone.IconRightVisible = true;
            this.takeone.IconRightZoom = 0D;
            this.takeone.IconVisible = true;
            this.takeone.IconZoom = 90D;
            this.takeone.IsTab = false;
            this.takeone.Location = new System.Drawing.Point(115, 413);
            this.takeone.Name = "takeone";
            this.takeone.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.takeone.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.takeone.OnHoverTextColor = System.Drawing.Color.White;
            this.takeone.selected = false;
            this.takeone.Size = new System.Drawing.Size(180, 46);
            this.takeone.TabIndex = 17;
            this.takeone.Text = "Take Book";
            this.takeone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.takeone.Textcolor = System.Drawing.Color.White;
            this.takeone.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.takeone.Click += new System.EventHandler(this.takeone_Click);
            // 
            // TrendBookPublisher3
            // 
            this.TrendBookPublisher3.AutoSize = true;
            this.TrendBookPublisher3.ForeColor = System.Drawing.Color.Black;
            this.TrendBookPublisher3.Location = new System.Drawing.Point(743, 375);
            this.TrendBookPublisher3.Name = "TrendBookPublisher3";
            this.TrendBookPublisher3.Size = new System.Drawing.Size(103, 13);
            this.TrendBookPublisher3.TabIndex = 16;
            this.TrendBookPublisher3.Text = "bunifuCustomLabel9";
            // 
            // TrendBookAuthor3
            // 
            this.TrendBookAuthor3.AutoSize = true;
            this.TrendBookAuthor3.ForeColor = System.Drawing.Color.Black;
            this.TrendBookAuthor3.Location = new System.Drawing.Point(743, 323);
            this.TrendBookAuthor3.Name = "TrendBookAuthor3";
            this.TrendBookAuthor3.Size = new System.Drawing.Size(103, 13);
            this.TrendBookAuthor3.TabIndex = 15;
            this.TrendBookAuthor3.Text = "bunifuCustomLabel8";
            // 
            // TrendBookName3
            // 
            this.TrendBookName3.AutoSize = true;
            this.TrendBookName3.ForeColor = System.Drawing.Color.Black;
            this.TrendBookName3.Location = new System.Drawing.Point(743, 269);
            this.TrendBookName3.Name = "TrendBookName3";
            this.TrendBookName3.Size = new System.Drawing.Size(94, 13);
            this.TrendBookName3.TabIndex = 14;
            this.TrendBookName3.Text = "TrendBookName3";
            // 
            // TrendBookPublisher2
            // 
            this.TrendBookPublisher2.AutoSize = true;
            this.TrendBookPublisher2.ForeColor = System.Drawing.Color.Black;
            this.TrendBookPublisher2.Location = new System.Drawing.Point(449, 365);
            this.TrendBookPublisher2.Name = "TrendBookPublisher2";
            this.TrendBookPublisher2.Size = new System.Drawing.Size(103, 13);
            this.TrendBookPublisher2.TabIndex = 13;
            this.TrendBookPublisher2.Text = "bunifuCustomLabel6";
            // 
            // TrendBookAuthor2
            // 
            this.TrendBookAuthor2.AutoSize = true;
            this.TrendBookAuthor2.ForeColor = System.Drawing.Color.Black;
            this.TrendBookAuthor2.Location = new System.Drawing.Point(449, 323);
            this.TrendBookAuthor2.Name = "TrendBookAuthor2";
            this.TrendBookAuthor2.Size = new System.Drawing.Size(103, 13);
            this.TrendBookAuthor2.TabIndex = 12;
            this.TrendBookAuthor2.Text = "bunifuCustomLabel5";
            // 
            // TrendBookName2
            // 
            this.TrendBookName2.AutoSize = true;
            this.TrendBookName2.ForeColor = System.Drawing.Color.Black;
            this.TrendBookName2.Location = new System.Drawing.Point(449, 269);
            this.TrendBookName2.Name = "TrendBookName2";
            this.TrendBookName2.Size = new System.Drawing.Size(103, 13);
            this.TrendBookName2.TabIndex = 11;
            this.TrendBookName2.Text = "bunifuCustomLabel4";
            // 
            // TrendBookPublisher
            // 
            this.TrendBookPublisher.AutoSize = true;
            this.TrendBookPublisher.ForeColor = System.Drawing.Color.Black;
            this.TrendBookPublisher.Location = new System.Drawing.Point(144, 365);
            this.TrendBookPublisher.Name = "TrendBookPublisher";
            this.TrendBookPublisher.Size = new System.Drawing.Size(103, 13);
            this.TrendBookPublisher.TabIndex = 10;
            this.TrendBookPublisher.Text = "bunifuCustomLabel3";
            // 
            // TrendBookAuthor
            // 
            this.TrendBookAuthor.AutoSize = true;
            this.TrendBookAuthor.ForeColor = System.Drawing.Color.Black;
            this.TrendBookAuthor.Location = new System.Drawing.Point(144, 323);
            this.TrendBookAuthor.Name = "TrendBookAuthor";
            this.TrendBookAuthor.Size = new System.Drawing.Size(103, 13);
            this.TrendBookAuthor.TabIndex = 9;
            this.TrendBookAuthor.Text = "bunifuCustomLabel2";
            // 
            // TrendBookName
            // 
            this.TrendBookName.AutoSize = true;
            this.TrendBookName.ForeColor = System.Drawing.Color.Black;
            this.TrendBookName.Location = new System.Drawing.Point(144, 276);
            this.TrendBookName.Name = "TrendBookName";
            this.TrendBookName.Size = new System.Drawing.Size(103, 13);
            this.TrendBookName.TabIndex = 8;
            this.TrendBookName.Text = "bunifuCustomLabel1";
            // 
            // firstpageselected
            // 
            this.firstpageselected.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.firstpageselected.Location = new System.Drawing.Point(180, 95);
            this.firstpageselected.Name = "firstpageselected";
            this.firstpageselected.Size = new System.Drawing.Size(50, 2);
            this.firstpageselected.TabIndex = 9;
            this.firstpageselected.Text = "label1";
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.firstpageselected);
            this.Controls.Add(this.Trendpanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cizgi);
            this.Controls.Add(this.kidsbutton);
            this.Controls.Add(this.recbutton);
            this.Controls.Add(this.trendbutton);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "Add";
            this.Size = new System.Drawing.Size(1000, 650);
            this.Load += new System.EventHandler(this.firstpage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.Trendpanel.ResumeLayout(false);
            this.Trendpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuThinButton2 trendbutton;
        private ns1.BunifuThinButton2 recbutton;
        private ns1.BunifuThinButton2 kidsbutton;
        private System.Windows.Forms.Label cizgi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private ns1.BunifuGradientPanel Trendpanel;
        private ns1.BunifuCustomLabel TrendBookPublisher3;
        private ns1.BunifuCustomLabel TrendBookAuthor3;
        private ns1.BunifuCustomLabel TrendBookName3;
        private ns1.BunifuCustomLabel TrendBookPublisher2;
        private ns1.BunifuCustomLabel TrendBookAuthor2;
        private ns1.BunifuCustomLabel TrendBookName2;
        private ns1.BunifuCustomLabel TrendBookPublisher;
        private ns1.BunifuCustomLabel TrendBookAuthor;
        private ns1.BunifuCustomLabel TrendBookName;
        private System.Windows.Forms.Label firstpageselected;
        private ns1.BunifuFlatButton takeone;
        private ns1.BunifuFlatButton take3;
        private ns1.BunifuFlatButton take2;
    }
}
