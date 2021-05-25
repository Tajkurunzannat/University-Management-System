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
    public partial class AdminTeacherInfo : Form
    {
        public AdminTeacherInfo()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.txtName.Text) || String.IsNullOrEmpty(this.txtPass.Text) || String.IsNullOrEmpty(this.dtpDOB.Text) || String.IsNullOrEmpty(this.txtEmail.Text) || String.IsNullOrEmpty(this.ddlUType.Text))
            {
                MessageBox.Show("Please insert a value", "Message");
            }
            else
            {

                Regex uname;
                uname = new Regex(@"^([A-Z][a-z-A-z]+)$");

                Regex pass;
                pass = new Regex(@"^([0-9]+)$");

                Regex email;
                email = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                if (!uname.IsMatch(txtName.Text))
                {
                    MessageBox.Show("Username format is not correct.", "Validation");
                }

                else if (!pass.IsMatch(txtPass.Text))
                {
                    MessageBox.Show("password format is not correct.", "Validation");
                }

                else if (!email.IsMatch(txtEmail.Text))
                {
                    MessageBox.Show("Email format is not correct.", "Validation");
                }

                else
                {

                    SqlConnection conn = new SqlConnection(@"Server=ABIRRIFAT\SQLEXPRESS;Database=UM_Database;Integrated Security=true");
                    conn.Open();
                    string query = "";
                    query = "INSERT INTO TeacherInfo (TeacherName,TeacherPass,DOB,Email,UserType) VALUES('" + txtName.Text + "','" + txtPass.Text + "','" + dtpDOB.Text + "','" + txtEmail.Text + "','" + ddlUType.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    int result = cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Succesfully Saved", "Message");
                    txtName.Text = "";
                    txtPass.Text = "";
                    dtpDOB.Text = "";
                    txtEmail.Text = "";
                    ddlUType.Text = "";
                }

            }
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Server=ABIRRIFAT\SQLEXPRESS;Database=UM_Database;Integrated Security=true");
            conn.Open();
            //string query = "";
            String query = "SELECT * FROM TeacherInfo";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable da = new DataTable();
            sda.Fill(da);
            dGvteacher.DataSource = da;
            conn.Close();
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
                    SqlConnection conn = new SqlConnection(@"Server=ABIRRIFAT\SQLEXPRESS;Database=UM_database;Integrated Security=true");
                    string query = "";
                    query = "DELETE  FROM TeacherInfo Where ID='" + this.txtID.Text + "';";
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

        private void backBtn_Click(object sender, EventArgs e)
        {
            AdminForm af = new AdminForm();
            af.Show();
            this.Hide();
        }
    }
}
