namespace SchoolManagement
{
    partial class AttenTeacher
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
            currentTimeLabel = new Label();
            label3 = new Label();
            idTeacherTextBox = new TextBox();
            timeInButton = new Button();
            timeOutButton = new Button();
            timer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(347, 61);
            label1.Name = "label1";
            label1.Size = new Size(210, 32);
            label1.TabIndex = 0;
            label1.Text = "Attendent Teacher";
            // 
            // currentTimeLabel
            // 
            currentTimeLabel.AutoSize = true;
            currentTimeLabel.Location = new Point(286, 145);
            currentTimeLabel.MaximumSize = new Size(600, 0);
            currentTimeLabel.MinimumSize = new Size(600, 0);
            currentTimeLabel.Name = "currentTimeLabel";
            currentTimeLabel.Size = new Size(600, 32);
            currentTimeLabel.TabIndex = 1;
            currentTimeLabel.Text = "Time";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(222, 266);
            label3.Name = "label3";
            label3.Size = new Size(131, 32);
            label3.TabIndex = 2;
            label3.Text = "Teacher ID:";
            // 
            // idTeacherTextBox
            // 
            idTeacherTextBox.Location = new Point(579, 266);
            idTeacherTextBox.Name = "idTeacherTextBox";
            idTeacherTextBox.Size = new Size(150, 39);
            idTeacherTextBox.TabIndex = 3;
            // 
            // timeInButton
            // 
            timeInButton.Location = new Point(213, 375);
            timeInButton.Name = "timeInButton";
            timeInButton.Size = new Size(112, 52);
            timeInButton.TabIndex = 4;
            timeInButton.Text = "Time-In";
            timeInButton.UseVisualStyleBackColor = true;
            timeInButton.Click += timeInButton_Click;
            // 
            // timeOutButton
            // 
            timeOutButton.Location = new Point(589, 375);
            timeOutButton.Name = "timeOutButton";
            timeOutButton.Size = new Size(147, 43);
            timeOutButton.TabIndex = 5;
            timeOutButton.Text = "Time-Out";
            timeOutButton.UseVisualStyleBackColor = true;
            timeOutButton.Click += timeOutButton_Click;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 10;
            timer.Tick += timer_Tick;
            // 
            // AttenTeacher
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1001, 500);
            Controls.Add(timeOutButton);
            Controls.Add(timeInButton);
            Controls.Add(idTeacherTextBox);
            Controls.Add(label3);
            Controls.Add(currentTimeLabel);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "AttenTeacher";
            Text = "AttenTeacher";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label currentTimeLabel;
        private Label label3;
        private TextBox idTeacherTextBox;
        private Button timeInButton;
        private Button timeOutButton;
        private System.Windows.Forms.Timer timer;
    }
}