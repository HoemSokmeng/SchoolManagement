namespace SchoolManagement
{
    partial class TeacherForm
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            salaryTextBox = new TextBox();
            label5 = new Label();
            subjectTextBox = new TextBox();
            label4 = new Label();
            nameTeacherTextBox = new TextBox();
            label3 = new Label();
            idTeacherTextBox = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            passwordTextBox = new TextBox();
            label7 = new Label();
            usernameTextBox = new TextBox();
            label6 = new Label();
            dataGridView2 = new DataGridView();
            addTeacherButton = new Button();
            saveTeacherButton = new Button();
            updateTeacherButton = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(742, 31);
            label1.Name = "label1";
            label1.Size = new Size(264, 38);
            label1.TabIndex = 0;
            label1.Text = "Teacher Information";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(salaryTextBox);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(subjectTextBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(nameTeacherTextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(idTeacherTextBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(582, 354);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Teacher Info:";
            // 
            // salaryTextBox
            // 
            salaryTextBox.Location = new Point(333, 276);
            salaryTextBox.Name = "salaryTextBox";
            salaryTextBox.Size = new Size(150, 45);
            salaryTextBox.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(70, 283);
            label5.Name = "label5";
            label5.Size = new Size(97, 38);
            label5.TabIndex = 6;
            label5.Text = "Salary:";
            // 
            // subjectTextBox
            // 
            subjectTextBox.Location = new Point(333, 207);
            subjectTextBox.Name = "subjectTextBox";
            subjectTextBox.Size = new Size(150, 45);
            subjectTextBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 210);
            label4.Name = "label4";
            label4.Size = new Size(114, 38);
            label4.TabIndex = 4;
            label4.Text = "Subject:";
            // 
            // nameTeacherTextBox
            // 
            nameTeacherTextBox.Location = new Point(333, 141);
            nameTeacherTextBox.Name = "nameTeacherTextBox";
            nameTeacherTextBox.Size = new Size(150, 45);
            nameTeacherTextBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 141);
            label3.Name = "label3";
            label3.Size = new Size(200, 38);
            label3.TabIndex = 2;
            label3.Text = "Teacher Name:";
            // 
            // idTeacherTextBox
            // 
            idTeacherTextBox.Location = new Point(333, 70);
            idTeacherTextBox.Name = "idTeacherTextBox";
            idTeacherTextBox.Size = new Size(150, 45);
            idTeacherTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 77);
            label2.Name = "label2";
            label2.Size = new Size(153, 38);
            label2.TabIndex = 0;
            label2.Text = "Teacher ID:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(passwordTextBox);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(usernameTextBox);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(27, 376);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(563, 254);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "UserAccount:";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(314, 189);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(150, 45);
            passwordTextBox.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(51, 192);
            label7.Name = "label7";
            label7.Size = new Size(138, 38);
            label7.TabIndex = 2;
            label7.Text = "Password:";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(314, 95);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(150, 45);
            usernameTextBox.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 102);
            label6.Name = "label6";
            label6.Size = new Size(148, 38);
            label6.TabIndex = 0;
            label6.Text = "Username:";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(613, 137);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.RowTemplate.Height = 33;
            dataGridView2.Size = new Size(575, 344);
            dataGridView2.TabIndex = 4;
            dataGridView2.SelectionChanged += dataGridView2_SelectionChanged;
            // 
            // addTeacherButton
            // 
            addTeacherButton.Location = new Point(693, 525);
            addTeacherButton.Name = "addTeacherButton";
            addTeacherButton.Size = new Size(164, 53);
            addTeacherButton.TabIndex = 4;
            addTeacherButton.Text = "Add New";
            addTeacherButton.UseVisualStyleBackColor = true;
            addTeacherButton.Click += addTeacherButton_Click;
            // 
            // saveTeacherButton
            // 
            saveTeacherButton.Location = new Point(877, 525);
            saveTeacherButton.Name = "saveTeacherButton";
            saveTeacherButton.Size = new Size(112, 53);
            saveTeacherButton.TabIndex = 5;
            saveTeacherButton.Text = "Save ";
            saveTeacherButton.UseVisualStyleBackColor = true;
            saveTeacherButton.Click += saveTeacherButton_Click;
            // 
            // updateTeacherButton
            // 
            updateTeacherButton.Location = new Point(1023, 525);
            updateTeacherButton.Name = "updateTeacherButton";
            updateTeacherButton.Size = new Size(131, 53);
            updateTeacherButton.TabIndex = 6;
            updateTeacherButton.Text = "Update";
            updateTeacherButton.UseVisualStyleBackColor = true;
            updateTeacherButton.Click += updateTeacherButton_Click;
            // 
            // TeacherForm
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 684);
            Controls.Add(addTeacherButton);
            Controls.Add(saveTeacherButton);
            Controls.Add(updateTeacherButton);
            Controls.Add(groupBox2);
            Controls.Add(dataGridView2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "TeacherForm";
            Text = "TeacherForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox usernameTextBox;
        private Label label6;
        private TextBox salaryTextBox;
        private Label label5;
        private TextBox subjectTextBox;
        private Label label4;
        private TextBox nameTeacherTextBox;
        private Label label3;
        private TextBox idTeacherTextBox;
        private Label label2;
        private TextBox passwordTextBox;
        private Label label7;
        private DataGridView dataGridView2;
        private Button addTeacherButton;
        private Button saveTeacherButton;
        private Button updateTeacherButton;
    }
}