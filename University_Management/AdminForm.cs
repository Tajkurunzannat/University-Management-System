using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_Management
{
    public partial class AdminForm : Form
    {
        private string username;
        public AdminForm()
        {
            InitializeComponent();
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }

        private void adminInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminInformation ai = new AdminInformation();
            ai.Show();
            this.Hide();
        }

        private void teacherInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminTeacherInfo at = new AdminTeacherInfo();
            at.Show();
            this.Hide();
        }

        private void studentInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminStudentInfo am= new AdminStudentInfo();
            am.Show();
            this.Hide();
        }

        private void courseInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CourseInfo cf = new CourseInfo();
            cf.Show();
            this.Hide();
        }

        private void sectionInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SectionInfo sf = new SectionInfo();
            sf.Show();
            this.Hide();
        }
    }
}
