using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrangDangNhap
{
    public partial class TrangDangKy : Form
    {
        public TrangDangKy()
        {
            InitializeComponent();
        }

        private void textBox1_Email_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_DangKy_Click(object sender, EventArgs e)
        {
            String email = textBox1_Email.Text;
            String password = textBox2_Password.Text;
            String patternPassword = @"^(?=.*[!@#$%^&*(),.?""{}|<>])[A-Za-z\d!@#$%^&*(),.?""{}|<>]{8,}$";
            string patternEmail = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            // Kiểm tra mật khẩu với regex
            
            if (Username_texBox.Text == "" || Regex.IsMatch(email, patternEmail) ==false || Regex.IsMatch(password, patternPassword) == false )
            {
                // Kiểm tra tên
                if (Username_texBox.Text == "")
                {
                    MessageBox.Show("Username không được bỏ trống.");
                    return;
                }
                // Kiểm tra email với regex
                else if (Regex.IsMatch(email, patternEmail) == false)                               
                {
                    MessageBox.Show("Email yêu cầu nhập đúng định dạng.");
                }
                else
                {
                    MessageBox.Show("Mật khẩu không hợp lệ. Yêu cầu tối thiểu 8 ký tự và phải bao gồm ít nhất 1 ký tự đặc biệt.");
                }                
            }
            else
            {
                MessageBox.Show("Đăng ký hoàn tất. Vui lòng đợi để chờ xác nhận !");
            }



        }

        private void Username_texBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void TrangDangKy_Load(object sender, EventArgs e)
        {
            Username_texBox.Focus();
        }
    }
}
