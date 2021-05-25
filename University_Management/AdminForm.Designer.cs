namespace University_Management
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Admin = new System.Windows.Forms.Label();
            this.IbiaWelcome = new System.Windows.Forms.Label();
            this.Logout = new System.Windows.Forms.Button();
            this.metroPanel1 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.adminInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sectionInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Admin
            // 
            this.Admin.AutoSize = true;
            this.Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin.Location = new System.Drawing.Point(23, 17);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(128, 25);
            this.Admin.TabIndex = 0;
            this.Admin.Text = "Admin Form";
            // 
            // IbiaWelcome
            // 
            this.IbiaWelcome.AutoSize = true;
            this.IbiaWelcome.Location = new System.Drawing.Point(524, 24);
            this.IbiaWelcome.Name = "IbiaWelcome";
            this.IbiaWelcome.Size = new System.Drawing.Size(66, 17);
            this.IbiaWelcome.TabIndex = 1;
            this.IbiaWelcome.Text = "Welcome";
            // 
            // Logout
            // 
            this.Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.Location = new System.Drawing.Point(944, 17);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(109, 38);
            this.Logout.TabIndex = 2;
            this.Logout.Text = "Log Out";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Location = new System.Drawing.Point(28, 144);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1062, 358);
            this.metroPanel1.TabIndex = 8;
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Controls.Add(this.menuStrip2);
            this.panel1.Location = new System.Drawing.Point(28, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1062, 40);
            this.panel1.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1062, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminInformationToolStripMenuItem,
            this.teacherInformationToolStripMenuItem,
            this.studentInformationToolStripMenuItem,
            this.courseInformationToolStripMenuItem,
            this.sectionInformationToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1062, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // adminInformationToolStripMenuItem
            // 
            this.adminInformationToolStripMenuItem.Name = "adminInformationToolStripMenuItem";
            this.adminInformationToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.adminInformationToolStripMenuItem.Text = "Admin Information";
            this.adminInformationToolStripMenuItem.Click += new System.EventHandler(this.adminInformationToolStripMenuItem_Click);
            // 
            // teacherInformationToolStripMenuItem
            // 
            this.teacherInformationToolStripMenuItem.Name = "teacherInformationToolStripMenuItem";
            this.teacherInformationToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.teacherInformationToolStripMenuItem.Text = "Teacher Information";
            this.teacherInformationToolStripMenuItem.Click += new System.EventHandler(this.teacherInformationToolStripMenuItem_Click);
            // 
            // studentInformationToolStripMenuItem
            // 
            this.studentInformationToolStripMenuItem.Name = "studentInformationToolStripMenuItem";
            this.studentInformationToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.studentInformationToolStripMenuItem.Text = "Student Information";
            this.studentInformationToolStripMenuItem.Click += new System.EventHandler(this.studentInformationToolStripMenuItem_Click);
            // 
            // courseInformationToolStripMenuItem
            // 
            this.courseInformationToolStripMenuItem.Name = "courseInformationToolStripMenuItem";
            this.courseInformationToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.courseInformationToolStripMenuItem.Text = "Course Information";
            this.courseInformationToolStripMenuItem.Click += new System.EventHandler(this.courseInformationToolStripMenuItem_Click);
            // 
            // sectionInformationToolStripMenuItem
            // 
            this.sectionInformationToolStripMenuItem.Name = "sectionInformationToolStripMenuItem";
            this.sectionInformationToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.sectionInformationToolStripMenuItem.Text = "Section Information";
            this.sectionInformationToolStripMenuItem.Click += new System.EventHandler(this.sectionInformationToolStripMenuItem_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 514);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.IbiaWelcome);
            this.Controls.Add(this.Admin);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Admin;
        private System.Windows.Forms.Label IbiaWelcome;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Panel metroPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem adminInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teacherInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courseInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sectionInformationToolStripMenuItem;
    }
}

