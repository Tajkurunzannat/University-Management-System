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
  
    public partial class LoginForm : Form
    {
       
        public LoginForm()
        {
            InitializeComponent();
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

         public void Admin()
        {
            if (string.IsNullOrEmpty(txtUserNM.Text) || string.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("Name or Password Missing");
            }

            else
            {
                SqlConnection conn = new SqlConnection(@"Server=ABIRRIfat\SQLEXPRESS;Database=UM_Database;Integrated Security=true");
                conn.Open();
                SqlDataAdapter s = new SqlDataAdapter("select * from AdminInfo WHERE AdminName= '" + txtUserNM.Text + "' AND AdminPass = '" + txtPass.Text + "'", conn);
                DataTable dt = new DataTable();
                s.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    AdminForm af = new AdminForm();
                   
                   
                    af.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username or Password is Incorrect", "Message");
                }
                conn.Close();
            }
            }

        public void Teacher()
        {
            if (string.IsNullOrEmpty(txtUserNM.Text) || string.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("Name or Password Missing");
            }

            else
            {
                SqlConnection conn = new SqlConnection(@"Server=ABIRRIfat\SQLEXPRESS;Database=UM_Database;Integrated Security=true");
                conn.Open();
                SqlDataAdapter s = new SqlDataAdapter("select * from TeacherInfo WHERE TeacherName= '" + txtUserNM.Text + "' AND TeacherPass = '" + txtPass.Text + "'", conn);
                DataTable dt = new DataTable();
                s.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    TeacherForm af = new TeacherForm();
                   
                    af.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username or Password is Incorrect", "Message");
                }
                conn.Close();
            }
        }

        public void Student()
        {
            if (string.IsNullOrEmpty(txtUserNM.Text) || string.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("Name or Password Missing");
            }

            else
            {
                SqlConnection conn = new SqlConnection(@"Server=ABIRRIfat\SQLEXPRESS;Database=UM_Database;Integrated Security=true");
                conn.Open();
                SqlDataAdapter s = new SqlDataAdapter("select * from StudentInf WHERE StudentName= '" + txtUserNM.Text + "' AND StudentPass = '" + txtPass.Text + "'", conn);
                DataTable dt = new DataTable();
                s.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    StudentForm af = new StudentForm(txtUserNM.Text);
                   
                    af.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username or Password is Incorrect", "Message");
                }
                conn.Close();
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (UserTypetxt.SelectedItem=="Admin")
            {
                Admin();
            }
            else if(UserTypetxt.SelectedItem == "Teacher")
            {
                Teacher();
            }
            else if (UserTypetxt.SelectedItem == "Student")
            {
                Student();
            }
            else
            {
                MessageBox.Show("Select one");
            }

        }

        private void UserTypetxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
