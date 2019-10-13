namespace Form1
{
    partial class Form1
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtusername = new ns1.BunifuMaterialTextbox();
            this.txtpassword = new ns1.BunifuMaterialTextbox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Log = new ns1.BunifuFlatButton();
            this.Sgın = new ns1.BunifuFlatButton();
            this.exit = new ns1.BunifuFlatButton();
            this.SignPanel = new System.Windows.Forms.Panel();
            this.controlpass = new ns1.BunifuCustomLabel();
            this.txtsignconfrimpass = new ns1.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.Sıgnacceptbutton = new ns1.BunifuThinButton2();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.Terms = new ns1.BunifuCustomLabel();
            this.termscheck = new ns1.BunifuCheckbox();
            this.txtsignemail = new ns1.BunifuMaterialTextbox();
            this.txtsignpass = new ns1.BunifuMaterialTextbox();
            this.txtsignname = new ns1.BunifuMaterialTextbox();
            this.bunifuDragControl1 = new ns1.BunifuDragControl(this.components);
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SignPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(560, 168);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 63);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtusername
            // 
            this.txtusername.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtusername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtusername.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtusername.ForeColor = System.Drawing.Color.White;
            this.txtusername.HintForeColor = System.Drawing.Color.White;
            this.txtusername.HintText = "User Name";
            this.txtusername.isPassword = false;
            this.txtusername.LineFocusedColor = System.Drawing.Color.Aquamarine;
            this.txtusername.LineIdleColor = System.Drawing.Color.Turquoise;
            this.txtusername.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
            this.txtusername.LineThickness = 3;
            this.txtusername.Location = new System.Drawing.Point(470, 280);
            this.txtusername.Margin = new System.Windows.Forms.Padding(4);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(370, 44);
            this.txtusername.TabIndex = 1;
            this.txtusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtpassword.ForeColor = System.Drawing.Color.White;
            this.txtpassword.HintForeColor = System.Drawing.Color.White;
            this.txtpassword.HintText = "Password";
            this.txtpassword.isPassword = true;
            this.txtpassword.LineFocusedColor = System.Drawing.Color.Aquamarine;
            this.txtpassword.LineIdleColor = System.Drawing.Color.Turquoise;
            this.txtpassword.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
            this.txtpassword.LineThickness = 3;
            this.txtpassword.Location = new System.Drawing.Point(470, 362);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(370, 44);
            this.txtpassword.TabIndex = 2;
            this.txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(398, 280);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(398, 362);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(47, 44);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // Log
            // 
            this.Log.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Log.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Log.BorderRadius = 0;
            this.Log.ButtonText = "Log In";
            this.Log.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Log.DisabledColor = System.Drawing.Color.Gray;
            this.Log.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Log.Iconcolor = System.Drawing.Color.Transparent;
            this.Log.Iconimage = null;
            this.Log.Iconimage_right = null;
            this.Log.Iconimage_right_Selected = null;
            this.Log.Iconimage_Selected = null;
            this.Log.IconMarginLeft = 0;
            this.Log.IconMarginRight = 0;
            this.Log.IconRightVisible = true;
            this.Log.IconRightZoom = 0D;
            this.Log.IconVisible = true;
            this.Log.IconZoom = 90D;
            this.Log.IsTab = false;
            this.Log.Location = new System.Drawing.Point(470, 447);
            this.Log.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Log.Name = "Log";
            this.Log.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Log.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Log.OnHoverTextColor = System.Drawing.Color.White;
            this.Log.selected = false;
            this.Log.Size = new System.Drawing.Size(370, 34);
            this.Log.TabIndex = 5;
            this.Log.Text = "Log In";
            this.Log.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Log.Textcolor = System.Drawing.Color.White;
            this.Log.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log.Click += new System.EventHandler(this.Log_Click);
            // 
            // Sgın
            // 
            this.Sgın.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Sgın.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Sgın.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sgın.BorderRadius = 0;
            this.Sgın.ButtonText = "Sign Up";
            this.Sgın.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sgın.DisabledColor = System.Drawing.Color.Gray;
            this.Sgın.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sgın.Iconcolor = System.Drawing.Color.Transparent;
            this.Sgın.Iconimage = null;
            this.Sgın.Iconimage_right = null;
            this.Sgın.Iconimage_right_Selected = null;
            this.Sgın.Iconimage_Selected = null;
            this.Sgın.IconMarginLeft = 0;
            this.Sgın.IconMarginRight = 0;
            this.Sgın.IconRightVisible = true;
            this.Sgın.IconRightZoom = 0D;
            this.Sgın.IconVisible = true;
            this.Sgın.IconZoom = 90D;
            this.Sgın.IsTab = false;
            this.Sgın.Location = new System.Drawing.Point(470, 509);
            this.Sgın.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Sgın.Name = "Sgın";
            this.Sgın.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Sgın.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Sgın.OnHoverTextColor = System.Drawing.Color.White;
            this.Sgın.selected = false;
            this.Sgın.Size = new System.Drawing.Size(370, 34);
            this.Sgın.TabIndex = 6;
            this.Sgın.Text = "Sign Up";
            this.Sgın.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Sgın.Textcolor = System.Drawing.Color.White;
            this.Sgın.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sgın.Click += new System.EventHandler(this.Sgın_Click);
            // 
            // exit
            // 
            this.exit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit.BorderRadius = 0;
            this.exit.ButtonText = "X";
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.DisabledColor = System.Drawing.Color.Gray;
            this.exit.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exit.Iconcolor = System.Drawing.Color.Transparent;
            this.exit.Iconimage = null;
            this.exit.Iconimage_right = null;
            this.exit.Iconimage_right_Selected = null;
            this.exit.Iconimage_Selected = null;
            this.exit.IconMarginLeft = 0;
            this.exit.IconMarginRight = 0;
            this.exit.IconRightVisible = true;
            this.exit.IconRightZoom = 0D;
            this.exit.IconVisible = true;
            this.exit.IconZoom = 90D;
            this.exit.IsTab = false;
            this.exit.Location = new System.Drawing.Point(1250, 6);
            this.exit.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.exit.Name = "exit";
            this.exit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.exit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.exit.OnHoverTextColor = System.Drawing.Color.White;
            this.exit.selected = false;
            this.exit.Size = new System.Drawing.Size(24, 25);
            this.exit.TabIndex = 7;
            this.exit.Text = "X";
            this.exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exit.Textcolor = System.Drawing.Color.White;
            this.exit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // SignPanel
            // 
            this.SignPanel.BackColor = System.Drawing.Color.SeaGreen;
            this.SignPanel.Controls.Add(this.controlpass);
            this.SignPanel.Controls.Add(this.txtsignconfrimpass);
            this.SignPanel.Controls.Add(this.bunifuCustomLabel2);
            this.SignPanel.Controls.Add(this.Sıgnacceptbutton);
            this.SignPanel.Controls.Add(this.bunifuCustomLabel1);
            this.SignPanel.Controls.Add(this.Terms);
            this.SignPanel.Controls.Add(this.termscheck);
            this.SignPanel.Controls.Add(this.txtsignemail);
            this.SignPanel.Controls.Add(this.txtsignpass);
            this.SignPanel.Controls.Add(this.txtsignname);
            this.SignPanel.Location = new System.Drawing.Point(852, 29);
            this.SignPanel.Name = "SignPanel";
            this.SignPanel.Size = new System.Drawing.Size(373, 553);
            this.SignPanel.TabIndex = 8;
            // 
            // controlpass
            // 
            this.controlpass.AutoSize = true;
            this.controlpass.ForeColor = System.Drawing.Color.Firebrick;
            this.controlpass.Location = new System.Drawing.Point(118, 381);
            this.controlpass.Name = "controlpass";
            this.controlpass.Size = new System.Drawing.Size(0, 13);
            this.controlpass.TabIndex = 9;
            // 
            // txtsignconfrimpass
            // 
            this.txtsignconfrimpass.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtsignconfrimpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsignconfrimpass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtsignconfrimpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtsignconfrimpass.HintForeColor = System.Drawing.Color.White;
            this.txtsignconfrimpass.HintText = "Confirm Password";
            this.txtsignconfrimpass.isPassword = false;
            this.txtsignconfrimpass.LineFocusedColor = System.Drawing.Color.Aquamarine;
            this.txtsignconfrimpass.LineIdleColor = System.Drawing.Color.Turquoise;
            this.txtsignconfrimpass.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
            this.txtsignconfrimpass.LineThickness = 3;
            this.txtsignconfrimpass.Location = new System.Drawing.Point(19, 314);
            this.txtsignconfrimpass.Margin = new System.Windows.Forms.Padding(4);
            this.txtsignconfrimpass.Name = "txtsignconfrimpass";
            this.txtsignconfrimpass.Size = new System.Drawing.Size(326, 63);
            this.txtsignconfrimpass.TabIndex = 8;
            this.txtsignconfrimpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(148, 485);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(90, 28);
            this.bunifuCustomLabel2.TabIndex = 7;
            this.bunifuCustomLabel2.Text = "Log In";
            this.bunifuCustomLabel2.Click += new System.EventHandler(this.bunifuCustomLabel2_Click);
            // 
            // Sıgnacceptbutton
            // 
            this.Sıgnacceptbutton.ActiveBorderThickness = 1;
            this.Sıgnacceptbutton.ActiveCornerRadius = 20;
            this.Sıgnacceptbutton.ActiveFillColor = System.Drawing.Color.Aquamarine;
            this.Sıgnacceptbutton.ActiveForecolor = System.Drawing.Color.White;
            this.Sıgnacceptbutton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Sıgnacceptbutton.BackColor = System.Drawing.Color.SeaGreen;
            this.Sıgnacceptbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sıgnacceptbutton.BackgroundImage")));
            this.Sıgnacceptbutton.ButtonText = "Sign up";
            this.Sıgnacceptbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sıgnacceptbutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sıgnacceptbutton.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Sıgnacceptbutton.IdleBorderThickness = 1;
            this.Sıgnacceptbutton.IdleCornerRadius = 20;
            this.Sıgnacceptbutton.IdleFillColor = System.Drawing.Color.White;
            this.Sıgnacceptbutton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.Sıgnacceptbutton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Sıgnacceptbutton.Location = new System.Drawing.Point(96, 433);
            this.Sıgnacceptbutton.Margin = new System.Windows.Forms.Padding(5);
            this.Sıgnacceptbutton.Name = "Sıgnacceptbutton";
            this.Sıgnacceptbutton.Size = new System.Drawing.Size(181, 41);
            this.Sıgnacceptbutton.TabIndex = 6;
            this.Sıgnacceptbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Sıgnacceptbutton.Click += new System.EventHandler(this.Sıgnacceptbutton_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(139, 19);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(109, 28);
            this.bunifuCustomLabel1.TabIndex = 5;
            this.bunifuCustomLabel1.Text = "Sign Up";
            // 
            // Terms
            // 
            this.Terms.AutoSize = true;
            this.Terms.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Terms.Location = new System.Drawing.Point(72, 410);
            this.Terms.Name = "Terms";
            this.Terms.Size = new System.Drawing.Size(236, 18);
            this.Terms.TabIndex = 4;
            this.Terms.Text = "I Accept the Terms and Conditions";
            // 
            // termscheck
            // 
            this.termscheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.termscheck.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.termscheck.Checked = true;
            this.termscheck.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.termscheck.ForeColor = System.Drawing.Color.White;
            this.termscheck.Location = new System.Drawing.Point(46, 410);
            this.termscheck.Name = "termscheck";
            this.termscheck.Size = new System.Drawing.Size(20, 20);
            this.termscheck.TabIndex = 3;
            // 
            // txtsignemail
            // 
            this.txtsignemail.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtsignemail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsignemail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtsignemail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtsignemail.HintForeColor = System.Drawing.Color.White;
            this.txtsignemail.HintText = "Email";
            this.txtsignemail.isPassword = false;
            this.txtsignemail.LineFocusedColor = System.Drawing.Color.Aquamarine;
            this.txtsignemail.LineIdleColor = System.Drawing.Color.Turquoise;
            this.txtsignemail.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
            this.txtsignemail.LineThickness = 3;
            this.txtsignemail.Location = new System.Drawing.Point(19, 149);
            this.txtsignemail.Margin = new System.Windows.Forms.Padding(4);
            this.txtsignemail.Name = "txtsignemail";
            this.txtsignemail.Size = new System.Drawing.Size(326, 62);
            this.txtsignemail.TabIndex = 2;
            this.txtsignemail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtsignemail.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox3_OnValueChanged);
            // 
            // txtsignpass
            // 
            this.txtsignpass.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtsignpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsignpass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtsignpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtsignpass.HintForeColor = System.Drawing.Color.White;
            this.txtsignpass.HintText = "Password";
            this.txtsignpass.isPassword = false;
            this.txtsignpass.LineFocusedColor = System.Drawing.Color.Aquamarine;
            this.txtsignpass.LineIdleColor = System.Drawing.Color.Turquoise;
            this.txtsignpass.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
            this.txtsignpass.LineThickness = 3;
            this.txtsignpass.Location = new System.Drawing.Point(19, 233);
            this.txtsignpass.Margin = new System.Windows.Forms.Padding(4);
            this.txtsignpass.Name = "txtsignpass";
            this.txtsignpass.Size = new System.Drawing.Size(326, 62);
            this.txtsignpass.TabIndex = 1;
            this.txtsignpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtsignname
            // 
            this.txtsignname.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtsignname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsignname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtsignname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtsignname.HintForeColor = System.Drawing.Color.White;
            this.txtsignname.HintText = "User Name";
            this.txtsignname.isPassword = false;
            this.txtsignname.LineFocusedColor = System.Drawing.Color.Aquamarine;
            this.txtsignname.LineIdleColor = System.Drawing.Color.Turquoise;
            this.txtsignname.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
            this.txtsignname.LineThickness = 3;
            this.txtsignname.Location = new System.Drawing.Point(19, 69);
            this.txtsignname.Margin = new System.Windows.Forms.Padding(4);
            this.txtsignname.Name = "txtsignname";
            this.txtsignname.Size = new System.Drawing.Size(326, 62);
            this.txtsignname.TabIndex = 0;
            this.txtsignname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.SignPanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.SignPanel);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.Sgın);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.SignPanel.ResumeLayout(false);
            this.SignPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private ns1.BunifuMaterialTextbox txtusername;
        private ns1.BunifuMaterialTextbox txtpassword;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private ns1.BunifuFlatButton Log;
        private ns1.BunifuFlatButton Sgın;
        private ns1.BunifuFlatButton exit;
        private System.Windows.Forms.Panel SignPanel;
        private ns1.BunifuMaterialTextbox txtsignemail;
        private ns1.BunifuMaterialTextbox txtsignpass;
        private ns1.BunifuMaterialTextbox txtsignname;
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private ns1.BunifuThinButton2 Sıgnacceptbutton;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private ns1.BunifuCustomLabel Terms;
        private ns1.BunifuCheckbox termscheck;
        private ns1.BunifuDragControl bunifuDragControl1;
        private ns1.BunifuCustomLabel controlpass;
        private ns1.BunifuMaterialTextbox txtsignconfrimpass;
        private ns1.BunifuElipse bunifuElipse1;
    }
}

