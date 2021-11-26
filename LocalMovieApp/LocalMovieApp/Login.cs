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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private readonly Controller controller = new Controller();
        private void Login_Load(object sender, EventArgs e)
        {
            tb_password.PasswordChar = '•';
            cb_showPassword.Checked = true;
        }

        private void cb_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            tb_password.PasswordChar = cb_showPassword.Checked ? '\0' : '•';
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            string username = tb_username.Text.Trim();
            string password = tb_password.Text.Trim();
            if (!(String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password)))
            {

                LoginModel lm = new LoginModel()
                {
                    Username = username,
                    Password = password,
                };
                btn_login.IsAccessible = false;
                bool isLoggedIn = controller.LoginUser(lm);
                if (isLoggedIn)
                {
                    if (username == "hashimlijr")
                    {
                        //MessageBox.Show("You are the king. Welcome!");
                        Main main = new Main();
                        main.Show();
                        this.Hide();
                    }
                    else
                    {
                        //MessageBox.Show("You are just user! Logged in");
                        string name = controller.GetUserData(username, "Name");
                        int id = int.Parse(controller.GetUserData(username, "Id"));
                        UserMain usermain = new UserMain(name, id);
                        usermain.Show();
                        this.Hide();
                    }
                    
                }
                else
                {
                    sb.Append("Username or password is wrong.");
                    btn_login.IsAccessible = true;
                }

            }
            else sb.Append("Fill all fields.");
            lbl_status.ForeColor = Color.Maroon;
            lbl_status.Text = sb.ToString();
        }

        private void link_register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
