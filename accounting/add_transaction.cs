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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace accounting
{
    public partial class add_transaction : Form
    {
        private string login;
        public add_transaction(string login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void add_transaction_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void add_transaction_Load(object sender, EventArgs e)
        {
            myDB myDB = new myDB();
            DataTable categories = myDB.getCategories();
            if (categories == null) { MessageBox.Show("Something went wrong, try later"); Application.Exit(); }
            category.DataSource = categories;
            category.DisplayMember = "category_title"; 
            category.ValueMember = "category_id";
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string tl = tottal_sum.Text;
            string ca = category.SelectedValue.ToString();
            DateTime d = date.Value;
            string com = Comment.Text;

            int result;
            if (tl == "Total sum" || !int.TryParse(tl, out result))
            {
                MessageBox.Show("Введите полную стоимость");
                return;
            }
            if (ca == "Category")
            {
                MessageBox.Show("Введите категорию");
                return;
            }
            

            myDB myDB = new myDB();
            string user_id = myDB.getUserByLogin(this.login, "user_id");
            if (user_id == "")
            {
                MessageBox.Show("Возникли проблемы попробуйте позже");
                return;
            }

            bool ans = myDB.InsertTransaction(Int32.Parse(user_id), Int32.Parse(ca), Int32.Parse(tl), d, com);

            if (ans)
            {
                this.Hide();
                Home home = new Home(this.login);
                home.Show(); 
            }
            else
            {
                MessageBox.Show("Something went wrong, try later pls!)");
            }
        }

        private void tottal_sum_Enter(object sender, EventArgs e)
        {
            if (tottal_sum.Text == "Total sum")
                tottal_sum.Text = "";
        }

        private void tottal_sum_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tottal_sum.Text))
                tottal_sum.Text = "Total sum";
        }

        private void Comment_Enter(object sender, EventArgs e)
        {
            if (Comment.Text == "Comment")
                Comment.Text = "";
        }

        private void Comment_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Comment.Text))
                Comment.Text = "Comment";
        }

        private void main_form_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home(this.login);
            home.Show();
        }
    }
}
