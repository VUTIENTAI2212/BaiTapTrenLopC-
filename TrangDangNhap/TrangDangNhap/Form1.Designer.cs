namespace TrangDangNhap
{
    partial class TrangDangKy
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
            this.label1 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.textBox1_Email = new System.Windows.Forms.TextBox();
            this.textBox2_Password = new System.Windows.Forms.TextBox();
            this.button1_DangKy = new System.Windows.Forms.Button();
            this.Username_texBox = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG KÝ";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(53, 206);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(88, 36);
            this.Email.TabIndex = 1;
            this.Email.Text = "Email";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(53, 273);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(147, 36);
            this.Password.TabIndex = 2;
            this.Password.Text = "Password";
            // 
            // textBox1_Email
            // 
            this.textBox1_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1_Email.Location = new System.Drawing.Point(244, 203);
            this.textBox1_Email.Multiline = true;
            this.textBox1_Email.Name = "textBox1_Email";
            this.textBox1_Email.Size = new System.Drawing.Size(508, 39);
            this.textBox1_Email.TabIndex = 3;
            this.textBox1_Email.TextChanged += new System.EventHandler(this.textBox1_Email_TextChanged);
            // 
            // textBox2_Password
            // 
            this.textBox2_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2_Password.Location = new System.Drawing.Point(244, 270);
            this.textBox2_Password.Multiline = true;
            this.textBox2_Password.Name = "textBox2_Password";
            this.textBox2_Password.Size = new System.Drawing.Size(508, 39);
            this.textBox2_Password.TabIndex = 4;
            // 
            // button1_DangKy
            // 
            this.button1_DangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_DangKy.Location = new System.Drawing.Point(271, 352);
            this.button1_DangKy.Name = "button1_DangKy";
            this.button1_DangKy.Size = new System.Drawing.Size(267, 51);
            this.button1_DangKy.TabIndex = 5;
            this.button1_DangKy.Text = "Đăng Ký";
            this.button1_DangKy.UseVisualStyleBackColor = true;
            this.button1_DangKy.Click += new System.EventHandler(this.button1_DangKy_Click);
            // 
            // Username_texBox
            // 
            this.Username_texBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_texBox.Location = new System.Drawing.Point(244, 144);
            this.Username_texBox.Multiline = true;
            this.Username_texBox.Name = "Username_texBox";
            this.Username_texBox.Size = new System.Drawing.Size(508, 39);
            this.Username_texBox.TabIndex = 7;
            this.Username_texBox.TextChanged += new System.EventHandler(this.Username_texBox_TextChanged);
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(53, 147);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(150, 36);
            this.Username.TabIndex = 6;
            this.Username.Text = "Username";
            // 
            // TrangDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(819, 460);
            this.Controls.Add(this.Username_texBox);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.button1_DangKy);
            this.Controls.Add(this.textBox2_Password);
            this.Controls.Add(this.textBox1_Email);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.label1);
            this.Name = "TrangDangKy";
            this.Text = "Trang Đăng Ký";
            this.Load += new System.EventHandler(this.TrangDangKy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox textBox1_Email;
        private System.Windows.Forms.TextBox textBox2_Password;
        private System.Windows.Forms.Button button1_DangKy;
        private System.Windows.Forms.TextBox Username_texBox;
        private System.Windows.Forms.Label Username;
    }
}

