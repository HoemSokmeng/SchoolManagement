namespace SchoolManagement
{
    partial class ScoreStudentForm
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            idScoreStudentTextBox = new TextBox();
            nameScoreStudentTextBox = new TextBox();
            englishTextBox = new TextBox();
            bigDataTextBox = new TextBox();
            javaTextBox = new TextBox();
            cshapTextBox = new TextBox();
            pythonTextBox = new TextBox();
            closeScoreButton = new Button();
            addNewButton = new Button();
            scoreStudentDataGridView = new DataGridView();
            updateScoreButton = new Button();
            saveScoreButton = new Button();
            totalLable = new Label();
            gradeLable = new Label();
            lableAverage = new Label();
            ((System.ComponentModel.ISupportInitialize)scoreStudentDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(486, 40);
            label1.Name = "label1";
            label1.Size = new Size(341, 38);
            label1.TabIndex = 0;
            label1.Text = "Score Student Information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 113);
            label2.Name = "label2";
            label2.Size = new Size(153, 38);
            label2.TabIndex = 1;
            label2.Text = "Student ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 190);
            label3.Name = "label3";
            label3.Size = new Size(200, 38);
            label3.TabIndex = 2;
            label3.Text = "Student Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(473, 106);
            label4.Name = "label4";
            label4.Size = new Size(74, 38);
            label4.TabIndex = 3;
            label4.Text = "Java:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(473, 183);
            label5.Name = "label5";
            label5.Size = new Size(65, 38);
            label5.TabIndex = 4;
            label5.Text = "C# :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(63, 268);
            label6.Name = "label6";
            label6.Size = new Size(110, 38);
            label6.TabIndex = 5;
            label6.Text = "Python:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(821, 113);
            label7.Name = "label7";
            label7.Size = new Size(127, 38);
            label7.TabIndex = 6;
            label7.Text = "Big Data:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(830, 190);
            label8.Name = "label8";
            label8.Size = new Size(111, 38);
            label8.TabIndex = 7;
            label8.Text = "English:";
            // 
            // idScoreStudentTextBox
            // 
            idScoreStudentTextBox.Location = new Point(300, 103);
            idScoreStudentTextBox.Name = "idScoreStudentTextBox";
            idScoreStudentTextBox.Size = new Size(150, 45);
            idScoreStudentTextBox.TabIndex = 8;
            // 
            // nameScoreStudentTextBox
            // 
            nameScoreStudentTextBox.Location = new Point(300, 184);
            nameScoreStudentTextBox.Name = "nameScoreStudentTextBox";
            nameScoreStudentTextBox.Size = new Size(150, 45);
            nameScoreStudentTextBox.TabIndex = 9;
            // 
            // englishTextBox
            // 
            englishTextBox.Location = new Point(992, 176);
            englishTextBox.Name = "englishTextBox";
            englishTextBox.Size = new Size(150, 45);
            englishTextBox.TabIndex = 10;
            // 
            // bigDataTextBox
            // 
            bigDataTextBox.Location = new Point(992, 106);
            bigDataTextBox.Name = "bigDataTextBox";
            bigDataTextBox.Size = new Size(150, 45);
            bigDataTextBox.TabIndex = 11;
            // 
            // javaTextBox
            // 
            javaTextBox.Location = new Point(599, 106);
            javaTextBox.Name = "javaTextBox";
            javaTextBox.Size = new Size(150, 45);
            javaTextBox.TabIndex = 12;
            // 
            // cshapTextBox
            // 
            cshapTextBox.Location = new Point(599, 176);
            cshapTextBox.Name = "cshapTextBox";
            cshapTextBox.Size = new Size(150, 45);
            cshapTextBox.TabIndex = 13;
            // 
            // pythonTextBox
            // 
            pythonTextBox.Location = new Point(300, 265);
            pythonTextBox.Name = "pythonTextBox";
            pythonTextBox.Size = new Size(150, 45);
            pythonTextBox.TabIndex = 14;
            // 
            // closeScoreButton
            // 
            closeScoreButton.Location = new Point(973, 263);
            closeScoreButton.Name = "closeScoreButton";
            closeScoreButton.Size = new Size(134, 58);
            closeScoreButton.TabIndex = 15;
            closeScoreButton.Text = "Close";
            closeScoreButton.UseVisualStyleBackColor = true;
            closeScoreButton.Click += closeScoreButton_Click;
            // 
            // addNewButton
            // 
            addNewButton.Location = new Point(486, 265);
            addNewButton.Name = "addNewButton";
            addNewButton.Size = new Size(157, 56);
            addNewButton.TabIndex = 16;
            addNewButton.Text = "Add New";
            addNewButton.UseVisualStyleBackColor = true;
            addNewButton.Click += addNewButton_Click;
            // 
            // scoreStudentDataGridView
            // 
            scoreStudentDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            scoreStudentDataGridView.Location = new Point(88, 438);
            scoreStudentDataGridView.Name = "scoreStudentDataGridView";
            scoreStudentDataGridView.RowHeadersWidth = 62;
            scoreStudentDataGridView.RowTemplate.Height = 33;
            scoreStudentDataGridView.Size = new Size(937, 225);
            scoreStudentDataGridView.TabIndex = 17;
            scoreStudentDataGridView.SelectionChanged += scoreStudentDataGridView_SelectionChanged;
            // 
            // updateScoreButton
            // 
            updateScoreButton.Location = new Point(795, 268);
            updateScoreButton.Name = "updateScoreButton";
            updateScoreButton.Size = new Size(146, 53);
            updateScoreButton.TabIndex = 18;
            updateScoreButton.Text = "Update";
            updateScoreButton.UseVisualStyleBackColor = true;
            updateScoreButton.Click += updateScoreButton_Click;
            // 
            // saveScoreButton
            // 
            saveScoreButton.Location = new Point(667, 269);
            saveScoreButton.Name = "saveScoreButton";
            saveScoreButton.Size = new Size(112, 52);
            saveScoreButton.TabIndex = 19;
            saveScoreButton.Text = "Save";
            saveScoreButton.UseVisualStyleBackColor = true;
            saveScoreButton.Click += saveScoreButton_Click;
            // 
            // totalLable
            // 
            totalLable.AutoSize = true;
            totalLable.Location = new Point(73, 306);
            totalLable.Name = "totalLable";
            totalLable.Size = new Size(0, 38);
            totalLable.TabIndex = 20;
            // 
            // gradeLable
            // 
            gradeLable.AutoSize = true;
            gradeLable.Location = new Point(992, 21);
            gradeLable.Name = "gradeLable";
            gradeLable.Size = new Size(0, 38);
            gradeLable.TabIndex = 23;
            // 
            // lableAverage
            // 
            lableAverage.AutoSize = true;
            lableAverage.Location = new Point(164, 40);
            lableAverage.Name = "lableAverage";
            lableAverage.Size = new Size(0, 38);
            lableAverage.TabIndex = 24;
            // 
            // ScoreStudentForm
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 684);
            Controls.Add(lableAverage);
            Controls.Add(gradeLable);
            Controls.Add(totalLable);
            Controls.Add(saveScoreButton);
            Controls.Add(updateScoreButton);
            Controls.Add(scoreStudentDataGridView);
            Controls.Add(addNewButton);
            Controls.Add(closeScoreButton);
            Controls.Add(pythonTextBox);
            Controls.Add(cshapTextBox);
            Controls.Add(javaTextBox);
            Controls.Add(bigDataTextBox);
            Controls.Add(englishTextBox);
            Controls.Add(nameScoreStudentTextBox);
            Controls.Add(idScoreStudentTextBox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ScoreStudentForm";
            Text = "ScoreStudentForm";
            ((System.ComponentModel.ISupportInitialize)scoreStudentDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox idScoreStudentTextBox;
        private TextBox nameScoreStudentTextBox;
        private TextBox englishTextBox;
        private TextBox bigDataTextBox;
        private TextBox javaTextBox;
        private TextBox cshapTextBox;
        private TextBox pythonTextBox;
        private Button closeScoreButton;
        private Button addNewButton;
        private DataGridView scoreStudentDataGridView;
        private Button updateScoreButton;
        private Button saveScoreButton;
        private Label totalLable;
        private Label gradeLable;
        private Label lableAverage;
    }
}