namespace SchoolManagement
{
    partial class DepartmentForm
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
            idDepartmentTextBox = new TextBox();
            label3 = new Label();
            nameDepartmentTextBox = new TextBox();
            label4 = new Label();
            managerDepartmentTextBox = new TextBox();
            label5 = new Label();
            priceDepartmentTextBox = new TextBox();
            addNewDepartmentButton = new Button();
            saveDepartmentButton = new Button();
            updateDepartmentButton = new Button();
            dpt_DataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dpt_DataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(217, 21);
            label1.Name = "label1";
            label1.Size = new Size(276, 60);
            label1.TabIndex = 0;
            label1.Text = "Department";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 146);
            label2.Name = "label2";
            label2.Size = new Size(132, 25);
            label2.TabIndex = 1;
            label2.Text = "Department Id:";
            // 
            // idDepartmentTextBox
            // 
            idDepartmentTextBox.Location = new Point(239, 146);
            idDepartmentTextBox.Name = "idDepartmentTextBox";
            idDepartmentTextBox.Size = new Size(150, 31);
            idDepartmentTextBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 197);
            label3.Name = "label3";
            label3.Size = new Size(163, 25);
            label3.TabIndex = 3;
            label3.Text = "Department Name:";
            // 
            // nameDepartmentTextBox
            // 
            nameDepartmentTextBox.Location = new Point(239, 197);
            nameDepartmentTextBox.Name = "nameDepartmentTextBox";
            nameDepartmentTextBox.Size = new Size(150, 31);
            nameDepartmentTextBox.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 251);
            label4.Name = "label4";
            label4.Size = new Size(186, 25);
            label4.TabIndex = 5;
            label4.Text = "Department Manager:";
            // 
            // managerDepartmentTextBox
            // 
            managerDepartmentTextBox.Location = new Point(239, 251);
            managerDepartmentTextBox.Name = "managerDepartmentTextBox";
            managerDepartmentTextBox.Size = new Size(150, 31);
            managerDepartmentTextBox.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 301);
            label5.Name = "label5";
            label5.Size = new Size(153, 25);
            label5.TabIndex = 7;
            label5.Text = "Department Price:";
            // 
            // priceDepartmentTextBox
            // 
            priceDepartmentTextBox.Location = new Point(239, 298);
            priceDepartmentTextBox.Name = "priceDepartmentTextBox";
            priceDepartmentTextBox.Size = new Size(150, 31);
            priceDepartmentTextBox.TabIndex = 8;
            // 
            // addNewDepartmentButton
            // 
            addNewDepartmentButton.Location = new Point(86, 370);
            addNewDepartmentButton.Name = "addNewDepartmentButton";
            addNewDepartmentButton.Size = new Size(112, 34);
            addNewDepartmentButton.TabIndex = 9;
            addNewDepartmentButton.Text = "Add New";
            addNewDepartmentButton.UseVisualStyleBackColor = true;
            addNewDepartmentButton.Click += addNewDepartmentButton_Click;
            // 
            // saveDepartmentButton
            // 
            saveDepartmentButton.Location = new Point(239, 370);
            saveDepartmentButton.Name = "saveDepartmentButton";
            saveDepartmentButton.Size = new Size(112, 34);
            saveDepartmentButton.TabIndex = 10;
            saveDepartmentButton.Text = "Save";
            saveDepartmentButton.UseVisualStyleBackColor = true;
            saveDepartmentButton.Click += saveDepartmentButton_Click;
            // 
            // updateDepartmentButton
            // 
            updateDepartmentButton.Location = new Point(395, 370);
            updateDepartmentButton.Name = "updateDepartmentButton";
            updateDepartmentButton.Size = new Size(112, 34);
            updateDepartmentButton.TabIndex = 11;
            updateDepartmentButton.Text = "Update";
            updateDepartmentButton.UseVisualStyleBackColor = true;
            updateDepartmentButton.Click += updateDepartmentButton_Click;
            // 
            // dpt_DataGridView
            // 
            dpt_DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dpt_DataGridView.Location = new Point(442, 101);
            dpt_DataGridView.Name = "dpt_DataGridView";
            dpt_DataGridView.RowHeadersWidth = 62;
            dpt_DataGridView.RowTemplate.Height = 33;
            dpt_DataGridView.Size = new Size(360, 225);
            dpt_DataGridView.TabIndex = 12;
            dpt_DataGridView.SelectionChanged += dpt_DataGridView_SelectionChanged;
            // 
            // DepartmentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 450);
            Controls.Add(dpt_DataGridView);
            Controls.Add(updateDepartmentButton);
            Controls.Add(saveDepartmentButton);
            Controls.Add(addNewDepartmentButton);
            Controls.Add(priceDepartmentTextBox);
            Controls.Add(label5);
            Controls.Add(managerDepartmentTextBox);
            Controls.Add(label4);
            Controls.Add(nameDepartmentTextBox);
            Controls.Add(label3);
            Controls.Add(idDepartmentTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DepartmentForm";
            Text = "DepartmentForm";
            ((System.ComponentModel.ISupportInitialize)dpt_DataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox idDepartmentTextBox;
        private Label label3;
        private TextBox nameDepartmentTextBox;
        private Label label4;
        private TextBox managerDepartmentTextBox;
        private Label label5;
        private TextBox priceDepartmentTextBox;
        private Button addNewDepartmentButton;
        private Button saveDepartmentButton;
        private Button updateDepartmentButton;
        private DataGridView dpt_DataGridView;
    }
}