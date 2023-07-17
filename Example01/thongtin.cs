using System;
using System.Windows.Forms;

namespace Example01
{
    public partial class thongtin : Form
    {
        private string username;
        private string gender;
        private string email;
        private string phoneNumber;

        public thongtin(string username, string gender, string email, string phoneNumber)
        {
            InitializeComponent();
            this.username = username;
            this.gender = gender;
            this.email = email;
            this.phoneNumber = phoneNumber;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (gender == "Nam")
            {
                lblGreeting.Text = "Xin chào Ông " + username;
            }
            else if (gender == "Bà")
            {
                lblGreeting.Text = "Xin chào Bà " + username;
            }

            lblEmail.Text = "Email: " + email;
            lblPhoneNumber.Text = "Phone Number: " + phoneNumber;
        }
    }
}