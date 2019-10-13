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
    public partial class fourthpage : UserControl
    {

        SqlConnection con6 = new SqlConnection("Data Source=DESKTOP-MG1DKSU;Initial Catalog=BookSwap;Integrated Security=True;MultipleActiveResultSets=True");
        int count = 1;
        public fourthpage()
        {
            InitializeComponent();
            SearchAddBasket.Visible = false;
            
        }

        public void FillDataGridView() {

            if (con6.State==ConnectionState.Closed) 
                con6.Open();

            string Fill = "SELECT BookName,BookAuthor,BookPublisher,BookYear,BookISBN  FROM Books WHERE BookName Like '%" + textBox1.Text + "%' " +
                                                                                                    "OR BookAuthor Like '%" + textBox1.Text + "%'  " +
                                                                                                    "OR BookPublisher Like '%" + textBox1.Text + "%'  " +
                                                                                                    "OR BookYear Like '%" + textBox1.Text + "%' " +
                                                                                                    "OR BookISBN Like '%" + textBox1.Text + "%' INTERSECT SELECT BookName,BookAuthor,BookPublisher,BookYear,BookISBN FROM Books WHERE Available = 'YES'";

            SqlDataAdapter sda = new SqlDataAdapter(Fill, con6);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            con6.Close();


        }





        private void Searchbutton_Click(object sender, EventArgs e)
        {
            try
            {

                FillDataGridView();


            }
            catch
            {
                MessageBox.Show("Somethings Wrong ! ");
            }

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1 )
            {
                searchresultname.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                searchresultauthor.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                searchresultpublisher.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                searchresultyear.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                searchresultısbn.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                SearchAddBasket.Visible = true;
            }
        }

        private void SearchAddBasket_Click(object sender, EventArgs e)
        {

            try
            {
                con6.Open();
                SqlCommand bookcontrol = new SqlCommand("Select count(*) From Basket where Bookname = '" + searchresultname.Text + "'  ", con6);
                SqlCommand bookcontrol2 = new SqlCommand("Select count(*) From Basket  ", con6);
                bool exists = false;
                bool control = false;
                exists = (int)bookcontrol.ExecuteScalar() > 0;
                control = (int)bookcontrol2.ExecuteScalar() == 3;

                string bookcontrol3 = "Select Credit From UserInfo  where Username = '" + Form1.Class1.userName + "'";
                SqlCommand cmd3 = new SqlCommand(bookcontrol3, con6);
                SqlDataReader reader = cmd3.ExecuteReader();
                reader.Read();
                string controlcredit = reader[0].ToString();
                string limit = "0";
                reader.Close();
                con6.Close();
                if (controlcredit == limit)
                {
                    MessageBox.Show("Out of Credits");
                   
                }
                else
                {
                    if (control)
                    {
                        MessageBox.Show("Out of Credits");
                    }
                    else
                    {
                        if (exists)
                        {
                            MessageBox.Show("This book already added  to basket");

                        }
                        else
                        {
                            string AddBasket = "INSERT INTO Basket(Username,Bookname,Bookauthor,Bookpublisher,BookID) VALUES('" + Form1.Class1.userName + "', '" + searchresultname.Text + "', '" + searchresultauthor.Text + "','" + searchresultpublisher.Text + "','" + count + "' )";
                            con6.Open();
                            SqlCommand cmd = new SqlCommand(AddBasket, con6);
                            cmd.ExecuteNonQuery();
                            con6.Close();
                            MessageBox.Show("This book added to basket");
                            count++;
                        }

                    }
                }
            }
            catch
            {
                MessageBox.Show("Somethings Wrong ! ");
            }
           

        }

        
    }
}
