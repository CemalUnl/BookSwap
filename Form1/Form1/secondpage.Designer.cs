namespace Form1.Forms.Usercontrolsfile
{
    partial class secondpage
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
            this.userInfoEmail = new ns1.BunifuCustomLabel();
            this.userInfoPhone = new ns1.BunifuCustomLabel();
            this.userInfoCity = new ns1.BunifuCustomLabel();
            this.userInfoAddress = new ns1.BunifuCustomLabel();
            this.userInfoPassword = new ns1.BunifuCustomLabel();
            this.bunifuFlatButton1 = new ns1.BunifuFlatButton();
            this.txtuseraddress = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtuseremail = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtuserphone = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtusercity = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtuserpassword = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.SuspendLayout();
            // 
            // userInfoEmail
            // 
            this.userInfoEmail.AutoSize = true;
            this.userInfoEmail.Location = new System.Drawing.Point(153, 129);
            this.userInfoEmail.Name = "userInfoEmail";
            this.userInfoEmail.Size = new System.Drawing.Size(41, 13);
            this.userInfoEmail.TabIndex = 5;
            this.userInfoEmail.Text = "E mail :";
            // 
            // userInfoPhone
            // 
            this.userInfoPhone.AutoSize = true;
            this.userInfoPhone.Location = new System.Drawing.Point(110, 174);
            this.userInfoPhone.Name = "userInfoPhone";
            this.userInfoPhone.Size = new System.Drawing.Size(84, 13);
            this.userInfoPhone.TabIndex = 6;
            this.userInfoPhone.Text = "Phone Number :";
            // 
            // userInfoCity
            // 
            this.userInfoCity.AutoSize = true;
            this.userInfoCity.Location = new System.Drawing.Point(164, 222);
            this.userInfoCity.Name = "userInfoCity";
            this.userInfoCity.Size = new System.Drawing.Size(30, 13);
            this.userInfoCity.TabIndex = 7;
            this.userInfoCity.Text = "City :";
            // 
            // userInfoAddress
            // 
            this.userInfoAddress.AutoSize = true;
            this.userInfoAddress.Location = new System.Drawing.Point(143, 267);
            this.userInfoAddress.Name = "userInfoAddress";
            this.userInfoAddress.Size = new System.Drawing.Size(51, 13);
            this.userInfoAddress.TabIndex = 8;
            this.userInfoAddress.Text = "Address :";
            // 
            // userInfoPassword
            // 
            this.userInfoPassword.AutoSize = true;
            this.userInfoPassword.Location = new System.Drawing.Point(135, 371);
            this.userInfoPassword.Name = "userInfoPassword";
            this.userInfoPassword.Size = new System.Drawing.Size(59, 13);
            this.userInfoPassword.TabIndex = 9;
            this.userInfoPassword.Text = "Password :";
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 5;
            this.bunifuFlatButton1.ButtonText = "Save";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(572, 526);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(241, 48);
            this.bunifuFlatButton1.TabIndex = 10;
            this.bunifuFlatButton1.Text = "Save";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // txtuseraddress
            // 
            this.txtuseraddress.BackColor = System.Drawing.SystemColors.Control;
            this.txtuseraddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtuseraddress.Location = new System.Drawing.Point(233, 267);
            this.txtuseraddress.Multiline = true;
            this.txtuseraddress.Name = "txtuseraddress";
            this.txtuseraddress.Size = new System.Drawing.Size(291, 76);
            this.txtuseraddress.TabIndex = 11;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtuseremail
            // 
            this.txtuseremail.BackColor = System.Drawing.SystemColors.Control;
            this.txtuseremail.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtuseremail.Location = new System.Drawing.Point(233, 122);
            this.txtuseremail.Name = "txtuseremail";
            this.txtuseremail.Size = new System.Drawing.Size(291, 20);
            this.txtuseremail.TabIndex = 13;
            // 
            // txtuserphone
            // 
            this.txtuserphone.BackColor = System.Drawing.SystemColors.Control;
            this.txtuserphone.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtuserphone.Location = new System.Drawing.Point(233, 167);
            this.txtuserphone.Name = "txtuserphone";
            this.txtuserphone.Size = new System.Drawing.Size(291, 20);
            this.txtuserphone.TabIndex = 14;
            // 
            // txtusercity
            // 
            this.txtusercity.BackColor = System.Drawing.SystemColors.Control;
            this.txtusercity.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtusercity.Location = new System.Drawing.Point(233, 215);
            this.txtusercity.Name = "txtusercity";
            this.txtusercity.Size = new System.Drawing.Size(291, 20);
            this.txtusercity.TabIndex = 15;
            // 
            // txtuserpassword
            // 
            this.txtuserpassword.BackColor = System.Drawing.SystemColors.Control;
            this.txtuserpassword.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtuserpassword.Location = new System.Drawing.Point(233, 371);
            this.txtuserpassword.Name = "txtuserpassword";
            this.txtuserpassword.Size = new System.Drawing.Size(291, 20);
            this.txtuserpassword.TabIndex = 16;
            // 
            // secondpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtuserpassword);
            this.Controls.Add(this.txtusercity);
            this.Controls.Add(this.txtuserphone);
            this.Controls.Add(this.txtuseremail);
            this.Controls.Add(this.txtuseraddress);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.userInfoPassword);
            this.Controls.Add(this.userInfoAddress);
            this.Controls.Add(this.userInfoCity);
            this.Controls.Add(this.userInfoPhone);
            this.Controls.Add(this.userInfoEmail);
            this.Name = "secondpage";
            this.Size = new System.Drawing.Size(1000, 650);
            this.Load += new System.EventHandler(this.secondpage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ns1.BunifuCustomLabel userInfoEmail;
        private ns1.BunifuCustomLabel userInfoPhone;
        private ns1.BunifuCustomLabel userInfoCity;
        private ns1.BunifuCustomLabel userInfoAddress;
        private ns1.BunifuCustomLabel userInfoPassword;
        private ns1.BunifuFlatButton bunifuFlatButton1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtuseraddress;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtuseremail;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtuserphone;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtusercity;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtuserpassword;
    }
}
