using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_Management
{
    public partial class StudentRegForm : Form
    {
        public StudentRegForm()
        {
            InitializeComponent();
            FillCombo();
            FillCombo1();
        }

        void FillCombo()
        {
            SqlConnection conn = new SqlConnection(@"Server=ABIRRIFAT\SQLEXPRESS;Database=UM_database;Integrated Security=true");
            string query = "";
            query = "SELECT * FROM [UM_Database].[dbo].[CourseInfo]";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader myreader;
            try
            {
                conn.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    String sName = myreader["CourseName"].ToString();
                    ddlSRCourse.Items.Add(sName);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        void FillCombo1()
        {
            SqlConnection conn = new SqlConnection(@"Server=ABIRRIFAT\SQLEXPRESS;Database=UM_database;Integrated Security=true");
            string query = "";
            query = "SELECT * FROM SectionInfo";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader myreader;
            try
            {
                conn.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    String sName = myreader["ID"].ToString();
                    ddlSRSec.Items.Add(sName);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(this.ddlSRCourse.Text) || String.IsNullOrEmpty(this.ddlSRSec.Text))
            {
                MessageBox.Show("Please insert a value", "Message");
            }
            else
            {
                SqlConnection conn = new SqlConnection(@"Server=ABIRRIFAT\SQLEXPRESS;Database=UM_Database;Integrated Security=true");
                conn.Open();
                string query = "";
                query = "INSERT INTO StudentRegistration (CourseName,SectionID) VALUES('" + ddlSRCourse.Text + "','" + ddlSRSec.Text + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                int result = cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Succesfully Saved", "Message");
                ddlSRCourse.Text = "";
                ddlSRSec.Text = "";
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.txtID.Text))
            {
                MessageBox.Show("Please insert a value", "Message");
            }
            else
            {

                try
                {
                    SqlConnection conn = new SqlConnection(@"Server=ABIRRIFAT\SQLEXPRESS;Database=UM_Database;Integrated Security=true");
                    String query = " ";
                    query = "DELETE FROM StudentRegistration Where ID ='" + Convert.ToInt32(this.txtID.Text) + "';";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader myreader;

                    conn.Open();
                    myreader = cmd.ExecuteReader();
                    MessageBox.Show("Successfully Deleted!!!");
                    txtID.Text = "";
                    while (myreader.Read())
                    {
                    }
                    conn.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Server=ABIRRIFAT\SQLEXPRESS;Database=UM_Database;Integrated Security=true");
            conn.Open();
            //string query = "";
            String query = "SELECT * FROM StudentRegistration";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable da = new DataTable();
            sda.Fill(da);
            dtvsreg.DataSource = da;
            conn.Close();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            StudentForm sf = new StudentForm();
            sf.Show();
            this.Hide();
        }
    }
}
