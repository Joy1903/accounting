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
    public partial class add_category : Form
    {

        private DataTable dt;
        private string login;
        private void getAllCategories()
        {
            myDB db = new myDB();
            DataTable dt = new DataTable();
            dt = db.getCategories();
            if (dt != null)
            {
                this.dt = dt;
            }
            else
            {
                MessageBox.Show("Something went wrong, try later");
                Application.Exit();
            }
        }
        public add_category(string login)
        {
            this.login = login;
            InitializeComponent();
        }

        private void add_category_Load(object sender, EventArgs e)
        {
            this.getAllCategories();
            categories_table.DataSource = this.dt;

            combo_to_delete.DataSource = this.dt;
            combo_to_delete.DisplayMember = "category_title";
            combo_to_delete.ValueMember = "category_id";

            var type_d = new Dictionary<string, bool>
            {
                { "Доход", true },
                { "Расход", false }
            };

            type.DataSource = new BindingSource(type_d, null);
            type.DisplayMember = "Key";
            type.ValueMember = "Value";


        }
        private void add_Click(object sender, EventArgs e)
        {
            string title = category_title.Text;
            bool type_v = (bool)type.SelectedValue;

            myDB db = new myDB();

            if (title == "Name of category")
            {
                MessageBox.Show("Enter name of category");
                return;
            }
            if (!db.check_category(title))
            {
                if (db.InsertCategory(title, type_v))
                {
                    this.add_category_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Something went wrong, try later");
                }
            } else{
                MessageBox.Show("This category already exists");
            }

        }

        private void delete_category_Click(object sender, EventArgs e)
        {
            int category_id = (int)combo_to_delete.SelectedValue;

            myDB db = new myDB();
            
            if(db.deleteCategory(category_id))
            {
                this.add_category_Load(sender, e);  
            } else
            {
                MessageBox.Show("Something went wrong, pls try latere ");
            }

        }


        private void add_category_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void category_title_Enter(object sender, EventArgs e)
        {
            if (category_title.Text == "Name of category")
                category_title.Text = "";
        }

        private void category_title_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(category_title.Text))
            {
                category_title.Text = "Name of category";
            }
        }

        private void back_home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home(this.login);
            home.Show();
        }
    }
}
