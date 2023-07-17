using System;
using System.Windows.Forms;

namespace Example01
{
    public partial class dangky : Form
    {
        public dangky()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            string gender = "";
            if (rbMale.Checked)
                gender = "Nam";
            else if (rbFemale.Checked)
                gender = "Bà";
            string email = txtEmail.Text;
            string phoneNumber = txtPhoneNumber.Text;

            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu không khớp. Vui lòng nhập lại!");
                return;
            }

            MessageBox.Show("Đăng ký thành công!");

            dangnhap form2 = new dangnhap(username, password);
            form2.ShowDialog();
        }
    }
}