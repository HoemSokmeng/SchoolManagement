namespace SchoolManagement
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            label2 = new Label();
            usernameTextBox = new TextBox();
            label3 = new Label();
            passwordTextBox = new TextBox();
            loginButton = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(258, 48);
            label1.Name = "label1";
            label1.Size = new Size(262, 60);
            label1.TabIndex = 0;
            label1.Text = "Login Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 161);
            label2.Name = "label2";
            label2.Size = new Size(148, 38);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(228, 158);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(150, 45);
            usernameTextBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 244);
            label3.Name = "label3";
            label3.Size = new Size(138, 38);
            label3.TabIndex = 3;
            label3.Text = "Password:";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(228, 241);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '•';
            passwordTextBox.Size = new Size(150, 45);
            passwordTextBox.TabIndex = 4;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(228, 343);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(112, 54);
            loginButton.TabIndex = 5;
            loginButton.Text = "Login ";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(424, 122);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(322, 322);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 477);
            Controls.Add(pictureBox1);
            Controls.Add(loginButton);
            Controls.Add(passwordTextBox);
            Controls.Add(label3);
            Controls.Add(usernameTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "LoginForm";
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox usernameTextBox;
        private Label label3;
        private TextBox passwordTextBox;
        private Button loginButton;
        private PictureBox pictureBox1;
    }
}