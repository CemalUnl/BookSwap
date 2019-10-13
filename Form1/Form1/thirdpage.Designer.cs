namespace Form1.Forms.Usercontrolsfile
{
    partial class thirdpage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(thirdpage));
            this.GetBasket = new ns1.BunifuFlatButton();
            this.BasketClear = new ns1.BunifuFlatButton();
            this.BasketPanel = new ns1.BunifuGradientPanel();
            this.BasketBookPublisher3 = new ns1.BunifuCustomLabel();
            this.BasketBookAuthor3 = new ns1.BunifuCustomLabel();
            this.BasketBookName3 = new ns1.BunifuCustomLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.BasketBookPublisher2 = new ns1.BunifuCustomLabel();
            this.BasketBookAuthor2 = new ns1.BunifuCustomLabel();
            this.BasketBookName2 = new ns1.BunifuCustomLabel();
            this.BasketBookPublisher = new ns1.BunifuCustomLabel();
            this.BasketBookAuthor = new ns1.BunifuCustomLabel();
            this.BasketBookName = new ns1.BunifuCustomLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ConfirmBasket = new ns1.BunifuFlatButton();
            this.BasketPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GetBasket
            // 
            this.GetBasket.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.GetBasket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.GetBasket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GetBasket.BorderRadius = 5;
            this.GetBasket.ButtonText = "Get Basket";
            this.GetBasket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GetBasket.DisabledColor = System.Drawing.Color.Gray;
            this.GetBasket.Iconcolor = System.Drawing.Color.Transparent;
            this.GetBasket.Iconimage = null;
            this.GetBasket.Iconimage_right = null;
            this.GetBasket.Iconimage_right_Selected = null;
            this.GetBasket.Iconimage_Selected = null;
            this.GetBasket.IconMarginLeft = 0;
            this.GetBasket.IconMarginRight = 0;
            this.GetBasket.IconRightVisible = true;
            this.GetBasket.IconRightZoom = 0D;
            this.GetBasket.IconVisible = true;
            this.GetBasket.IconZoom = 90D;
            this.GetBasket.IsTab = false;
            this.GetBasket.Location = new System.Drawing.Point(335, 536);
            this.GetBasket.Name = "GetBasket";
            this.GetBasket.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.GetBasket.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.GetBasket.OnHoverTextColor = System.Drawing.Color.White;
            this.GetBasket.selected = false;
            this.GetBasket.Size = new System.Drawing.Size(180, 46);
            this.GetBasket.TabIndex = 26;
            this.GetBasket.Text = "Get Basket";
            this.GetBasket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GetBasket.Textcolor = System.Drawing.Color.White;
            this.GetBasket.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetBasket.Click += new System.EventHandler(this.GetBasket_Click);
            // 
            // BasketClear
            // 
            this.BasketClear.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BasketClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BasketClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BasketClear.BorderRadius = 5;
            this.BasketClear.ButtonText = "Clear Basket";
            this.BasketClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BasketClear.DisabledColor = System.Drawing.Color.Gray;
            this.BasketClear.Iconcolor = System.Drawing.Color.Transparent;
            this.BasketClear.Iconimage = null;
            this.BasketClear.Iconimage_right = null;
            this.BasketClear.Iconimage_right_Selected = null;
            this.BasketClear.Iconimage_Selected = null;
            this.BasketClear.IconMarginLeft = 0;
            this.BasketClear.IconMarginRight = 0;
            this.BasketClear.IconRightVisible = true;
            this.BasketClear.IconRightZoom = 0D;
            this.BasketClear.IconVisible = true;
            this.BasketClear.IconZoom = 90D;
            this.BasketClear.IsTab = false;
            this.BasketClear.Location = new System.Drawing.Point(788, 536);
            this.BasketClear.Name = "BasketClear";
            this.BasketClear.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BasketClear.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BasketClear.OnHoverTextColor = System.Drawing.Color.White;
            this.BasketClear.selected = false;
            this.BasketClear.Size = new System.Drawing.Size(180, 46);
            this.BasketClear.TabIndex = 25;
            this.BasketClear.Text = "Clear Basket";
            this.BasketClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BasketClear.Textcolor = System.Drawing.Color.White;
            this.BasketClear.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BasketClear.Click += new System.EventHandler(this.BasketClear_Click);
            // 
            // BasketPanel
            // 
            this.BasketPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BasketPanel.BackgroundImage")));
            this.BasketPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BasketPanel.Controls.Add(this.BasketBookPublisher3);
            this.BasketPanel.Controls.Add(this.BasketBookAuthor3);
            this.BasketPanel.Controls.Add(this.BasketBookName3);
            this.BasketPanel.Controls.Add(this.pictureBox3);
            this.BasketPanel.Controls.Add(this.BasketBookPublisher2);
            this.BasketPanel.Controls.Add(this.BasketBookAuthor2);
            this.BasketPanel.Controls.Add(this.BasketBookName2);
            this.BasketPanel.Controls.Add(this.BasketBookPublisher);
            this.BasketPanel.Controls.Add(this.BasketBookAuthor);
            this.BasketPanel.Controls.Add(this.BasketBookName);
            this.BasketPanel.Controls.Add(this.pictureBox2);
            this.BasketPanel.Controls.Add(this.pictureBox1);
            this.BasketPanel.GradientBottomLeft = System.Drawing.Color.White;
            this.BasketPanel.GradientBottomRight = System.Drawing.Color.White;
            this.BasketPanel.GradientTopLeft = System.Drawing.Color.White;
            this.BasketPanel.GradientTopRight = System.Drawing.Color.White;
            this.BasketPanel.Location = new System.Drawing.Point(0, 0);
            this.BasketPanel.Name = "BasketPanel";
            this.BasketPanel.Quality = 10;
            this.BasketPanel.Size = new System.Drawing.Size(1000, 520);
            this.BasketPanel.TabIndex = 27;
            
            // 
            // BasketBookPublisher3
            // 
            this.BasketBookPublisher3.AutoSize = true;
            this.BasketBookPublisher3.ForeColor = System.Drawing.Color.Black;
            this.BasketBookPublisher3.Location = new System.Drawing.Point(748, 376);
            this.BasketBookPublisher3.Name = "BasketBookPublisher3";
            this.BasketBookPublisher3.Size = new System.Drawing.Size(0, 13);
            this.BasketBookPublisher3.TabIndex = 36;
            // 
            // BasketBookAuthor3
            // 
            this.BasketBookAuthor3.AutoSize = true;
            this.BasketBookAuthor3.ForeColor = System.Drawing.Color.Black;
            this.BasketBookAuthor3.Location = new System.Drawing.Point(748, 334);
            this.BasketBookAuthor3.Name = "BasketBookAuthor3";
            this.BasketBookAuthor3.Size = new System.Drawing.Size(0, 13);
            this.BasketBookAuthor3.TabIndex = 35;
            // 
            // BasketBookName3
            // 
            this.BasketBookName3.AutoSize = true;
            this.BasketBookName3.ForeColor = System.Drawing.Color.Black;
            this.BasketBookName3.Location = new System.Drawing.Point(748, 287);
            this.BasketBookName3.Name = "BasketBookName3";
            this.BasketBookName3.Size = new System.Drawing.Size(0, 13);
            this.BasketBookName3.TabIndex = 34;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Location = new System.Drawing.Point(705, 60);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(180, 180);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 33;
            this.pictureBox3.TabStop = false;
            // 
            // BasketBookPublisher2
            // 
            this.BasketBookPublisher2.AutoSize = true;
            this.BasketBookPublisher2.ForeColor = System.Drawing.Color.Black;
            this.BasketBookPublisher2.Location = new System.Drawing.Point(441, 376);
            this.BasketBookPublisher2.Name = "BasketBookPublisher2";
            this.BasketBookPublisher2.Size = new System.Drawing.Size(0, 13);
            this.BasketBookPublisher2.TabIndex = 32;
            // 
            // BasketBookAuthor2
            // 
            this.BasketBookAuthor2.AutoSize = true;
            this.BasketBookAuthor2.ForeColor = System.Drawing.Color.Black;
            this.BasketBookAuthor2.Location = new System.Drawing.Point(441, 334);
            this.BasketBookAuthor2.Name = "BasketBookAuthor2";
            this.BasketBookAuthor2.Size = new System.Drawing.Size(0, 13);
            this.BasketBookAuthor2.TabIndex = 31;
            // 
            // BasketBookName2
            // 
            this.BasketBookName2.AutoSize = true;
            this.BasketBookName2.ForeColor = System.Drawing.Color.Black;
            this.BasketBookName2.Location = new System.Drawing.Point(441, 287);
            this.BasketBookName2.Name = "BasketBookName2";
            this.BasketBookName2.Size = new System.Drawing.Size(0, 13);
            this.BasketBookName2.TabIndex = 30;
            // 
            // BasketBookPublisher
            // 
            this.BasketBookPublisher.AutoSize = true;
            this.BasketBookPublisher.ForeColor = System.Drawing.Color.Black;
            this.BasketBookPublisher.Location = new System.Drawing.Point(149, 376);
            this.BasketBookPublisher.Name = "BasketBookPublisher";
            this.BasketBookPublisher.Size = new System.Drawing.Size(0, 13);
            this.BasketBookPublisher.TabIndex = 29;
            // 
            // BasketBookAuthor
            // 
            this.BasketBookAuthor.AutoSize = true;
            this.BasketBookAuthor.ForeColor = System.Drawing.Color.Black;
            this.BasketBookAuthor.Location = new System.Drawing.Point(149, 334);
            this.BasketBookAuthor.Name = "BasketBookAuthor";
            this.BasketBookAuthor.Size = new System.Drawing.Size(0, 13);
            this.BasketBookAuthor.TabIndex = 28;
            // 
            // BasketBookName
            // 
            this.BasketBookName.AutoSize = true;
            this.BasketBookName.ForeColor = System.Drawing.Color.Black;
            this.BasketBookName.Location = new System.Drawing.Point(149, 287);
            this.BasketBookName.Name = "BasketBookName";
            this.BasketBookName.Size = new System.Drawing.Size(0, 13);
            this.BasketBookName.TabIndex = 27;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(410, 60);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(180, 180);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(115, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // ConfirmBasket
            // 
            this.ConfirmBasket.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ConfirmBasket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ConfirmBasket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ConfirmBasket.BorderRadius = 5;
            this.ConfirmBasket.ButtonText = "Confirm Basket";
            this.ConfirmBasket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConfirmBasket.DisabledColor = System.Drawing.Color.Gray;
            this.ConfirmBasket.Iconcolor = System.Drawing.Color.Transparent;
            this.ConfirmBasket.Iconimage = null;
            this.ConfirmBasket.Iconimage_right = null;
            this.ConfirmBasket.Iconimage_right_Selected = null;
            this.ConfirmBasket.Iconimage_Selected = null;
            this.ConfirmBasket.IconMarginLeft = 0;
            this.ConfirmBasket.IconMarginRight = 0;
            this.ConfirmBasket.IconRightVisible = true;
            this.ConfirmBasket.IconRightZoom = 0D;
            this.ConfirmBasket.IconVisible = true;
            this.ConfirmBasket.IconZoom = 90D;
            this.ConfirmBasket.IsTab = false;
            this.ConfirmBasket.Location = new System.Drawing.Point(563, 536);
            this.ConfirmBasket.Name = "ConfirmBasket";
            this.ConfirmBasket.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ConfirmBasket.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.ConfirmBasket.OnHoverTextColor = System.Drawing.Color.White;
            this.ConfirmBasket.selected = false;
            this.ConfirmBasket.Size = new System.Drawing.Size(180, 46);
            this.ConfirmBasket.TabIndex = 28;
            this.ConfirmBasket.Text = "Confirm Basket";
            this.ConfirmBasket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ConfirmBasket.Textcolor = System.Drawing.Color.White;
            this.ConfirmBasket.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmBasket.Click += new System.EventHandler(this.ConfirmBasket_Click);
            // 
            // thirdpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ConfirmBasket);
            this.Controls.Add(this.BasketPanel);
            this.Controls.Add(this.GetBasket);
            this.Controls.Add(this.BasketClear);
            this.Name = "thirdpage";
            this.Size = new System.Drawing.Size(1000, 650);
            
            this.BasketPanel.ResumeLayout(false);
            this.BasketPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ns1.BunifuFlatButton GetBasket;
        private ns1.BunifuFlatButton BasketClear;
        private ns1.BunifuGradientPanel BasketPanel;
        private ns1.BunifuCustomLabel BasketBookPublisher2;
        private ns1.BunifuCustomLabel BasketBookAuthor2;
        private ns1.BunifuCustomLabel BasketBookName2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ns1.BunifuFlatButton ConfirmBasket;
        private ns1.BunifuCustomLabel BasketBookPublisher3;
        private ns1.BunifuCustomLabel BasketBookAuthor3;
        private ns1.BunifuCustomLabel BasketBookName3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private ns1.BunifuCustomLabel BasketBookPublisher;
        private ns1.BunifuCustomLabel BasketBookAuthor;
        private ns1.BunifuCustomLabel BasketBookName;
    }
}
