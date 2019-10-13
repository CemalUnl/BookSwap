namespace Form1
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.mainexit = new ns1.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainUsername = new System.Windows.Forms.Label();
            this.CreditIcon = new System.Windows.Forms.PictureBox();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.creditlabel = new System.Windows.Forms.Label();
            this.UserIcon = new System.Windows.Forms.PictureBox();
            this.buttonhome = new ns1.BunifuFlatButton();
            this.FaqButton = new ns1.BunifuFlatButton();
            this.ReceivButton = new ns1.BunifuFlatButton();
            this.SearchMain = new ns1.BunifuFlatButton();
            this.BasketButton = new ns1.BunifuFlatButton();
            this.InfoButton = new ns1.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ExitButton = new ns1.BunifuFlatButton();
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new ns1.BunifuGradientPanel();
            this.adminpanel1 = new adminpanel();
            this.fivepage1 = new fivepage();
            this.fourthpage1 = new Forms.Usercontrolsfile.fourthpage();
            this.thirdpage1 = new Forms.Usercontrolsfile.thirdpage();
            this.secondpage1 = new Forms.Usercontrolsfile.secondpage();
            this.firstpage1 = new Usercontrolsfile.Add();
            this.bunifuDragControl1 = new ns1.BunifuDragControl(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CreditIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserIcon)).BeginInit();
            this.panel2.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainexit
            // 
            this.mainexit.Location = new System.Drawing.Point(0, 0);
            this.mainexit.Name = "mainexit";
            this.mainexit.Size = new System.Drawing.Size(100, 23);
            this.mainexit.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.mainUsername);
            this.panel1.Controls.Add(this.CreditIcon);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.creditlabel);
            this.panel1.Controls.Add(this.UserIcon);
            this.panel1.Controls.Add(this.buttonhome);
            this.panel1.Controls.Add(this.FaqButton);
            this.panel1.Controls.Add(this.ReceivButton);
            this.panel1.Controls.Add(this.SearchMain);
            this.panel1.Controls.Add(this.BasketButton);
            this.panel1.Controls.Add(this.InfoButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 720);
            this.panel1.TabIndex = 1;
            // 
            // mainUsername
            // 
            this.mainUsername.AutoSize = true;
            this.mainUsername.Font = new System.Drawing.Font("Bookman Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mainUsername.ForeColor = System.Drawing.Color.White;
            this.mainUsername.Location = new System.Drawing.Point(58, 23);
            this.mainUsername.Name = "mainUsername";
            this.mainUsername.Size = new System.Drawing.Size(62, 19);
            this.mainUsername.TabIndex = 7;
            this.mainUsername.Text = "label1";
            // 
            // CreditIcon
            // 
            this.CreditIcon.Image = ((System.Drawing.Image)(resources.GetObject("CreditIcon.Image")));
            this.CreditIcon.Location = new System.Drawing.Point(12, 58);
            this.CreditIcon.Name = "CreditIcon";
            this.CreditIcon.Size = new System.Drawing.Size(40, 40);
            this.CreditIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CreditIcon.TabIndex = 10;
            this.CreditIcon.TabStop = false;
            this.CreditIcon.Click += new System.EventHandler(this.CreditIcon_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.SidePanel.Location = new System.Drawing.Point(0, 120);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(15, 80);
            this.SidePanel.TabIndex = 3;
            // 
            // creditlabel
            // 
            this.creditlabel.AutoSize = true;
            this.creditlabel.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.creditlabel.ForeColor = System.Drawing.Color.White;
            this.creditlabel.Location = new System.Drawing.Point(58, 70);
            this.creditlabel.Name = "creditlabel";
            this.creditlabel.Size = new System.Drawing.Size(57, 19);
            this.creditlabel.TabIndex = 8;
            this.creditlabel.Text = "label1";
            // 
            // UserIcon
            // 
            this.UserIcon.ErrorImage = ((System.Drawing.Image)(resources.GetObject("UserIcon.ErrorImage")));
            this.UserIcon.Image = ((System.Drawing.Image)(resources.GetObject("UserIcon.Image")));
            this.UserIcon.Location = new System.Drawing.Point(12, 12);
            this.UserIcon.Name = "UserIcon";
            this.UserIcon.Size = new System.Drawing.Size(40, 40);
            this.UserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UserIcon.TabIndex = 9;
            this.UserIcon.TabStop = false;
            // 
            // buttonhome
            // 
            this.buttonhome.Activecolor = System.Drawing.Color.Transparent;
            this.buttonhome.BackColor = System.Drawing.Color.Transparent;
            this.buttonhome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonhome.BorderRadius = 0;
            this.buttonhome.ButtonText = "    Home";
            this.buttonhome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonhome.DisabledColor = System.Drawing.Color.Gray;
            this.buttonhome.ForeColor = System.Drawing.Color.White;
            this.buttonhome.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonhome.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonhome.Iconimage")));
            this.buttonhome.Iconimage_right = null;
            this.buttonhome.Iconimage_right_Selected = null;
            this.buttonhome.Iconimage_Selected = null;
            this.buttonhome.IconMarginLeft = 0;
            this.buttonhome.IconMarginRight = 0;
            this.buttonhome.IconRightVisible = true;
            this.buttonhome.IconRightZoom = 0D;
            this.buttonhome.IconVisible = true;
            this.buttonhome.IconZoom = 90D;
            this.buttonhome.IsTab = false;
            this.buttonhome.Location = new System.Drawing.Point(0, 120);
            this.buttonhome.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.buttonhome.Name = "buttonhome";
            this.buttonhome.Normalcolor = System.Drawing.Color.Transparent;
            this.buttonhome.OnHovercolor = System.Drawing.Color.Transparent;
            this.buttonhome.OnHoverTextColor = System.Drawing.SystemColors.Window;
            this.buttonhome.selected = false;
            this.buttonhome.Size = new System.Drawing.Size(280, 80);
            this.buttonhome.TabIndex = 6;
            this.buttonhome.Text = "    Home";
            this.buttonhome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonhome.Textcolor = System.Drawing.Color.White;
            this.buttonhome.TextFont = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonhome.Click += new System.EventHandler(this.buttonhome_Click);
            // 
            // FaqButton
            // 
            this.FaqButton.Activecolor = System.Drawing.Color.Transparent;
            this.FaqButton.BackColor = System.Drawing.Color.Transparent;
            this.FaqButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FaqButton.BorderRadius = 0;
            this.FaqButton.ButtonText = "    Admin Panel";
            this.FaqButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FaqButton.DisabledColor = System.Drawing.Color.Gray;
            this.FaqButton.ForeColor = System.Drawing.Color.White;
            this.FaqButton.Iconcolor = System.Drawing.Color.Transparent;
            this.FaqButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("FaqButton.Iconimage")));
            this.FaqButton.Iconimage_right = null;
            this.FaqButton.Iconimage_right_Selected = null;
            this.FaqButton.Iconimage_Selected = null;
            this.FaqButton.IconMarginLeft = 0;
            this.FaqButton.IconMarginRight = 0;
            this.FaqButton.IconRightVisible = true;
            this.FaqButton.IconRightZoom = 0D;
            this.FaqButton.IconVisible = true;
            this.FaqButton.IconZoom = 90D;
            this.FaqButton.IsTab = false;
            this.FaqButton.Location = new System.Drawing.Point(0, 520);
            this.FaqButton.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.FaqButton.Name = "FaqButton";
            this.FaqButton.Normalcolor = System.Drawing.Color.Transparent;
            this.FaqButton.OnHovercolor = System.Drawing.Color.Transparent;
            this.FaqButton.OnHoverTextColor = System.Drawing.Color.White;
            this.FaqButton.selected = false;
            this.FaqButton.Size = new System.Drawing.Size(280, 80);
            this.FaqButton.TabIndex = 4;
            this.FaqButton.Text = "    Admin Panel";
            this.FaqButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FaqButton.Textcolor = System.Drawing.Color.White;
            this.FaqButton.TextFont = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FaqButton.Click += new System.EventHandler(this.FaqButton_Click);
            // 
            // ReceivButton
            // 
            this.ReceivButton.Activecolor = System.Drawing.Color.Transparent;
            this.ReceivButton.BackColor = System.Drawing.Color.Transparent;
            this.ReceivButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReceivButton.BorderRadius = 0;
            this.ReceivButton.ButtonText = "    Received Books";
            this.ReceivButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReceivButton.DisabledColor = System.Drawing.Color.Gray;
            this.ReceivButton.ForeColor = System.Drawing.Color.White;
            this.ReceivButton.Iconcolor = System.Drawing.Color.Transparent;
            this.ReceivButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("ReceivButton.Iconimage")));
            this.ReceivButton.Iconimage_right = null;
            this.ReceivButton.Iconimage_right_Selected = null;
            this.ReceivButton.Iconimage_Selected = null;
            this.ReceivButton.IconMarginLeft = 0;
            this.ReceivButton.IconMarginRight = 0;
            this.ReceivButton.IconRightVisible = true;
            this.ReceivButton.IconRightZoom = 0D;
            this.ReceivButton.IconVisible = true;
            this.ReceivButton.IconZoom = 90D;
            this.ReceivButton.IsTab = false;
            this.ReceivButton.Location = new System.Drawing.Point(0, 440);
            this.ReceivButton.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.ReceivButton.Name = "ReceivButton";
            this.ReceivButton.Normalcolor = System.Drawing.Color.Transparent;
            this.ReceivButton.OnHovercolor = System.Drawing.Color.Transparent;
            this.ReceivButton.OnHoverTextColor = System.Drawing.Color.White;
            this.ReceivButton.selected = false;
            this.ReceivButton.Size = new System.Drawing.Size(280, 80);
            this.ReceivButton.TabIndex = 3;
            this.ReceivButton.Text = "    Received Books";
            this.ReceivButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReceivButton.Textcolor = System.Drawing.Color.White;
            this.ReceivButton.TextFont = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ReceivButton.Click += new System.EventHandler(this.ReceivButton_Click);
            // 
            // SearchMain
            // 
            this.SearchMain.Activecolor = System.Drawing.Color.Transparent;
            this.SearchMain.BackColor = System.Drawing.Color.Transparent;
            this.SearchMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchMain.BorderRadius = 0;
            this.SearchMain.ButtonText = "    Search";
            this.SearchMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchMain.DisabledColor = System.Drawing.Color.Gray;
            this.SearchMain.ForeColor = System.Drawing.Color.White;
            this.SearchMain.Iconcolor = System.Drawing.Color.Transparent;
            this.SearchMain.Iconimage = ((System.Drawing.Image)(resources.GetObject("SearchMain.Iconimage")));
            this.SearchMain.Iconimage_right = null;
            this.SearchMain.Iconimage_right_Selected = null;
            this.SearchMain.Iconimage_Selected = null;
            this.SearchMain.IconMarginLeft = 0;
            this.SearchMain.IconMarginRight = 0;
            this.SearchMain.IconRightVisible = true;
            this.SearchMain.IconRightZoom = 0D;
            this.SearchMain.IconVisible = true;
            this.SearchMain.IconZoom = 90D;
            this.SearchMain.IsTab = false;
            this.SearchMain.Location = new System.Drawing.Point(0, 360);
            this.SearchMain.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.SearchMain.Name = "SearchMain";
            this.SearchMain.Normalcolor = System.Drawing.Color.Transparent;
            this.SearchMain.OnHovercolor = System.Drawing.Color.Transparent;
            this.SearchMain.OnHoverTextColor = System.Drawing.Color.White;
            this.SearchMain.selected = false;
            this.SearchMain.Size = new System.Drawing.Size(280, 80);
            this.SearchMain.TabIndex = 3;
            this.SearchMain.Text = "    Search";
            this.SearchMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchMain.Textcolor = System.Drawing.Color.White;
            this.SearchMain.TextFont = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SearchMain.Click += new System.EventHandler(this.SearchMain_Click);
            // 
            // BasketButton
            // 
            this.BasketButton.Activecolor = System.Drawing.Color.Transparent;
            this.BasketButton.BackColor = System.Drawing.Color.Transparent;
            this.BasketButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BasketButton.BorderRadius = 0;
            this.BasketButton.ButtonText = "    Basket";
            this.BasketButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BasketButton.DisabledColor = System.Drawing.Color.Gray;
            this.BasketButton.ForeColor = System.Drawing.Color.White;
            this.BasketButton.Iconcolor = System.Drawing.Color.Transparent;
            this.BasketButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("BasketButton.Iconimage")));
            this.BasketButton.Iconimage_right = null;
            this.BasketButton.Iconimage_right_Selected = null;
            this.BasketButton.Iconimage_Selected = null;
            this.BasketButton.IconMarginLeft = 0;
            this.BasketButton.IconMarginRight = 0;
            this.BasketButton.IconRightVisible = true;
            this.BasketButton.IconRightZoom = 0D;
            this.BasketButton.IconVisible = true;
            this.BasketButton.IconZoom = 90D;
            this.BasketButton.IsTab = false;
            this.BasketButton.Location = new System.Drawing.Point(0, 280);
            this.BasketButton.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.BasketButton.Name = "BasketButton";
            this.BasketButton.Normalcolor = System.Drawing.Color.Transparent;
            this.BasketButton.OnHovercolor = System.Drawing.Color.Transparent;
            this.BasketButton.OnHoverTextColor = System.Drawing.Color.White;
            this.BasketButton.selected = false;
            this.BasketButton.Size = new System.Drawing.Size(280, 80);
            this.BasketButton.TabIndex = 3;
            this.BasketButton.Text = "    Basket";
            this.BasketButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BasketButton.Textcolor = System.Drawing.Color.White;
            this.BasketButton.TextFont = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BasketButton.Click += new System.EventHandler(this.BasketButton_Click);
            // 
            // InfoButton
            // 
            this.InfoButton.Activecolor = System.Drawing.Color.Transparent;
            this.InfoButton.BackColor = System.Drawing.Color.Transparent;
            this.InfoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.InfoButton.BorderRadius = 0;
            this.InfoButton.ButtonText = "    User Information";
            this.InfoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InfoButton.DisabledColor = System.Drawing.Color.Gray;
            this.InfoButton.ForeColor = System.Drawing.Color.White;
            this.InfoButton.Iconcolor = System.Drawing.Color.Transparent;
            this.InfoButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("InfoButton.Iconimage")));
            this.InfoButton.Iconimage_right = null;
            this.InfoButton.Iconimage_right_Selected = null;
            this.InfoButton.Iconimage_Selected = null;
            this.InfoButton.IconMarginLeft = 0;
            this.InfoButton.IconMarginRight = 0;
            this.InfoButton.IconRightVisible = true;
            this.InfoButton.IconRightZoom = 0D;
            this.InfoButton.IconVisible = true;
            this.InfoButton.IconZoom = 90D;
            this.InfoButton.IsTab = false;
            this.InfoButton.Location = new System.Drawing.Point(0, 200);
            this.InfoButton.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Normalcolor = System.Drawing.Color.Transparent;
            this.InfoButton.OnHovercolor = System.Drawing.Color.Transparent;
            this.InfoButton.OnHoverTextColor = System.Drawing.Color.White;
            this.InfoButton.selected = false;
            this.InfoButton.Size = new System.Drawing.Size(280, 80);
            this.InfoButton.TabIndex = 0;
            this.InfoButton.Text = "    User Information";
            this.InfoButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InfoButton.Textcolor = System.Drawing.Color.White;
            this.InfoButton.TextFont = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Controls.Add(this.ExitButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(280, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 70);
            this.panel2.TabIndex = 2;
            // 
            // ExitButton
            // 
            this.ExitButton.Activecolor = System.Drawing.Color.Transparent;
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitButton.BackgroundImage")));
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitButton.BorderRadius = 0;
            this.ExitButton.ButtonText = "";
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.DisabledColor = System.Drawing.Color.Gray;
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Iconcolor = System.Drawing.Color.Transparent;
            this.ExitButton.Iconimage = null;
            this.ExitButton.Iconimage_right = null;
            this.ExitButton.Iconimage_right_Selected = null;
            this.ExitButton.Iconimage_Selected = null;
            this.ExitButton.IconMarginLeft = 0;
            this.ExitButton.IconMarginRight = 0;
            this.ExitButton.IconRightVisible = true;
            this.ExitButton.IconRightZoom = 0D;
            this.ExitButton.IconVisible = true;
            this.ExitButton.IconZoom = 90D;
            this.ExitButton.IsTab = false;
            this.ExitButton.Location = new System.Drawing.Point(947, 8);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Normalcolor = System.Drawing.Color.Transparent;
            this.ExitButton.OnHovercolor = System.Drawing.Color.Transparent;
            this.ExitButton.OnHoverTextColor = System.Drawing.Color.White;
            this.ExitButton.selected = false;
            this.ExitButton.Size = new System.Drawing.Size(35, 33);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ExitButton.Textcolor = System.Drawing.Color.White;
            this.ExitButton.TextFont = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.adminpanel1);
            this.bunifuGradientPanel1.Controls.Add(this.fivepage1);
            this.bunifuGradientPanel1.Controls.Add(this.fourthpage1);
            this.bunifuGradientPanel1.Controls.Add(this.thirdpage1);
            this.bunifuGradientPanel1.Controls.Add(this.secondpage1);
            this.bunifuGradientPanel1.Controls.Add(this.firstpage1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(280, 70);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1000, 650);
            this.bunifuGradientPanel1.TabIndex = 4;
            // 
            // adminpanel1
            // 
            this.adminpanel1.Location = new System.Drawing.Point(0, 0);
            this.adminpanel1.Name = "adminpanel1";
            this.adminpanel1.Size = new System.Drawing.Size(1000, 650);
            this.adminpanel1.TabIndex = 5;
            // 
            // fivepage1
            // 
            this.fivepage1.Location = new System.Drawing.Point(0, 0);
            this.fivepage1.Name = "fivepage1";
            this.fivepage1.Size = new System.Drawing.Size(1000, 650);
            this.fivepage1.TabIndex = 4;
            // 
            // fourthpage1
            // 
            this.fourthpage1.Location = new System.Drawing.Point(0, 0);
            this.fourthpage1.Name = "fourthpage1";
            this.fourthpage1.Size = new System.Drawing.Size(1000, 650);
            this.fourthpage1.TabIndex = 3;
            // 
            // thirdpage1
            // 
            this.thirdpage1.Location = new System.Drawing.Point(0, 0);
            this.thirdpage1.Name = "thirdpage1";
            this.thirdpage1.Size = new System.Drawing.Size(1000, 650);
            this.thirdpage1.TabIndex = 2;
            // 
            // secondpage1
            // 
            this.secondpage1.Location = new System.Drawing.Point(0, 0);
            this.secondpage1.Name = "secondpage1";
            this.secondpage1.Size = new System.Drawing.Size(1000, 650);
            this.secondpage1.TabIndex = 1;
            // 
            // firstpage1
            // 
            this.firstpage1.BackColor = System.Drawing.Color.Transparent;
            this.firstpage1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.firstpage1.Location = new System.Drawing.Point(0, 0);
            this.firstpage1.Name = "firstpage1";
            this.firstpage1.Size = new System.Drawing.Size(1000, 650);
            this.firstpage1.TabIndex = 0;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel2;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainexit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CreditIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserIcon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuCustomLabel mainexit;
        private System.Windows.Forms.Panel panel1;
        private ns1.BunifuFlatButton InfoButton;
        private System.Windows.Forms.Panel panel2;
        private ns1.BunifuFlatButton FaqButton;
        private ns1.BunifuFlatButton ReceivButton;
        private ns1.BunifuFlatButton SearchMain;
        private ns1.BunifuFlatButton BasketButton;
        private System.Windows.Forms.Panel SidePanel;
        private ns1.BunifuFlatButton ExitButton;
        private ns1.BunifuElipse bunifuElipse1;
        private ns1.BunifuFlatButton buttonhome;
        private ns1.BunifuGradientPanel bunifuGradientPanel1;
        private Usercontrolsfile.Add firstpage1;
        private Forms.Usercontrolsfile.secondpage secondpage1;
        private ns1.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label mainUsername;
        private System.Windows.Forms.Label creditlabel;
        private System.Windows.Forms.PictureBox CreditIcon;
        private System.Windows.Forms.PictureBox UserIcon;
        private Forms.Usercontrolsfile.thirdpage thirdpage1;
        private Forms.Usercontrolsfile.fourthpage fourthpage1;
        private fivepage fivepage1;
        private adminpanel adminpanel1;
    }
}