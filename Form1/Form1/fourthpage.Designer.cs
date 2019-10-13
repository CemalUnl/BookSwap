namespace Form1.Forms.Usercontrolsfile
{
    partial class fourthpage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fourthpage));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Searchbutton = new ns1.BunifuThinButton2();
            this.SearchBookName = new ns1.BunifuCustomLabel();
            this.SearchBookAuthor = new ns1.BunifuCustomLabel();
            this.SearchBookPublisher = new ns1.BunifuCustomLabel();
            this.SearchAddBasket = new ns1.BunifuThinButton2();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.searchresultname = new ns1.BunifuCustomLabel();
            this.searchresultauthor = new ns1.BunifuCustomLabel();
            this.searchresultpublisher = new ns1.BunifuCustomLabel();
            this.SearchBookYear = new ns1.BunifuCustomLabel();
            this.searchresultyear = new ns1.BunifuCustomLabel();
            this.SearchBookIsbn = new ns1.BunifuCustomLabel();
            this.searchresultısbn = new ns1.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(443, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 480);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // Searchbutton
            // 
            this.Searchbutton.ActiveBorderThickness = 1;
            this.Searchbutton.ActiveCornerRadius = 20;
            this.Searchbutton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Searchbutton.ActiveForecolor = System.Drawing.Color.White;
            this.Searchbutton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Searchbutton.BackColor = System.Drawing.SystemColors.Control;
            this.Searchbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Searchbutton.BackgroundImage")));
            this.Searchbutton.ButtonText = "Search";
            this.Searchbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Searchbutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchbutton.ForeColor = System.Drawing.Color.SeaGreen;
            this.Searchbutton.IdleBorderThickness = 1;
            this.Searchbutton.IdleCornerRadius = 20;
            this.Searchbutton.IdleFillColor = System.Drawing.Color.White;
            this.Searchbutton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.Searchbutton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Searchbutton.Location = new System.Drawing.Point(363, 50);
            this.Searchbutton.Margin = new System.Windows.Forms.Padding(5);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.Size = new System.Drawing.Size(72, 50);
            this.Searchbutton.TabIndex = 2;
            this.Searchbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Searchbutton.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // SearchBookName
            // 
            this.SearchBookName.AutoSize = true;
            this.SearchBookName.Location = new System.Drawing.Point(18, 166);
            this.SearchBookName.Name = "SearchBookName";
            this.SearchBookName.Size = new System.Drawing.Size(87, 13);
            this.SearchBookName.TabIndex = 3;
            this.SearchBookName.Text = "Book Name       :";
            // 
            // SearchBookAuthor
            // 
            this.SearchBookAuthor.AutoSize = true;
            this.SearchBookAuthor.Location = new System.Drawing.Point(18, 211);
            this.SearchBookAuthor.Name = "SearchBookAuthor";
            this.SearchBookAuthor.Size = new System.Drawing.Size(87, 13);
            this.SearchBookAuthor.TabIndex = 4;
            this.SearchBookAuthor.Text = "Book Author      :";
            // 
            // SearchBookPublisher
            // 
            this.SearchBookPublisher.AutoSize = true;
            this.SearchBookPublisher.Location = new System.Drawing.Point(18, 259);
            this.SearchBookPublisher.Name = "SearchBookPublisher";
            this.SearchBookPublisher.Size = new System.Drawing.Size(87, 13);
            this.SearchBookPublisher.TabIndex = 5;
            this.SearchBookPublisher.Text = "Book Publisher  :";
            // 
            // SearchAddBasket
            // 
            this.SearchAddBasket.ActiveBorderThickness = 1;
            this.SearchAddBasket.ActiveCornerRadius = 20;
            this.SearchAddBasket.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.SearchAddBasket.ActiveForecolor = System.Drawing.Color.White;
            this.SearchAddBasket.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.SearchAddBasket.BackColor = System.Drawing.SystemColors.Control;
            this.SearchAddBasket.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchAddBasket.BackgroundImage")));
            this.SearchAddBasket.ButtonText = "Add Basket";
            this.SearchAddBasket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchAddBasket.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchAddBasket.ForeColor = System.Drawing.Color.SeaGreen;
            this.SearchAddBasket.IdleBorderThickness = 1;
            this.SearchAddBasket.IdleCornerRadius = 20;
            this.SearchAddBasket.IdleFillColor = System.Drawing.Color.White;
            this.SearchAddBasket.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.SearchAddBasket.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.SearchAddBasket.Location = new System.Drawing.Point(130, 415);
            this.SearchAddBasket.Margin = new System.Windows.Forms.Padding(5);
            this.SearchAddBasket.Name = "SearchAddBasket";
            this.SearchAddBasket.Size = new System.Drawing.Size(118, 74);
            this.SearchAddBasket.TabIndex = 6;
            this.SearchAddBasket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SearchAddBasket.Click += new System.EventHandler(this.SearchAddBasket_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(309, 20);
            this.textBox1.TabIndex = 7;
            // 
            // searchresultname
            // 
            this.searchresultname.AutoSize = true;
            this.searchresultname.Location = new System.Drawing.Point(127, 166);
            this.searchresultname.Name = "searchresultname";
            this.searchresultname.Size = new System.Drawing.Size(0, 13);
            this.searchresultname.TabIndex = 8;
            // 
            // searchresultauthor
            // 
            this.searchresultauthor.AutoSize = true;
            this.searchresultauthor.Location = new System.Drawing.Point(127, 211);
            this.searchresultauthor.Name = "searchresultauthor";
            this.searchresultauthor.Size = new System.Drawing.Size(0, 13);
            this.searchresultauthor.TabIndex = 9;
            // 
            // searchresultpublisher
            // 
            this.searchresultpublisher.AutoSize = true;
            this.searchresultpublisher.Location = new System.Drawing.Point(127, 259);
            this.searchresultpublisher.Name = "searchresultpublisher";
            this.searchresultpublisher.Size = new System.Drawing.Size(0, 13);
            this.searchresultpublisher.TabIndex = 10;
            // 
            // SearchBookYear
            // 
            this.SearchBookYear.AutoSize = true;
            this.SearchBookYear.Location = new System.Drawing.Point(18, 304);
            this.SearchBookYear.Name = "SearchBookYear";
            this.SearchBookYear.Size = new System.Drawing.Size(84, 13);
            this.SearchBookYear.TabIndex = 11;
            this.SearchBookYear.Text = "Book Year        :";
            // 
            // searchresultyear
            // 
            this.searchresultyear.AutoSize = true;
            this.searchresultyear.Location = new System.Drawing.Point(127, 304);
            this.searchresultyear.Name = "searchresultyear";
            this.searchresultyear.Size = new System.Drawing.Size(0, 13);
            this.searchresultyear.TabIndex = 12;
            // 
            // SearchBookIsbn
            // 
            this.SearchBookIsbn.AutoSize = true;
            this.SearchBookIsbn.Location = new System.Drawing.Point(18, 344);
            this.SearchBookIsbn.Name = "SearchBookIsbn";
            this.SearchBookIsbn.Size = new System.Drawing.Size(87, 13);
            this.SearchBookIsbn.TabIndex = 13;
            this.SearchBookIsbn.Text = "Book ISBN        :";
            // 
            // searchresultısbn
            // 
            this.searchresultısbn.AutoSize = true;
            this.searchresultısbn.Location = new System.Drawing.Point(127, 344);
            this.searchresultısbn.Name = "searchresultısbn";
            this.searchresultısbn.Size = new System.Drawing.Size(0, 13);
            this.searchresultısbn.TabIndex = 14;
            // 
            // fourthpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchresultısbn);
            this.Controls.Add(this.SearchBookIsbn);
            this.Controls.Add(this.searchresultyear);
            this.Controls.Add(this.SearchBookYear);
            this.Controls.Add(this.searchresultpublisher);
            this.Controls.Add(this.searchresultauthor);
            this.Controls.Add(this.searchresultname);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SearchAddBasket);
            this.Controls.Add(this.SearchBookPublisher);
            this.Controls.Add(this.SearchBookAuthor);
            this.Controls.Add(this.SearchBookName);
            this.Controls.Add(this.Searchbutton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "fourthpage";
            this.Size = new System.Drawing.Size(1000, 650);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ns1.BunifuThinButton2 Searchbutton;
        private ns1.BunifuCustomLabel SearchBookName;
        private ns1.BunifuCustomLabel SearchBookAuthor;
        private ns1.BunifuCustomLabel SearchBookPublisher;
        private ns1.BunifuThinButton2 SearchAddBasket;
        private System.Windows.Forms.TextBox textBox1;
        private ns1.BunifuCustomLabel searchresultname;
        private ns1.BunifuCustomLabel searchresultauthor;
        private ns1.BunifuCustomLabel searchresultpublisher;
        private ns1.BunifuCustomLabel SearchBookYear;
        private ns1.BunifuCustomLabel searchresultyear;
        private ns1.BunifuCustomLabel SearchBookIsbn;
        private ns1.BunifuCustomLabel searchresultısbn;
    }
}
