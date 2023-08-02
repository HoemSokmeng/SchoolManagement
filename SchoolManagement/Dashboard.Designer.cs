namespace SchoolManagement
{
    partial class Dashboard
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
            panel1 = new Panel();
            closeButton = new Button();
            label1 = new Label();
            panel2 = new Panel();
            label8 = new Label();
            departmentPictureBox = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            teacherPictureBox = new PictureBox();
            label4 = new Label();
            StudentPictureBox = new PictureBox();
            label5 = new Label();
            AttendTeacherPictureBox = new PictureBox();
            label6 = new Label();
            AttendStudentPictureBox = new PictureBox();
            label7 = new Label();
            scoreStudentPictureBox = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)departmentPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)teacherPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StudentPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AttendTeacherPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AttendStudentPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)scoreStudentPictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(closeButton);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-4, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1048, 119);
            panel1.TabIndex = 0;
            // 
            // closeButton
            // 
            closeButton.BackColor = SystemColors.Desktop;
            closeButton.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            closeButton.ForeColor = SystemColors.ButtonHighlight;
            closeButton.Location = new Point(920, 27);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(89, 65);
            closeButton.TabIndex = 5;
            closeButton.Text = "X";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(114, 27);
            label1.Name = "label1";
            label1.Size = new Size(668, 65);
            label1.TabIndex = 3;
            label1.Text = "School Management System";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.MenuHighlight;
            panel2.Controls.Add(label8);
            panel2.Location = new Point(-4, 725);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1048, 106);
            panel2.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.Highlight;
            label8.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(382, 19);
            label8.Name = "label8";
            label8.Size = new Size(259, 60);
            label8.TabIndex = 15;
            label8.Text = "Group MS1";
            // 
            // departmentPictureBox
            // 
            departmentPictureBox.BorderStyle = BorderStyle.FixedSingle;
            departmentPictureBox.Image = Properties.Resources._1;
            departmentPictureBox.Location = new Point(71, 156);
            departmentPictureBox.Name = "departmentPictureBox";
            departmentPictureBox.Size = new Size(225, 220);
            departmentPictureBox.TabIndex = 2;
            departmentPictureBox.TabStop = false;
            departmentPictureBox.Click += departmentPictureBox_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 379);
            label2.Name = "label2";
            label2.Size = new Size(142, 32);
            label2.TabIndex = 4;
            label2.Text = "Department";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(448, 379);
            label3.Name = "label3";
            label3.Size = new Size(96, 32);
            label3.TabIndex = 6;
            label3.Text = "Teacher";
            // 
            // teacherPictureBox
            // 
            teacherPictureBox.BorderStyle = BorderStyle.FixedSingle;
            teacherPictureBox.Image = Properties.Resources._1;
            teacherPictureBox.Location = new Point(389, 156);
            teacherPictureBox.Name = "teacherPictureBox";
            teacherPictureBox.Size = new Size(225, 220);
            teacherPictureBox.TabIndex = 5;
            teacherPictureBox.TabStop = false;
            teacherPictureBox.Click += teacherPictureBox_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(772, 379);
            label4.Name = "label4";
            label4.Size = new Size(97, 32);
            label4.TabIndex = 8;
            label4.Text = "Student";
            // 
            // StudentPictureBox
            // 
            StudentPictureBox.BorderStyle = BorderStyle.FixedSingle;
            StudentPictureBox.Image = Properties.Resources._1;
            StudentPictureBox.Location = new Point(710, 156);
            StudentPictureBox.Name = "StudentPictureBox";
            StudentPictureBox.Size = new Size(225, 220);
            StudentPictureBox.TabIndex = 7;
            StudentPictureBox.TabStop = false;
            StudentPictureBox.Click += StudentPictureBox_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(79, 661);
            label5.Name = "label5";
            label5.Size = new Size(217, 32);
            label5.TabIndex = 10;
            label5.Text = "Attendent  Teacher";
            // 
            // AttendTeacherPictureBox
            // 
            AttendTeacherPictureBox.BorderStyle = BorderStyle.FixedSingle;
            AttendTeacherPictureBox.Image = Properties.Resources._1;
            AttendTeacherPictureBox.Location = new Point(71, 438);
            AttendTeacherPictureBox.Name = "AttendTeacherPictureBox";
            AttendTeacherPictureBox.Size = new Size(225, 220);
            AttendTeacherPictureBox.TabIndex = 9;
            AttendTeacherPictureBox.TabStop = false;
            AttendTeacherPictureBox.Click += AttendTeacherPictureBox_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(397, 661);
            label6.Name = "label6";
            label6.Size = new Size(218, 32);
            label6.TabIndex = 12;
            label6.Text = "Attendent  Student";
            // 
            // AttendStudentPictureBox
            // 
            AttendStudentPictureBox.BorderStyle = BorderStyle.FixedSingle;
            AttendStudentPictureBox.Image = Properties.Resources._1;
            AttendStudentPictureBox.Location = new Point(389, 438);
            AttendStudentPictureBox.Name = "AttendStudentPictureBox";
            AttendStudentPictureBox.Size = new Size(225, 220);
            AttendStudentPictureBox.TabIndex = 11;
            AttendStudentPictureBox.TabStop = false;
            AttendStudentPictureBox.Click += AttendStudentPictureBox_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(748, 661);
            label7.Name = "label7";
            label7.Size = new Size(163, 32);
            label7.TabIndex = 14;
            label7.Text = "Score Student";
            // 
            // scoreStudentPictureBox
            // 
            scoreStudentPictureBox.BorderStyle = BorderStyle.FixedSingle;
            scoreStudentPictureBox.Image = Properties.Resources._1;
            scoreStudentPictureBox.Location = new Point(710, 438);
            scoreStudentPictureBox.Name = "scoreStudentPictureBox";
            scoreStudentPictureBox.Size = new Size(225, 220);
            scoreStudentPictureBox.TabIndex = 13;
            scoreStudentPictureBox.TabStop = false;
            scoreStudentPictureBox.Click += scoreStudentPictureBox_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightPink;
            ClientSize = new Size(1040, 828);
            Controls.Add(label7);
            Controls.Add(scoreStudentPictureBox);
            Controls.Add(label6);
            Controls.Add(AttendStudentPictureBox);
            Controls.Add(label5);
            Controls.Add(AttendTeacherPictureBox);
            Controls.Add(label4);
            Controls.Add(StudentPictureBox);
            Controls.Add(label3);
            Controls.Add(teacherPictureBox);
            Controls.Add(label2);
            Controls.Add(departmentPictureBox);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Dashboard";
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)departmentPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)teacherPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)StudentPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)AttendTeacherPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)AttendStudentPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)scoreStudentPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox departmentPictureBox;
        private Label label1;
        private Label label2;
        private Button closeButton;
        private Label label3;
        private PictureBox teacherPictureBox;
        private Label label4;
        private PictureBox StudentPictureBox;
        private Label label5;
        private PictureBox AttendTeacherPictureBox;
        private Label label6;
        private PictureBox AttendStudentPictureBox;
        private Label label7;
        private PictureBox scoreStudentPictureBox;
        private Label label8;
    }
}