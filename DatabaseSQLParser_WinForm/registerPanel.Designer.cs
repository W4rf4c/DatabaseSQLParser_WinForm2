namespace DatabaseSQLParser_WinForm
{
    partial class registerPanel
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
            button_register = new Button();
            button_back = new Button();
            button_exit = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox_r_username = new TextBox();
            textBox_email = new TextBox();
            textBox_r_password = new TextBox();
            textBox_name = new TextBox();
            SuspendLayout();
            // 
            // button_register
            // 
            button_register.Location = new Point(255, 20);
            button_register.Name = "button_register";
            button_register.Size = new Size(75, 23);
            button_register.TabIndex = 0;
            button_register.Text = "Register";
            button_register.UseVisualStyleBackColor = true;
            button_register.Click += button_register_Click;
            // 
            // button_back
            // 
            button_back.Location = new Point(255, 49);
            button_back.Name = "button_back";
            button_back.Size = new Size(75, 49);
            button_back.TabIndex = 1;
            button_back.Text = "Back to login";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // button_exit
            // 
            button_exit.Location = new Point(255, 104);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(75, 23);
            button_exit.TabIndex = 2;
            button_exit.Text = "Exit";
            button_exit.UseVisualStyleBackColor = true;
            button_exit.Click += button_exit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 3;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 49);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 4;
            label2.Text = "Email address:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 75);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 5;
            label3.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 102);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 6;
            label4.Text = "Full name:";
            // 
            // textBox_r_username
            // 
            textBox_r_username.Location = new Point(93, 17);
            textBox_r_username.Name = "textBox_r_username";
            textBox_r_username.Size = new Size(156, 23);
            textBox_r_username.TabIndex = 7;
            // 
            // textBox_email
            // 
            textBox_email.Location = new Point(93, 46);
            textBox_email.Name = "textBox_email";
            textBox_email.Size = new Size(156, 23);
            textBox_email.TabIndex = 8;
            // 
            // textBox_r_password
            // 
            textBox_r_password.Location = new Point(93, 75);
            textBox_r_password.Name = "textBox_r_password";
            textBox_r_password.Size = new Size(156, 23);
            textBox_r_password.TabIndex = 9;
            // 
            // textBox_name
            // 
            textBox_name.Location = new Point(93, 104);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(156, 23);
            textBox_name.TabIndex = 10;
            // 
            // registerPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 133);
            Controls.Add(textBox_name);
            Controls.Add(textBox_r_password);
            Controls.Add(textBox_email);
            Controls.Add(textBox_r_username);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button_exit);
            Controls.Add(button_back);
            Controls.Add(button_register);
            Name = "registerPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "registerPanel";
            Load += registerPanel_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_register;
        private Button button_back;
        private Button button_exit;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox_r_username;
        private TextBox textBox_email;
        private TextBox textBox_r_password;
        private TextBox textBox_name;
    }
}