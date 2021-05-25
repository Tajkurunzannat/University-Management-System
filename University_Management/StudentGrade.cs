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
    public partial class StudentGrade : Form
    {
        public StudentGrade()
        {
            InitializeComponent();
            FillCombo();
            FillCombo1();
        }

        void FillCombo()
        {
            SqlConnection conn = new SqlConnection(@"Server=ABIRRIFAT\SQLEXPRESS;Database=UM_database;Integrated Security=true");
            string query = "";
            query = "SELECT * FROM [dbo].[StudentInf]";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader myreader;
            try
            {
                conn.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    String sName = myreader["ID"].ToString();
                    ddlID.Items.Add(sName);
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
                    cmbCourse.Items.Add(sName);
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

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.ddlID.Text) || String.IsNullOrEmpty(this.cmbCourse.Text) || String.IsNullOrEmpty(this.txtMid.Text) || String.IsNullOrEmpty(this.txtFinal.Text))
            {
                MessageBox.Show("Please insert a value", "Message");
            }
            else
            {
                int mid = Convert.ToInt32(txtMid.Text);
                int final = Convert.ToInt32(txtFinal.Text);

                if(mid>40 || final> 60)
                {
                    MessageBox.Show("Invalid input");
                }
                else
                {
                    int total = mid + final;
                    txtTotal.Text = Convert.ToString(total);

                    SqlConnection conn = new SqlConnection(@"Server=ABIRRIFAT\SQLEXPRESS;Database=UM_Database;Integrated Security=true");
                    conn.Open();
                    string query = "";
                    query = "INSERT INTO Grade_Marks (StudentID,CourseName,Mid,Final,Total) VALUES('" + ddlID.Text + "','" + cmbCourse.Text + "','" + Convert.ToInt32(txtMid.Text) + "','" + Convert.ToInt32(txtFinal.Text) + "','" + Convert.ToInt32(txtTotal.Text) + "')";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    int result = cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Succesfully Saved", "Message");
                    ddlID.Text = "";
                    cmbCourse.Text = "";
                    txtMid.Text = "";
                    txtFinal.Text = "";
                    txtTotal.Text = "";
                }


              
            }
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(@"Server=ABIRRIFAT\SQLEXPRESS;Database=UM_Database;Integrated Security=true");
            conn.Open();
            //string query = "";
            String query = "SELECT * FROM Grade_Marks";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable da = new DataTable();
            sda.Fill(da);
            dGvgrade.DataSource = da;
            conn.Close();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            TeacherForm tf = new TeacherForm();
            tf.Show();
            this.Hide();
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
                    query = "DELETE FROM Grade_Marks Where ID ='" + Convert.ToInt32(this.txtID.Text) + "';";
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
    }
}
