namespace SchoolManagement
{
    partial class StudentAtten
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            currentTimeLabelStudent = new Label();
            label3 = new Label();
            identityStudentTextBox = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            timeInStudentButton = new Button();
            timeOutStudentButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(302, 70);
            label1.Name = "label1";
            label1.Size = new Size(157, 25);
            label1.TabIndex = 0;
            label1.Text = "Attendent Student";
            // 
            // currentTimeLabelStudent
            // 
            currentTimeLabelStudent.AutoSize = true;
            currentTimeLabelStudent.Location = new Point(150, 169);
            currentTimeLabelStudent.MaximumSize = new Size(600, 0);
            currentTimeLabelStudent.MinimumSize = new Size(600, 0);
            currentTimeLabelStudent.Name = "currentTimeLabelStudent";
            currentTimeLabelStudent.Size = new Size(600, 25);
            currentTimeLabelStudent.TabIndex = 1;
            currentTimeLabelStudent.Text = "Time";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(108, 255);
            label3.Name = "label3";
            label3.Size = new Size(100, 25);
            label3.TabIndex = 2;
            label3.Text = "Student ID:";
            // 
            // identityStudentTextBox
            // 
            identityStudentTextBox.Location = new Point(393, 249);
            identityStudentTextBox.Name = "identityStudentTextBox";
            identityStudentTextBox.Size = new Size(150, 31);
            identityStudentTextBox.TabIndex = 3;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // timeInStudentButton
            // 
            timeInStudentButton.Location = new Point(90, 353);
            timeInStudentButton.Name = "timeInStudentButton";
            timeInStudentButton.Size = new Size(112, 34);
            timeInStudentButton.TabIndex = 4;
            timeInStudentButton.Text = "Time-In";
            timeInStudentButton.UseVisualStyleBackColor = true;
            timeInStudentButton.Click += timeInStudentButton_Click;
            // 
            // timeOutStudentButton
            // 
            timeOutStudentButton.Location = new Point(465, 353);
            timeOutStudentButton.Name = "timeOutStudentButton";
            timeOutStudentButton.Size = new Size(112, 34);
            timeOutStudentButton.TabIndex = 5;
            timeOutStudentButton.Text = "Time-Out";
            timeOutStudentButton.UseVisualStyleBackColor = true;
            timeOutStudentButton.Click += timeOutStudentButton_Click;
            // 
            // StudentAtten
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(timeOutStudentButton);
            Controls.Add(timeInStudentButton);
            Controls.Add(identityStudentTextBox);
            Controls.Add(label3);
            Controls.Add(currentTimeLabelStudent);
            Controls.Add(label1);
            Name = "StudentAtten";
            Text = "StudentAtten";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label currentTimeLabelStudent;
        private Label label3;
        private TextBox identityStudentTextBox;
        private System.Windows.Forms.Timer timer1;
        private Button timeInStudentButton;
        private Button timeOutStudentButton;
    }
}