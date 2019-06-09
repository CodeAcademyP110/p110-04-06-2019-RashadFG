using System;
using System.Windows.Forms;

namespace _07._06._19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chcBox_CheckedChanged(object sender, EventArgs e)
        {
            if (chcBox.Checked)
            {
                ttxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                ttxPassword.UseSystemPasswordChar = true;
            }
        }

        Admin admin = new Admin()
        {
            Name = "Samir",
            Password = "Samir123"
        };

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string username = txtUseName.Text.Trim();
            string password = ttxPassword.Text.Trim();

            Admin admin = new Admin()
            {
                Name = "Samir",
                Password = "Samir123"
            };

            #region Validation
            if (username == string.Empty)
            {
                MessageBox.Show("Your username is empty", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password == string.Empty)
            {
                MessageBox.Show("Your password is empty", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtUseName.Text != admin.Name || ttxPassword.Text != admin.Password)
            {
                MessageBox.Show("Please input valid Username or Password", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion

            new Form2().ShowDialog();
            ReserUsernameANDpassword();
        }

        private void ReserUsernameANDpassword()
        {
            txtUseName.Text = ttxPassword.Text = string.Empty;
        }

    }
}
