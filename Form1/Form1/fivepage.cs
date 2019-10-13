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
    public partial class fivepage : UserControl
    {
        public fivepage()
        {
            InitializeComponent();
        }

        public DataTable FillDataGridView()
        {


            SqlConnection con6 = new SqlConnection("Data Source=DESKTOP-MG1DKSU;Initial Catalog=BookSwap;Integrated Security=True;MultipleActiveResultSets=True");
            if (con6.State == ConnectionState.Closed)
                con6.Open();

            SqlCommand viewbook = new SqlCommand("CREATE VIEW bookview AS SELECT BookName,BookAuthor,BookPublisher,BookYear,BookISBN,SentUser,Available  FROM Books WHERE SentUser = 'qwe' ", con6);
            viewbook.ExecuteNonQuery();
            DataTable dtbl = new DataTable();
            SqlCommand doldur = new SqlCommand(" SELECT BookName,BookAuthor,BookPublisher,BookYear,BookISBN,SentUser,Available  FROM bookview Where SentUser = '" + Form1.Class1.userName + "'", con6);
            SqlDataReader reader = doldur.ExecuteReader();
            dtbl.Load(reader);

            reader.Close();
            SqlCommand deleteview = new SqlCommand("DROP VIEW bookview  ", con6);
            deleteview.ExecuteNonQuery();
            con6.Close();


            return dtbl;



        }

        private void fivepage_Load(object sender, EventArgs e)
        {
           
                dataGridView1.DataSource = FillDataGridView();
            
                       
        }

    }
    }

