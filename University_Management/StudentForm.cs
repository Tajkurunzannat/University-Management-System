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
    public partial class StudentForm : Form
    {
        private string username;
        public StudentForm()
        {
            InitializeComponent();
        }
        public StudentForm(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void slogoutBtn_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }

        private void gradeInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentGradeShowForm sf = new StudentGradeShowForm();
            sf.Show();
            this.Hide();
        }

        private void noticeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentNoticeForm sn = new StudentNoticeForm();
            sn.Show();
            this.Hide();
        }

        private void courseRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentRegForm sr = new StudentRegForm();
            sr.Show();
            this.Hide();
        }

        private void offeredCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentOfferedCourseForm sf = new StudentOfferedCourseForm();
            sf.Show();
            this.Hide();

        }
    }
}
