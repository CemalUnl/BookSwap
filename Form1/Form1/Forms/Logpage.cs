using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Form1
{
    public partial class Form1 : Form
    {

        SqlConnection con2 = new SqlConnection("Data Source=DESKTOP-MG1DKSU;Initial Catalog=BookSwap;Integrated Security=True");

        public static class Class1
        {
            //display user
            public static string userName;
            public static string userCredit;
        }

        public Form1()
        {
            InitializeComponent();
            SignPanel.Visible = false;
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            controlpass.Hide();
            


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {
            SignPanel.Visible = false;
        }

        private void Sgın_Click(object sender, EventArgs e)
        {
            SignPanel.Visible = true ;
        }

        private void Log_Click(object sender, EventArgs e)
        {
           
            string LoginQue = "Select * from UserInfo Where Username = '" + txtusername.Text.Trim() + "' and Password = '" + txtpassword.Text.Trim() + "'";

            SqlDataAdapter sda = new SqlDataAdapter(LoginQue, con2);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                Class1.userName = this.txtusername.Text;//display userinfo
                Main objMain = new Main();
                this.Hide();
                objMain.Show();
               
            }

            else
            {
                MessageBox.Show("Check your username or password");
            }

          
          
        }



        private void Sıgnacceptbutton_Click(object sender, EventArgs e)
        {

            if (txtsignname.Text == "" || txtsignemail.Text == ""|| txtsignpass.Text == "" || txtsignconfrimpass.Text == "")
            {
                MessageBox.Show("All boxes must be filled");
            }
            
            else
            {
                if (termscheck.Checked)
                {
                    if (txtsignpass.Text == txtsignconfrimpass.Text)
                    {
                        con2.Open();

                        bool exists = false;

                        SqlCommand cmd2 = new SqlCommand("Select count(*) From UserInfo where Username = '" + txtsignname.Text + "'", con2);
                        exists = (int)cmd2.ExecuteScalar() > 0;

                        if (exists)
                        {
                            MessageBox.Show("This username has been using by another user.");

                        }

                        else
                        {


                            string SignQue = "INSERT INTO UserInfo(Username,Email,Password,Cpass) VALUES('" + txtsignname.Text + "', '" + txtsignemail.Text + "', '" + txtsignpass.Text + "','" + txtsignconfrimpass.Text + "')";
                            con2.Open();
                            SqlCommand cmd = new SqlCommand(SignQue, con2);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("registered thnx");
                            con2.Close();
                        }
                    }
                    else
                    {
                        controlpass.Show();
                        controlpass.Text = "Password mismatch";
                    }
                }
                else
                {
                    MessageBox.Show("You must accept terms");
                }
            }
        }

        
    }
}
