using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace accounting
{
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
        }
        private bool perm_to_reg = false;   
        private void full_name_Enter(object sender, EventArgs e)
        {
            if (full_name.Text == "Full Name")
                full_name.Text = "";
        }

        private void full_name_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(full_name.Text))
            {
                full_name.Text = "Full Name";
            }
        }

        private void Login_Enter(object sender, EventArgs e)
        {
            if (Login.Text == "Login")
                Login.Text = "";
        }

        private void Login_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Login.Text))
            {
                Login.Text = "Login";
            }
        }

        private void Password_Enter(object sender, EventArgs e)
        {
            if (Password.Text == "Password")
                Password.Text = "";
        }

        private void Password_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Password.Text))
            {
                Password.Text = "Password";
            }
        }

       

        private void reg_Click(object sender, EventArgs e)
        {
            string fn = full_name.Text;
            string log = Login.Text;    
            string pass = Password.Text;    

            if(fn == "Full Name")
            {
                MessageBox.Show("Введите полное имя");
                return;
            }
            if (log == "Login")
            {
                MessageBox.Show("Введите логин");
                return;
            }
            if (pass == "Password")
            {
                MessageBox.Show("Введите пароль");
                return;
            }
            
            if (perm_to_reg)
            {
                myDB dB = new myDB();
                bool ans = dB.Insert_user(log,pass,fn);
                if (ans) {
                    this.Hide();    
                    Home home = new Home(log); 
                    home.Show();
                }else
                {
                    MessageBox.Show("Something went wrong, try later pls!)");
                }
            }
        }

        private void Login_TextChanged(object sender, EventArgs e)
        {
            string login = Login.Text;

            myDB dB = new myDB();
            if (!dB.check_user_exist(login))
            {
                perm_to_reg = true;
                Login.ForeColor = Color.Green;
            }
            else
            {
                perm_to_reg = false;
                Login.ForeColor = Color.Red;
            }
             
        }

        private void registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
