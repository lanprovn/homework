using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Example01
{
    public partial class dangnhap : Form
    {
        private string username;
        private string password;
        private string gender;
        private string email;
        private string phoneNumber;

        public dangnhap(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string enteredUsername = txtUsername.Text;
            string enteredPassword = txtPassword.Text;

            if (enteredUsername == username && enteredPassword == password)
            {
                MessageBox.Show("Đăng nhập thành công!");

                thongtin form3 = new thongtin(username, gender, email, phoneNumber);
                form3.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sai thông tin đăng nhập!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}