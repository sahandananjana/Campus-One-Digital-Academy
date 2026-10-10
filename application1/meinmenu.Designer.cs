namespace application1
{
    partial class meinmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(meinmenu));
            exitToolStripMenuItem = new LinkLabel();
            aboutToolStripMenuItem = new LinkLabel();
            pictureBox1 = new PictureBox();
            btnStudent = new Button();
            btnTeacher = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.AutoSize = true;
            exitToolStripMenuItem.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitToolStripMenuItem.Location = new Point(23, 9);
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(36, 23);
            exitToolStripMenuItem.TabIndex = 0;
            exitToolStripMenuItem.TabStop = true;
            exitToolStripMenuItem.Text = "File";
            exitToolStripMenuItem.LinkClicked += exitToolStripMenuItem_LinkClicked;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.AutoSize = true;
            aboutToolStripMenuItem.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            aboutToolStripMenuItem.Location = new Point(97, 9);
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(46, 23);
            aboutToolStripMenuItem.TabIndex = 1;
            aboutToolStripMenuItem.TabStop = true;
            aboutToolStripMenuItem.Text = "Help";
            aboutToolStripMenuItem.LinkClicked += aboutToolStripMenuItem_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(193, 164);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(450, 446);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnStudent
            // 
            btnStudent.BackColor = Color.SpringGreen;
            btnStudent.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudent.Location = new Point(967, 164);
            btnStudent.Name = "btnStudent";
            btnStudent.Size = new Size(303, 102);
            btnStudent.TabIndex = 3;
            btnStudent.Text = "Student";
            btnStudent.UseVisualStyleBackColor = false;
            btnStudent.Click += btnStudent_Click_1;
            // 
            // btnTeacher
            // 
            btnTeacher.BackColor = Color.Yellow;
            btnTeacher.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTeacher.Location = new Point(967, 352);
            btnTeacher.Name = "btnTeacher";
            btnTeacher.Size = new Size(303, 102);
            btnTeacher.TabIndex = 4;
            btnTeacher.Text = "Teacher";
            btnTeacher.UseVisualStyleBackColor = false;
            btnTeacher.Click += btnTeacher_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(967, 548);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(303, 62);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // meinmenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1628, 828);
            Controls.Add(btnExit);
            Controls.Add(btnTeacher);
            Controls.Add(btnStudent);
            Controls.Add(pictureBox1);
            Controls.Add(aboutToolStripMenuItem);
            Controls.Add(exitToolStripMenuItem);
            Name = "meinmenu";
            Text = "meinmenu";
            Load += meinmenu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel exitToolStripMenuItem;
        private LinkLabel aboutToolStripMenuItem;
        private PictureBox pictureBox1;
        private Button btnStudent;
        private Button btnTeacher;
        private Button btnExit;
    }
}