namespace SchoolManagement
{
    partial class StudentForm
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
            label2 = new Label();
            identityStudentTextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            sexStudentTextBox = new TextBox();
            label5 = new Label();
            departmentStudentTextBox = new TextBox();
            dataGridView1 = new DataGridView();
            nameStudentTextBox = new TextBox();
            updateStudentButton = new Button();
            saveStudentButton = new Button();
            addStudentButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(447, 30);
            label1.Name = "label1";
            label1.Size = new Size(254, 38);
            label1.TabIndex = 0;
            label1.Text = "Student Infomation";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 95);
            label2.Name = "label2";
            label2.Size = new Size(153, 38);
            label2.TabIndex = 1;
            label2.Text = "Student ID:";
            // 
            // identityStudentTextBox
            // 
            identityStudentTextBox.Location = new Point(350, 95);
            identityStudentTextBox.Name = "identityStudentTextBox";
            identityStudentTextBox.Size = new Size(150, 45);
            identityStudentTextBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(97, 172);
            label3.Name = "label3";
            label3.Size = new Size(200, 38);
            label3.TabIndex = 3;
            label3.Text = "Student Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(685, 102);
            label4.Name = "label4";
            label4.Size = new Size(114, 38);
            label4.TabIndex = 4;
            label4.Text = "Gender:";
            // 
            // sexStudentTextBox
            // 
            sexStudentTextBox.Location = new Point(877, 95);
            sexStudentTextBox.Name = "sexStudentTextBox";
            sexStudentTextBox.Size = new Size(150, 45);
            sexStudentTextBox.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(685, 176);
            label5.Name = "label5";
            label5.Size = new Size(171, 38);
            label5.TabIndex = 6;
            label5.Text = "Department:";
            // 
            // departmentStudentTextBox
            // 
            departmentStudentTextBox.Location = new Point(877, 169);
            departmentStudentTextBox.Name = "departmentStudentTextBox";
            departmentStudentTextBox.Size = new Size(150, 45);
            departmentStudentTextBox.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(97, 282);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(702, 373);
            dataGridView1.TabIndex = 8;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // nameStudentTextBox
            // 
            nameStudentTextBox.Location = new Point(350, 176);
            nameStudentTextBox.Name = "nameStudentTextBox";
            nameStudentTextBox.Size = new Size(150, 45);
            nameStudentTextBox.TabIndex = 9;
            // 
            // updateStudentButton
            // 
            updateStudentButton.Location = new Point(860, 413);
            updateStudentButton.Name = "updateStudentButton";
            updateStudentButton.Size = new Size(151, 53);
            updateStudentButton.TabIndex = 11;
            updateStudentButton.Text = "Update";
            updateStudentButton.UseVisualStyleBackColor = true;
            updateStudentButton.Click += updataStudentButton_Click;
            // 
            // saveStudentButton
            // 
            saveStudentButton.Location = new Point(860, 326);
            saveStudentButton.Name = "saveStudentButton";
            saveStudentButton.Size = new Size(151, 52);
            saveStudentButton.TabIndex = 12;
            saveStudentButton.Text = "Save";
            saveStudentButton.UseVisualStyleBackColor = true;
            saveStudentButton.Click += saveStudentButton_Click;
            // 
            // addStudentButton
            // 
            addStudentButton.Location = new Point(860, 264);
            addStudentButton.Name = "addStudentButton";
            addStudentButton.Size = new Size(151, 47);
            addStudentButton.TabIndex = 13;
            addStudentButton.Text = "Add New";
            addStudentButton.UseVisualStyleBackColor = true;
            addStudentButton.Click += addStudentButton_Click;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 684);
            Controls.Add(addStudentButton);
            Controls.Add(saveStudentButton);
            Controls.Add(updateStudentButton);
            Controls.Add(nameStudentTextBox);
            Controls.Add(dataGridView1);
            Controls.Add(departmentStudentTextBox);
            Controls.Add(label5);
            Controls.Add(sexStudentTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(identityStudentTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "StudentForm";
            Text = "StudentForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox identityStudentTextBox;
        private Label label3;
        private Label label4;
        private TextBox sexStudentTextBox;
        private Label label5;
        private TextBox departmentStudentTextBox;
        private DataGridView dataGridView1;
        private TextBox nameStudentTextBox;
        private Button updateStudentButton;
        private Button saveStudentButton;
        private Button addStudentButton;
    }
}