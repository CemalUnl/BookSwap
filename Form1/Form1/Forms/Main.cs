using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Form1
{
    public partial class Main : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-MG1DKSU;Initial Catalog=BookSwap;Integrated Security=True;MultipleActiveResultSets=True");

        public Main()
        {

            InitializeComponent();

            //menü bar location
            SidePanel.Height = buttonhome.Height;
            SidePanel.Top = buttonhome.Top;
            firstpage1.BringToFront();
            this.mainUsername.Text = string.Format("{0} ", Form1.Class1.userName);//display username
            credit();


            string AdminControl = "Select * from UserInfo U ,Admins A Where U.Username ='" + Form1.Class1.userName + "' and A.AdminLogName = '" + Form1.Class1.userName + "'";

            SqlDataAdapter sda = new SqlDataAdapter(AdminControl, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {

                FaqButton.Visible = true;

            }
            else
            {
                FaqButton.Visible = false;
            }


        }

        public void credit()
        {
            //display credit
            string sqlimg1 = "SELECT Credit FROM UserInfo WHERE Username =  '" + Form1.Class1.userName + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlimg1, con);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            creditlabel.Text = reader[0].ToString();
            reader.Close();
            con.Close();

        }

        private void CreditIcon_Click(object sender, EventArgs e)
        {
            credit();

        }


        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void buttonhome_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buttonhome.Height;
            SidePanel.Top = buttonhome.Top;
            firstpage1.BringToFront();
            credit();


        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = InfoButton.Height;
            SidePanel.Top = InfoButton.Top;
            secondpage1.BringToFront();
            credit();

        }

       

        

        private void BasketButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = BasketButton.Height;
            SidePanel.Top = BasketButton.Top;
            thirdpage1.BringToFront();
            credit();

        }

        private void SearchMain_Click(object sender, EventArgs e)
        {

            SidePanel.Height = SearchMain.Height;
            SidePanel.Top = SearchMain.Top;
            fourthpage1.BringToFront();
            credit();

        }

        private void ReceivButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = ReceivButton.Height;
            SidePanel.Top = ReceivButton.Top;
            fivepage1.BringToFront();
        }

        private void FaqButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = FaqButton.Height;
            SidePanel.Top = FaqButton.Top;
            adminpanel1.BringToFront();


        }
    }
}
