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
    public partial class SectionInfo : Form
    {
        public SectionInfo()
        {
            InitializeComponent();
            FillCombo();
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
                    ddlUType.Items.Add(sName);
                }
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.txtName.Text) || String.IsNullOrEmpty(this.ddlUType.Text))
            {
                MessageBox.Show("Please insert a value", "Message");
            }
            else 
            {
                Regex uname;
                uname = new Regex(@"^([A-Z]{1})$");

                if (!uname.IsMatch(txtName.Text))
                {
                    MessageBox.Show("Sectionname format is not correct.", "Validation");
                }

                else
                {

                    SqlConnection conn = new SqlConnection(@"Server=ABIRRIFAT\SQLEXPRESS;Database=UM_Database;Integrated Security=true");
                    conn.Open();
                    string query = "";
                    query = "INSERT INTO SectionInfo (SectionName,CourseName) VALUES('" + txtName.Text + "','" + ddlUType.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    int result = cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Succesfully Saved", "Message");
                    txtName.Text = "";
                    ddlUType.Text = "";
                }
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
                    query = "DELETE FROM dbo.SectionInfo Where ID ='" + Convert.ToInt32(this.txtID.Text) + "';";
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

        private string ClearText()
        {
            throw new NotImplementedException();
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Server=ABIRRIFAT\SQLEXPRESS;Database=UM_Database;Integrated Security=true");
            conn.Open();
            //string query = "";
            String query = "SELECT * FROM SectionInfo";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable da = new DataTable();
            sda.Fill(da);
            dgvsection.DataSource = da;
            conn.Close();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            AdminForm af = new AdminForm();
            af.Show();
            this.Hide();
        }

        private void ddlUType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
