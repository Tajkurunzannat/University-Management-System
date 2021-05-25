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
    public partial class StudentOfferedCourseForm : Form
    {
        public StudentOfferedCourseForm()
        {
            InitializeComponent();
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Server=ABIRRIFAT\SQLEXPRESS;Database=UM_Database;Integrated Security=true");
            conn.Open();
            //string query = "";
            String query = "SELECT * FROM CourseInfo";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable da = new DataTable();
            sda.Fill(da);
            dgvsocourse.DataSource = da;
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
