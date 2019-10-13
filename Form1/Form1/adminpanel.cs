using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Form1
{
    public partial class adminpanel : UserControl
    {

        SqlConnection con7 = new SqlConnection("Data Source=DESKTOP-MG1DKSU;Initial Catalog=BookSwap;Integrated Security=True;MultipleActiveResultSets=True");
        
        public adminpanel()
        {
            InitializeComponent();
        }

        public void FillDataGridView()
        {
            button2.Visible = false;
            if (con7.State == ConnectionState.Closed)
                con7.Open();

            string Fill = "SELECT BookName,BookAuthor,BookPublisher,BookYear,BookISBN,SentUser,Available,BookGroup  FROM Books WHERE BookName Like '%" + textBox8.Text + "%' " +
                                                                                                    "OR BookAuthor Like '%" + textBox8.Text + "%'  " +
                                                                                                    "OR BookPublisher Like '%" + textBox8.Text + "%'  " +
                                                                                                    "OR BookYear Like '%" + textBox8.Text + "%' " +
                                                                                                    "OR BookISBN Like '%" + textBox8.Text + "%' OR SentUser Like '%" + textBox8.Text + "%' OR Available Like '%" + textBox8.Text + "%'OR BookGroup Like '%" + textBox8.Text + "%'";

            SqlDataAdapter sda = new SqlDataAdapter(Fill, con7);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            con7.Close();


        }
        public void FillDataGridViewUser()
        {

            if (con7.State == ConnectionState.Closed)
                con7.Open();

            string Fill = "SELECT Username,Password,Email,Cpass,Credit,Address,City,PhoneNumber  FROM UserInfo WHERE Username Like '%" + textBox8.Text + "%' " +
                                                                                                    "OR Email Like '%" + textBox8.Text + "%'  " +
                                                                                                    "OR Address Like '%" + textBox8.Text + "%'  " +
                                                                                                    "OR City Like '%" + textBox8.Text + "%' " +
                                                                                                    "OR PhoneNumber Like '%" + textBox8.Text + "%' ";

            SqlDataAdapter sda = new SqlDataAdapter(Fill, con7);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            con7.Close();


        }


        private void adminpanel_Load(object sender, EventArgs e)
        {
            button2.Visible = false;
            adduser.Visible = false;

        }

        public void searchbutton_Click(object sender, EventArgs e)
        {

            adduser.Visible = false;
            insertButton.Visible = true;
            deleteuser.Visible = false;
            deleteButton.Visible = true;
            


            FillDataGridView();
            label1.Text = "Book Name ";
            label2.Text = "Book Author ";
            label3.Text = "Book Publisher";
            label4.Text = "Book Year";
            label5.Text = "Book ISBN";
            label6.Text = "Sent User";
            label7.Text = "Available";
            label8.Text = "Book Group";


        }

        public void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                textBox9.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();


            }

           
            insertButton.Text = "Update";
            deleteButton.Enabled = true;
            deleteuser.Enabled = true;

        }

        private void insertButton_Click(object sender, EventArgs e)
        {
           
            if (insertButton.Text == "İnsert")
            {
                string AddBasket = "INSERT INTO Books(BookName,BookAuthor,BookPublisher,BookYear,BookISBN,SentUser,Available,BookGroup) VALUES('" + textBox1.Text + "', '" + textBox2.Text + "','" + textBox3.Text + "' ," +
                                                        "'" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "' ,'" + textBox9.Text + "')";
                con7.Open();
                SqlCommand cmd = new SqlCommand(AddBasket, con7);
                cmd.ExecuteNonQuery();
                con7.Close();
                MessageBox.Show("This book added to database");
                FillDataGridView();
                Reset();
            }
            else
            {
                SqlCommand cmd2 = new SqlCommand("UPDATE Books SET BookName=@bookname,BookAuthor=@bookauthor,BookPublisher=@bookpushlisher,BookYear=@bookyear,BookISBN=@bookisbn,SentUser=@sentuser,Available=@available,BookGroup=@bookgroup" +
                    " WHERE Bookname = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "' ", con7);
                con7.Open();
                

                cmd2.Parameters.AddWithValue("@bookname", textBox1.Text);
                cmd2.Parameters.AddWithValue("@bookauthor", textBox2.Text);
                cmd2.Parameters.AddWithValue("@bookpushlisher", textBox3.Text);
                cmd2.Parameters.AddWithValue("@bookyear", textBox4.Text);
                cmd2.Parameters.AddWithValue("@bookisbn", textBox5.Text);
                cmd2.Parameters.AddWithValue("@sentuser", textBox6.Text);
                cmd2.Parameters.AddWithValue("@available", textBox7.Text);
                cmd2.Parameters.AddWithValue("@bookgroup", textBox9.Text);


                cmd2.ExecuteNonQuery();
                con7.Close();
                MessageBox.Show(" Information updated.");
                FillDataGridView();
                Reset();
            }
        }

        void Reset()
        {

            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = textBox9.Text="";
            insertButton.Text = "İnsert";
            deleteButton.Enabled = false;
            deleteuser.Enabled = false;



        }
        private void resetButton_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {

                string cleardata = "DELETE FROM  Books WHERE BookName  = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "' ";
                con7.Open();
                SqlCommand cmdclear = new SqlCommand(cleardata, con7);
                cmdclear.ExecuteNonQuery();
                con7.Close();
                
                MessageBox.Show("Book deleted");
                FillDataGridView();
                Reset();

            }
            catch
            {
                MessageBox.Show("Somethings Wrong ! ");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            insertButton.Visible = false;
            button2.Visible = true;
            adduser.Visible = true;
            deleteButton.Visible = false;
            deleteuser.Visible = true;
           


            FillDataGridViewUser();
            label1.Text = "User Name";
            label2.Text = "E mail";
            label3.Text = "Password";
            label4.Text = "Control Password";
            label5.Text = "Credit";
            label6.Text = "Address";
            label7.Text = "City";
            label8.Text = "Phone Number";

        }

        private void button2_Click(object sender, EventArgs e)
        {


            SqlCommand cmd2 = new SqlCommand("UPDATE UserInfo SET Username=@username,Password=@pass,Email=@mail,Cpass=@cpass,Credit=@credit,Address=@address,City=@city,PhoneNumber=@phonenumber" +
                   " WHERE Username = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "' ", con7);
            con7.Open();


            cmd2.Parameters.AddWithValue("@username", textBox1.Text);
            cmd2.Parameters.AddWithValue("@pass", textBox2.Text);
            cmd2.Parameters.AddWithValue("@mail", textBox3.Text);
            cmd2.Parameters.AddWithValue("@cpass", textBox4.Text);
            cmd2.Parameters.AddWithValue("@credit", textBox5.Text);
            cmd2.Parameters.AddWithValue("@address", textBox6.Text);
            cmd2.Parameters.AddWithValue("@city", textBox7.Text);
            cmd2.Parameters.AddWithValue("@phonenumber", textBox9.Text);


            cmd2.ExecuteNonQuery();
            con7.Close();
            MessageBox.Show(" Information updated.");
            FillDataGridViewUser(); 
            Reset();

        }

        private void adduser_Click(object sender, EventArgs e)
        {
            string AdduserQ = "INSERT INTO UserInfo(Username,Password,Email,Cpass,Credit,Address,City,PhoneNumber) VALUES('" + textBox1.Text + "', '" + textBox2.Text + "','" + textBox3.Text + "' ," +
                                                        "'" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "' ,'" + textBox9.Text + "')";
            con7.Open();
            SqlCommand cmd = new SqlCommand(AdduserQ, con7);
            cmd.ExecuteNonQuery();
            con7.Close();
            MessageBox.Show("This User added to database");
            FillDataGridView();
            Reset();

        }

        private void deleteuser_Click(object sender, EventArgs e)
        {
            string userdelete = "DELETE FROM  UserInfo WHERE Username  = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "' ";
            con7.Open();
            SqlCommand cmdclear = new SqlCommand(userdelete, con7);
            cmdclear.ExecuteNonQuery();
            con7.Close();

            MessageBox.Show("User deleted");
            FillDataGridView();
            Reset();

        }
    }
}
