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

namespace Form1.Forms.Usercontrolsfile
{
    public partial class thirdpage : UserControl
    {
        SqlConnection con5 = new SqlConnection("Data Source=DESKTOP-MG1DKSU;Initial Catalog=BookSwap;Integrated Security=True;MultipleActiveResultSets=True");
        public thirdpage()
        {
            InitializeComponent();
            ConfirmBasket.Visible = false;

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


        private void GetBasket_Click(object sender, EventArgs e)
        {
            BasketPanel.Visible = false;
            con5.Open();

            bool exists = false;
            

            SqlCommand basketcontrol = new SqlCommand("Select count(*) From Basket where Username = '" + Form1.Class1.userName + "'  ", con5);
             exists = (int)basketcontrol.ExecuteScalar() == 3;
            


            
                if (exists)
                {

                    BasketPanel.Visible = true;
                    ConfirmBasket.Visible = true;
                    //images
                    string sqlimg1 = "SELECT Books.BookImage FROM Books,Basket WHERE Basket.Username = '" + Form1.Class1.userName + "'  AND Basket.Bookname = Books.BookName AND Basket.BookID = 1";
                    string sqlimg2 = "SELECT Books.BookImage FROM Books,Basket WHERE Basket.Username = '" + Form1.Class1.userName + "' AND Basket.Bookname = Books.BookName AND Basket.BookID = 2";
                    string sqlimg3 = "SELECT Books.BookImage FROM Books,Basket WHERE Basket.Username = '" + Form1.Class1.userName + "' AND Basket.Bookname = Books.BookName AND Basket.BookID = 3";


                    //names
                    string sqlimg1name = "SELECT Bookname FROM  Basket WHERE Username = '" + Form1.Class1.userName + "' AND Basket.BookID= 1";
                    string sqlimg2name = "SELECT Bookname FROM  Basket WHERE Username = '" + Form1.Class1.userName + "' AND Basket.BookID= 2 ";
                    string sqlimg3name = "SELECT Bookname FROM  Basket WHERE Username = '" + Form1.Class1.userName + "' AND Basket.BookID= 3 ";

                    //Author
                    string sqlimg1Author = "SELECT Bookauthor FROM  Basket WHERE Username = '" + Form1.Class1.userName + "' AND Basket.BookID= 1 ";
                    string sqlimg2Author = "SELECT Bookauthor FROM  Basket WHERE Username = '" + Form1.Class1.userName + "' AND Basket.BookID= 2 ";
                    string sqlimg3Author = "SELECT Bookauthor FROM  Basket WHERE Username = '" + Form1.Class1.userName + "' AND Basket.BookID= 3 ";


                    //Publisher
                    string sqlimg1Publish = "SELECT Bookpublisher FROM  Basket WHERE Username = '" + Form1.Class1.userName + "' AND Basket.BookID= 1 ";
                    string sqlimg2Publish = "SELECT Bookpublisher FROM  Basket WHERE Username = '" + Form1.Class1.userName + "' AND Basket.BookID= 2";
                    string sqlimg3Publish = "SELECT Bookpublisher FROM  Basket WHERE Username = '" + Form1.Class1.userName + "' AND Basket.BookID= 3";



                    SqlCommand cmd = new SqlCommand(sqlimg1, con5);
                    SqlCommand cmd2 = new SqlCommand(sqlimg2, con5);
                    SqlCommand cmd3 = new SqlCommand(sqlimg3, con5);


                    SqlCommand cmd4 = new SqlCommand(sqlimg1name, con5);
                    SqlCommand cmd5 = new SqlCommand(sqlimg2name, con5);
                    SqlCommand cmd6 = new SqlCommand(sqlimg3name, con5);

                    SqlCommand cmd7 = new SqlCommand(sqlimg1Author, con5);
                    SqlCommand cmd8 = new SqlCommand(sqlimg2Author, con5);
                    SqlCommand cmd9 = new SqlCommand(sqlimg3Author, con5);

                    SqlCommand cmd10 = new SqlCommand(sqlimg1Publish, con5);
                    SqlCommand cmd11 = new SqlCommand(sqlimg2Publish, con5);
                    SqlCommand cmd12 = new SqlCommand(sqlimg3Publish, con5);



                    pictureBox1.Image = Convert(ReadImage(cmd));
                    pictureBox2.Image = Convert(ReadImage(cmd2));
                    pictureBox3.Image = Convert(ReadImage(cmd3));


                    LabelChange(cmd4, BasketBookName);
                    LabelChange(cmd5, BasketBookName2);
                    LabelChange(cmd6, BasketBookName3);


                    LabelChange(cmd7, BasketBookAuthor);
                    LabelChange(cmd8, BasketBookAuthor2);
                    LabelChange(cmd9, BasketBookAuthor3);


                    LabelChange(cmd10, BasketBookPublisher);
                    LabelChange(cmd11, BasketBookPublisher2);
                    LabelChange(cmd12, BasketBookPublisher3);




                    con5.Close();

                }
                else
                {
                    BasketPanel.Visible = false;
                    con5.Close();
                    MessageBox.Show("You must take 3 book");

                }
            
                

        }



        private void BasketClear_Click(object sender, EventArgs e)
        {
            try
            {

                string clearBasket = "DELETE FROM  Basket WHERE Username = '" + Form1.Class1.userName + "'  ";
                con5.Open();
                SqlCommand cmdclear = new SqlCommand(clearBasket, con5);
                cmdclear.ExecuteNonQuery();
                con5.Close();
                BasketPanel.Visible = false;
                MessageBox.Show("Your Basket cleared");
            }
            catch
            {
                MessageBox.Show("Somethings wrong !");
            }

        }

        private void ConfirmBasket_Click(object sender, EventArgs e)
        {
            BasketPanel.Visible = false;
            con5.Open();

            bool exists = false;

            SqlCommand basketcontrol = new SqlCommand("Select count(*) From Basket where Username = '" + Form1.Class1.userName + "'  ", con5);
            exists = (int)basketcontrol.ExecuteScalar() > 0;


            if (exists)
            {
                SqlCommand cmd = new SqlCommand("UPDATE Books SET TakeUser= '" + Form1.Class1.userName + "' , Available = 'No' FROM Basket,Books WHERE Basket.Bookname=Books.BookName ", con5);
                SqlCommand cmd2 = new SqlCommand("UPDATE Books SET TakeUser= '" + Form1.Class1.userName + "', Available = 'No' FROM Basket,Books WHERE Basket.Bookname=Books.BookName  ", con5);
                SqlCommand clearBasket = new SqlCommand("DELETE FROM  Basket WHERE Username = '" + Form1.Class1.userName + "'  ", con5);
                SqlCommand deletecredit = new SqlCommand("Update UserInfo Set Credit = 0  WHERE Username = '" + Form1.Class1.userName + "'  ", con5);

                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                clearBasket.ExecuteNonQuery();
                deletecredit.ExecuteNonQuery();
                con5.Close();
                MessageBox.Show("Your basket is approved");



            }
            else
            {
                BasketPanel.Visible = false;
                con5.Close();
                MessageBox.Show("Your Basket is empty ?");

            }


        }


    }
}
