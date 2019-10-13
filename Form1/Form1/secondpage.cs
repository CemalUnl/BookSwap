using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Form1.Forms.Usercontrolsfile
{
    public partial class secondpage : UserControl
    {
        SqlConnection con4 = new SqlConnection("Data Source=DESKTOP-MG1DKSU;Initial Catalog=BookSwap;Integrated Security=True;MultipleActiveResultSets=True");
        public secondpage()
        {
            InitializeComponent();
           
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

            try
            {

                if (txtuseremail.Text == "" || txtuserphone.Text == "" || txtusercity.Text == "" || txtuseraddress.Text == "" || txtuserpassword.Text == "")
                {
                    MessageBox.Show("All boxes must be filled");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("UPDATE UserInfo SET Email=@email,PhoneNumber=@phone,City=@city,Address=@address,Password=@password WHERE Username= '" + Form1.Class1.userName + "' ", con4);
                    con4.Open();

                    cmd.Parameters.AddWithValue("@email", txtuseremail.Text);
                    cmd.Parameters.AddWithValue("@phone", txtuserphone.Text);
                    cmd.Parameters.AddWithValue("@city", txtusercity.Text);
                    cmd.Parameters.AddWithValue("@address", txtuseraddress.Text);
                    cmd.Parameters.AddWithValue("@password", txtuserpassword.Text);
                    cmd.ExecuteNonQuery();
                    con4.Close();
                    MessageBox.Show("User informations updated.");
                }

            }
            catch
            {
                MessageBox.Show("Somethings wrong !");
            }


        }

        private void secondpage_Load(object sender, EventArgs e)
        {
            con4.Open();
           SqlCommand userview = new SqlCommand("CREATE VIEW UserView AS SELECT Username,Email,PhoneNumber,City,Address,Password  FROM UserInfo WHERE Username= '" + Form1.Class1.userName + "' ", con4);
            userview.ExecuteNonQuery();
            
            SqlCommand doldur = new SqlCommand(" SELECT  Username,Email,PhoneNumber,City,Address,Password  FROM UserView  WHERE Username= '" + Form1.Class1.userName + "' ", con4);
            SqlDataReader reader = doldur.ExecuteReader();
            reader.Read();
            txtuseremail.Text = reader.GetValue(1).ToString();
            txtuserphone.Text = reader.GetValue(2).ToString();
            txtusercity.Text = reader.GetValue(3).ToString();
            txtuseraddress.Text = reader.GetValue(4).ToString();
            txtuserpassword.Text = reader.GetValue(5).ToString();

            reader.Close();
            SqlCommand deleteview = new SqlCommand("DROP VIEW UserView  ", con4);
            deleteview.ExecuteNonQuery();
            con4.Close();
        }
    }
}
