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
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = Login.Text;
            string password = Password.Text;

            if (string.IsNullOrEmpty(login)) {
                MessageBox.Show("Enter your login");
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Enter your password");
                return;
            }

            myDB db = new myDB();
            
            
            if (db.check_user(login, password))
            {
                this.Hide();
                Home home = new Home(login);
                home.Show();
            }else
                MessageBox.Show("Login or Password is inccorect");
               
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.Black;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Violet;
            button1.ForeColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.CornflowerBlue;
            button1.ForeColor = Color.Black;
        }
        Point CurrentPoint;
        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) { 
                this.Left += e.X - CurrentPoint.X;
                this.Top += e.Y - CurrentPoint.Y;
            }
        }

        private void Login_Enter(object sender, EventArgs e)
        {
            if (Login.Text == "Login")
                Login.Text = "";
        }

        private void Login_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Login.Text)) {
                Login.Text = "Login";
            }
        }

        private void Password_Enter(object sender, EventArgs e)
        {
            if(Password.Text == "Password")
                Password.Text = "";
        }

        private void Password_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Password.Text)) { 
                Password.Text = "Password"; 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {   
            this.Hide();    
            registration reg = new registration();
            reg.Show();
        }

        private void login_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); 
        }
    }
}
