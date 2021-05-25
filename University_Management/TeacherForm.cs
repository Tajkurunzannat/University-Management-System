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
    public partial class TeacherForm : Form
    {
        public TeacherForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gradeInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentGrade sg = new StudentGrade();
            sg.Show();
            this.Hide();
        }

        private void noticeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherNoticeForm tnf = new TeacherNoticeForm();
            tnf.Show();
            this.Hide();
        }

        private void offeredCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherOfferedCourseForm tocf = new TeacherOfferedCourseForm();
            tocf.Show();
            this.Hide();
        }

        private void courseRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherRegForm trf = new TeacherRegForm();
            trf.Show();
            this.Hide();
        }
    }
}
