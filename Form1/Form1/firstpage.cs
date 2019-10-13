using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Form1.Usercontrolsfile
{
    public partial class Add : UserControl
    {
        SqlConnection con3 = new SqlConnection("Data Source=DESKTOP-MG1DKSU;Initial Catalog=BookSwap;Integrated Security=True;MultipleActiveResultSets=True");

        public Add()
        {
            InitializeComponent();
            
            

            
        }

        private void firstpage_Load(object sender, EventArgs e)
        {
            Trendpanel.Visible = true;

            //ilk sayfada trendleri gösterir
            trendbutton_Click(trendbutton, EventArgs.Empty);

        }

        //convert binarytoimage
        Image Convert(byte[] data)
        {

            using (MemoryStream ms = new MemoryStream(data))
            {


                return Image.FromStream(ms);
            }

        }

        //reader to img for call(convert(image))
        Byte[] ReadImage(SqlCommand cmd)
        {

            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            byte[] img = (byte[])(reader[0]);

            reader.Close();
            return img;

        }
        //Label change
        public void LabelChange(SqlCommand cmd, Label name)
        {


            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            name.Text = reader[0].ToString();


        }

        public void trendbutton_Click(object sender, EventArgs e)

        {
            // hangi sayfada olduğunu gösteren ince cizgi
            firstpageselected.Location = new Point(180, 95);
            firstpageselected.Size = new Size(50, 2);

            //images
            string sqlimg1 = "SELECT BookImage FROM Books WHERE BookGroup = 'Trend'  ";
            string sqlimg2 = "SELECT BookImage FROM Books WHERE BookGroup = 'Trend2' ";
            string sqlimg3 = "SELECT BookImage FROM Books WHERE BookGroup = 'Trend3' ";

            //names
            string sqlimg1name = "SELECT BookName FROM Books WHERE BookGroup = 'Trend' ";
            string sqlimg2name = "SELECT BookName FROM Books WHERE BookGroup = 'Trend2' ";
            string sqlimg3name = "SELECT BookName FROM Books WHERE BookGroup = 'Trend3' ";

            //Author
            string sqlimg1Author = "SELECT BookAuthor FROM Books WHERE BookGroup = 'Trend' ";
            string sqlimg2Author = "SELECT BookAuthor FROM Books WHERE BookGroup = 'Trend2' ";
            string sqlimg3Author = "SELECT BookAuthor FROM Books WHERE BookGroup = 'Trend3' ";

            //Publisher
            string sqlimg1Publish = "SELECT BookPublisher FROM Books WHERE BookGroup = 'Trend' ";
            string sqlimg2Publish = "SELECT BookPublisher FROM Books WHERE BookGroup = 'Trend2' ";
            string sqlimg3Publish = "SELECT BookPublisher FROM Books WHERE BookGroup = 'Trend3' ";

            con3.Open();
            SqlCommand cmd = new SqlCommand(sqlimg1, con3);
            SqlCommand cmd2 = new SqlCommand(sqlimg2, con3);
            SqlCommand cmd3 = new SqlCommand(sqlimg3, con3);

            SqlCommand cmd4 = new SqlCommand(sqlimg1name, con3);
            SqlCommand cmd5 = new SqlCommand(sqlimg2name, con3);
            SqlCommand cmd6 = new SqlCommand(sqlimg3name, con3);

            SqlCommand cmd7 = new SqlCommand(sqlimg1Author, con3);
            SqlCommand cmd8 = new SqlCommand(sqlimg2Author, con3);
            SqlCommand cmd9 = new SqlCommand(sqlimg3Author, con3);

            SqlCommand cmd10 = new SqlCommand(sqlimg1Publish, con3);
            SqlCommand cmd11 = new SqlCommand(sqlimg2Publish, con3);
            SqlCommand cmd12 = new SqlCommand(sqlimg3Publish, con3);


            pictureBox1.Image = Convert(ReadImage(cmd));
            pictureBox2.Image = Convert(ReadImage(cmd2));
            pictureBox3.Image = Convert(ReadImage(cmd3));

            LabelChange(cmd4, TrendBookName);
            LabelChange(cmd5, TrendBookName2);
            LabelChange(cmd6, TrendBookName3);

            LabelChange(cmd7, TrendBookAuthor);
            LabelChange(cmd8, TrendBookAuthor2);
            LabelChange(cmd9, TrendBookAuthor3);

            LabelChange(cmd10, TrendBookPublisher);
            LabelChange(cmd11, TrendBookPublisher2);
            LabelChange(cmd12, TrendBookPublisher3);

            con3.Close();

        }

        private void kidsbutton_Click(object sender, EventArgs e)
        {
            // hangi sayfada olduğunu gösteren ince cizgi
            firstpageselected.Location = new Point(765, 95);
            firstpageselected.Size = new Size(60,2);

            //images
            string sqlimg1 = "SELECT BookImage FROM Books WHERE BookGroup = 'Forkid'  ";
            string sqlimg2 = "SELECT BookImage FROM Books WHERE BookGroup = 'Forkid2' ";
            string sqlimg3 = "SELECT BookImage FROM Books WHERE BookGroup = 'Forkid3' ";

            //names
            string sqlimg1name = "SELECT BookName FROM Books WHERE BookGroup = 'Forkid' ";
            string sqlimg2name = "SELECT BookName FROM Books WHERE BookGroup = 'Forkid2' ";
            string sqlimg3name = "SELECT BookName FROM Books WHERE BookGroup = 'Forkid3' ";

            //Author
            string sqlimg1Author = "SELECT BookAuthor FROM Books WHERE BookGroup = 'Forkid' ";
            string sqlimg2Author = "SELECT BookAuthor FROM Books WHERE BookGroup = 'Forkid2' ";
            string sqlimg3Author = "SELECT BookAuthor FROM Books WHERE BookGroup = 'Forkid3' ";

            //Publisher
            string sqlimg1Publish = "SELECT BookPublisher FROM Books WHERE BookGroup = 'Forkid' ";
            string sqlimg2Publish = "SELECT BookPublisher FROM Books WHERE BookGroup = 'Forkid2' ";
            string sqlimg3Publish = "SELECT BookPublisher FROM Books WHERE BookGroup = 'Forkid3' ";

            con3.Open();
            SqlCommand cmd = new SqlCommand(sqlimg1, con3);
            SqlCommand cmd2 = new SqlCommand(sqlimg2, con3);
            SqlCommand cmd3 = new SqlCommand(sqlimg3, con3);

            SqlCommand cmd4 = new SqlCommand(sqlimg1name, con3);
            SqlCommand cmd5 = new SqlCommand(sqlimg2name, con3);
            SqlCommand cmd6 = new SqlCommand(sqlimg3name, con3);

            SqlCommand cmd7 = new SqlCommand(sqlimg1Author, con3);
            SqlCommand cmd8 = new SqlCommand(sqlimg2Author, con3);
            SqlCommand cmd9 = new SqlCommand(sqlimg3Author, con3);

            SqlCommand cmd10 = new SqlCommand(sqlimg1Publish, con3);
            SqlCommand cmd11 = new SqlCommand(sqlimg2Publish, con3);
            SqlCommand cmd12 = new SqlCommand(sqlimg3Publish, con3);


            pictureBox1.Image = Convert(ReadImage(cmd));
            pictureBox2.Image = Convert(ReadImage(cmd2));
            pictureBox3.Image = Convert(ReadImage(cmd3));

            LabelChange(cmd4, TrendBookName);
            LabelChange(cmd5, TrendBookName2);
            LabelChange(cmd6, TrendBookName3);

            LabelChange(cmd7, TrendBookAuthor);
            LabelChange(cmd8, TrendBookAuthor2);
            LabelChange(cmd9, TrendBookAuthor3);

            LabelChange(cmd10, TrendBookPublisher);
            LabelChange(cmd11, TrendBookPublisher2);
            LabelChange(cmd12, TrendBookPublisher3);

            con3.Close();

        }

               

        private void recbutton_Click(object sender, EventArgs e)
        {
            // hangi sayfada olduğunu gösteren ince cizgi
            firstpageselected.Location = new Point(445, 95);
            firstpageselected.Size = new Size(108, 2);

            string sqlimg1 = "SELECT BookImage FROM Books WHERE BookGroup = 'Recomend'  ";
            string sqlimg2 = "SELECT BookImage FROM Books WHERE BookGroup = 'Recomend2' ";
            string sqlimg3 = "SELECT BookImage FROM Books WHERE BookGroup = 'Recomend3' ";

            //names
            string sqlimg1name = "SELECT BookName FROM Books WHERE BookGroup = 'Recomend' ";
            string sqlimg2name = "SELECT BookName FROM Books WHERE BookGroup = 'Recomend2' ";
            string sqlimg3name = "SELECT BookName FROM Books WHERE BookGroup = 'Recomend3' ";

            //Author
            string sqlimg1Author = "SELECT BookAuthor FROM Books WHERE BookGroup = 'Recomend' ";
            string sqlimg2Author = "SELECT BookAuthor FROM Books WHERE BookGroup = 'Recomend2' ";
            string sqlimg3Author = "SELECT BookAuthor FROM Books WHERE BookGroup = 'Recomend3' ";

            //Publisher
            string sqlimg1Publish = "SELECT BookPublisher FROM Books WHERE BookGroup = 'Recomend' ";
            string sqlimg2Publish = "SELECT BookPublisher FROM Books WHERE BookGroup = 'Recomend2' ";
            string sqlimg3Publish = "SELECT BookPublisher FROM Books WHERE BookGroup = 'Recomend3' ";

            con3.Open();
            SqlCommand cmd = new SqlCommand(sqlimg1, con3);
            SqlCommand cmd2 = new SqlCommand(sqlimg2, con3);
            SqlCommand cmd3 = new SqlCommand(sqlimg3, con3);

            SqlCommand cmd4 = new SqlCommand(sqlimg1name, con3);
            SqlCommand cmd5 = new SqlCommand(sqlimg2name, con3);
            SqlCommand cmd6 = new SqlCommand(sqlimg3name, con3);

            SqlCommand cmd7 = new SqlCommand(sqlimg1Author, con3);
            SqlCommand cmd8 = new SqlCommand(sqlimg2Author, con3);
            SqlCommand cmd9 = new SqlCommand(sqlimg3Author, con3);

            SqlCommand cmd10 = new SqlCommand(sqlimg1Publish, con3);
            SqlCommand cmd11 = new SqlCommand(sqlimg2Publish, con3);
            SqlCommand cmd12 = new SqlCommand(sqlimg3Publish, con3);

            pictureBox1.Image = Convert(ReadImage(cmd));
            pictureBox2.Image = Convert(ReadImage(cmd3));
            pictureBox3.Image = Convert(ReadImage(cmd2));

            LabelChange(cmd4, TrendBookName);
            LabelChange(cmd5, TrendBookName2);
            LabelChange(cmd6, TrendBookName3);

            LabelChange(cmd7, TrendBookAuthor);
            LabelChange(cmd8, TrendBookAuthor2);
            LabelChange(cmd9, TrendBookAuthor3);

            LabelChange(cmd10, TrendBookPublisher);
            LabelChange(cmd11, TrendBookPublisher2);
            LabelChange(cmd12, TrendBookPublisher3);

            con3.Close();
        }

        private void takeone_Click(object sender, EventArgs e)
        {
            try
            {
                con3.Open();
                SqlCommand bookcontrol = new SqlCommand("Select count(*) From Basket where Bookname = '" + TrendBookName.Text + "'  ", con3);
                SqlCommand bookcontrol2 = new SqlCommand("Select count(*) From Basket  ", con3);
                bool exists = false;
                bool control = false;
                exists = (int)bookcontrol.ExecuteScalar() > 0;
                control = (int)bookcontrol2.ExecuteScalar() == 3;

                string bookcontrol3 = "Select Credit From UserInfo   where Username = '" + Form1.Class1.userName + "'";
                SqlCommand cmd3 = new SqlCommand(bookcontrol3, con3);
                SqlDataReader reader = cmd3.ExecuteReader();
                reader.Read();
                string controlcredit = reader[0].ToString();
                string limit = "0";
                reader.Close();

                con3.Close();
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
                            string AddBasket = "INSERT INTO Basket(Username,Bookname,Bookauthor,Bookpublisher,BookID) VALUES('" + Form1.Class1.userName + "', '" + TrendBookName.Text + "', '" + TrendBookAuthor.Text + "','" + TrendBookPublisher.Text + "' ,'1')";
                            con3.Open();
                            SqlCommand cmd = new SqlCommand(AddBasket, con3);
                            cmd.ExecuteNonQuery();
                            con3.Close();
                            MessageBox.Show("This book added to basket");
                        }

                    }

                }
              

            }
            catch
            {
                MessageBox.Show("Somethings wrong !");
            }
            


           
        }

        private void take2_Click(object sender, EventArgs e)
        {
            try
            {
                con3.Open();
                SqlCommand bookcontrol = new SqlCommand("Select count(*) From Basket where Bookname = '" + TrendBookName2.Text + "'  ", con3);
                SqlCommand bookcontrol2 = new SqlCommand("Select count(*) From Basket  ", con3);
                bool exists = false;
                bool control = false;
                exists = (int)bookcontrol.ExecuteScalar() > 0;
                control = (int)bookcontrol2.ExecuteScalar() == 3;

                string bookcontrol3 = "Select Credit From UserInfo  where Username = '" + Form1.Class1.userName + "'";
                SqlCommand cmd3 = new SqlCommand(bookcontrol3, con3);
                SqlDataReader reader = cmd3.ExecuteReader();
                reader.Read();
                string controlcredit = reader[0].ToString();
                string limit = "0";
                reader.Close();

                con3.Close();

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
                            string AddBasket = "INSERT INTO Basket(Username,Bookname,Bookauthor,Bookpublisher,BookID) VALUES('" + Form1.Class1.userName + "', '" + TrendBookName2.Text + "', '" + TrendBookAuthor2.Text + "','" + TrendBookPublisher2.Text + "', '2')";
                            con3.Open();
                            SqlCommand cmd = new SqlCommand(AddBasket, con3);
                            cmd.ExecuteNonQuery();
                            con3.Close();
                            MessageBox.Show("This book added to basket");
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Somethings wrong !");
            }

        }

        private void take3_Click(object sender, EventArgs e)
        {
            try
            {
                con3.Open();
                SqlCommand bookcontrol = new SqlCommand("Select count(*) From Basket where Bookname = '" + TrendBookName3.Text + "'  ", con3);
                SqlCommand bookcontrol2 = new SqlCommand("Select count(*) From Basket  ", con3);
                bool exists = false;
                bool control = false;
                exists = (int)bookcontrol.ExecuteScalar() > 0;
                control = (int)bookcontrol2.ExecuteScalar() == 3;

                string bookcontrol3 = "Select Credit From UserInfo  where Username = '" + Form1.Class1.userName + "'";
                SqlCommand cmd3 = new SqlCommand(bookcontrol3, con3);
                SqlDataReader reader = cmd3.ExecuteReader();
                reader.Read();
                string controlcredit = reader[0].ToString();
                string limit = "0";
                reader.Close();

                con3.Close();

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
                            string AddBasket = "INSERT INTO Basket(Username,Bookname,Bookauthor,Bookpublisher,BookID) VALUES('" + Form1.Class1.userName + "', '" + TrendBookName3.Text + "', '" + TrendBookAuthor3.Text + "','" + TrendBookPublisher3.Text + "','3')";
                            con3.Open();
                            SqlCommand cmd = new SqlCommand(AddBasket, con3);
                            cmd.ExecuteNonQuery();
                            con3.Close();
                            MessageBox.Show("This book added to basket");
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Somethings wrong !");
            }
        }
        
    }
}
