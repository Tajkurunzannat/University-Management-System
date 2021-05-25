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
    public partial class TeacherRegForm : Form
    {
        public TeacherRegForm()
        {
            InitializeComponent();
            FillCombo();
            FillCombo1();
        }

        void FillCombo()
        {
            SqlConnection conn = new SqlConnection(@"Server=ABIRRIFAT\SQLEXPRESS;Database=UM_database;Integrated Security=true");
            string query = "";
            query = "SELECT * FROM CourseInfo";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader myreader;
            try
            {
                conn.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    String sName = myreader["CourseName"].ToString();
                    courseBox.Items.Add(sName);
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
                    sectionBox.Items.Add(sName);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.courseBox.Text) || String.IsNullOrEmpty(this.sectionBox.Text))
            {
                MessageBox.Show("Please insert a value", "Message");
            }
            else
            {
                SqlConnection conn = new SqlConnection(@"Server=ABIRRIFAT\SQLEXPRESS;Database=UM_Database;Integrated Security=true");
                conn.Open();
                string query = "";
                query = "INSERT INTO TeacherRegistration (CourseName,SectionID) VALUES('" + courseBox.Text + "','" + sectionBox.Text + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                int result = cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Succesfully Saved", "Message");
                courseBox.Text = "";
                sectionBox.Text = "";
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
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
                    query = "DELETE FROM TeacherRegistration Where ID ='" + Convert.ToInt32(this.txtID.Text) + "';";
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
            String query = "SELECT * FROM TeacherRegistration";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable da = new DataTable();
            sda.Fill(da);
            dgvtreg.DataSource = da;
            conn.Close();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            TeacherForm tf = new TeacherForm();
            tf.Show();
            this.Hide();
        }
    }
}
