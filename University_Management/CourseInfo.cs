using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_Management
{
    public partial class CourseInfo : Form
    {
        public CourseInfo()
        {
            InitializeComponent();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Server=ABIRRIFAT\SQLEXPRESS;Database=UM_Database;Integrated Security=true");
            conn.Open();
            //string query = "";
            String query = "SELECT * FROM CourseInfo";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable da = new DataTable();
            sda.Fill(da);
            dgvcourse.DataSource = da;
            conn.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.txtName.Text) || String.IsNullOrEmpty(this.txtCredit.Text))
            {
                MessageBox.Show("Please insert a value", "Message");
            }
            else
            {

                Regex credit;
                credit=new Regex(@"^([0-3]{1})$");

                if (!credit.IsMatch(txtCredit.Text))
                {
                    MessageBox.Show("CourseCredit format is not correct.", "Validation");
                }

                else
                {


                    SqlConnection conn = new SqlConnection(@"Server=ABIRRIFAT\SQLEXPRESS;Database=UM_Database;Integrated Security=true");
                    conn.Open();
                    string query = "";
                    query = "INSERT INTO CourseInfo (CourseName,CourseCredit) VALUES('" + txtName.Text + "','" + txtCredit.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    int result = cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Succesfully Saved", "Message");
                    txtName.Text = "";
                    txtCredit.Text = "";
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Server=ABIRRIFAT\SQLEXPRESS;Database=UM_database;Integrated Security=true");
               // string query = "";
                String query = "DELETE  FROM CourseInfo Where CourseName='" + this.txtName.Text + "';";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader myreader;
                conn.Open();
                myreader = cmd.ExecuteReader();
                MessageBox.Show("Successfully Deleted!!!");
                txtName.Text = "";
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

        private void backBtn_Click(object sender, EventArgs e)
        {
            AdminForm af = new AdminForm();
            af.Show();
            this.Hide();
        }
    }
}
