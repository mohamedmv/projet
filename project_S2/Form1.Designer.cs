
namespace project_S2
{
    partial class Form1
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
            this.Username_lable = new System.Windows.Forms.Label();
            this.Password_label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Show_password_checkBox = new System.Windows.Forms.CheckBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Username_lable
            // 
            this.Username_lable.AutoSize = true;
            this.Username_lable.Location = new System.Drawing.Point(69, 46);
            this.Username_lable.Name = "Username_lable";
            this.Username_lable.Size = new System.Drawing.Size(60, 15);
            this.Username_lable.TabIndex = 0;
            this.Username_lable.Text = "Username";
            this.Username_lable.Click += new System.EventHandler(this.label1_Click);
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Location = new System.Drawing.Point(69, 80);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(57, 15);
            this.Password_label.TabIndex = 1;
            this.Password_label.Text = "Password";
            this.Password_label.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(170, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 23);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(170, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Show_password_checkBox
            // 
            this.Show_password_checkBox.AutoSize = true;
            this.Show_password_checkBox.Location = new System.Drawing.Point(170, 110);
            this.Show_password_checkBox.Name = "Show_password_checkBox";
            this.Show_password_checkBox.Size = new System.Drawing.Size(108, 19);
            this.Show_password_checkBox.TabIndex = 6;
            this.Show_password_checkBox.Text = "Show password";
            this.Show_password_checkBox.UseVisualStyleBackColor = true;
            this.Show_password_checkBox.CheckedChanged += new System.EventHandler(this.Show_password_checkBox_CheckedChanged);
            // 
            // password_textBox
            // 
            this.password_textBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.password_textBox.Location = new System.Drawing.Point(170, 77);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(168, 23);
            this.password_textBox.TabIndex = 7;
            this.password_textBox.UseSystemPasswordChar = true;
            this.password_textBox.TextChanged += new System.EventHandler(this.password_textBox_TextChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.Show_password_checkBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.Username_lable);
            this.Name = "Form1";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Username_lable;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox Show_password_checkBox;
        private System.Windows.Forms.TextBox password_textBox;
    }
}

