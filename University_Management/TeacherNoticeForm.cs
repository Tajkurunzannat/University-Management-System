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
    public partial class TeacherNoticeForm : Form
    {
        public TeacherNoticeForm()
        {
            InitializeComponent();
            FillCombo();
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
                    ddlTNCourse.Items.Add(sName);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.ddlTNCourse.Text) || String.IsNullOrEmpty(this.txtSection.Text) || String.IsNullOrEmpty(this.txtNotice.Text))
            {
                MessageBox.Show("Please insert a value", "Message");
            }
            else
            {
                SqlConnection conn = new SqlConnection(@"Server=ABIRRIFAT\SQLEXPRESS;Database=UM_Database;Integrated Security=true");
                conn.Open();
                string query = "";
                query = "INSERT INTO TeacherNotice (CourseName,SectionName,Notice) VALUES('" + ddlTNCourse.Text + "','" + txtSection.Text + "','" + txtNotice.Text + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                int result = cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Succesfully Saved", "Message");
                ddlTNCourse.Text = "";
                txtSection.Text = "";
                txtNotice.Text = "";
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Server=ABIRRIFAT\SQLEXPRESS;Database=UM_Database;Integrated Security=true");
                String query = " ";
                query = "DELETE FROM TeacherNotice Where NoticeNo ='" + Convert.ToInt32(this.txtID.Text) + "';";
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

        private void viewBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Server=ABIRRIFAT\SQLEXPRESS;Database=UM_Database;Integrated Security=true");
            conn.Open();
            //string query = "";
            String query = "SELECT * FROM TeacherNotice";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable da = new DataTable();
            sda.Fill(da);
            dgvnotice.DataSource = da;
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
