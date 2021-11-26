using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocalMovieApp
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private readonly Controller controller = new Controller();
        private void btn_register_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            string name = tb_name.Text.Trim();
            string surname = tb_surname.Text.Trim();
            string username = tb_username.Text.Trim();
            string password = tb_password.Text.Trim();
            string passwordAgain = tb_passwordConfirmation.Text.Trim();

            if (!(String.IsNullOrEmpty(Name) || String.IsNullOrEmpty(surname) || String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password)))
            {
                if (password.Length >= 6)
                {
                    if (String.Equals(password, passwordAgain))
                    {

                        RegisterModel user = new RegisterModel()
                        {
                            Name = name,
                            Surname = surname,
                            Username = username,
                            Password = password,
                        };
                        bool isRegistered = controller.AddUser(user);
                        if (isRegistered)
                        {
                            MessageBox.Show("Registered.");
                            Login login = new Login();
                            login.Show();
                            this.Hide();
                        }
                        else sb.Append("This username has already registered.");
                    }
                    else sb.Append("Passwords not match.");
                }
                else sb.Append("Password must be at least 6 character.");
            }
            else sb.Append("Fill all fields.");

            lbl_status.Text = sb.ToString();
            lbl_status.ForeColor = Color.Maroon;
        }

        private void Register_Load(object sender, EventArgs e)
        {
            tb_password.PasswordChar = '•';
            tb_passwordConfirmation.PasswordChar = '•';
            cb_showPassword.Checked = true;
        }

        private void cb_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            tb_password.PasswordChar = cb_showPassword.Checked ? '\0' : '•';
            tb_passwordConfirmation.PasswordChar = cb_showPassword.Checked ? '\0' : '•';
        }

        private void link_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
