using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace accounting
{
    public partial class Home : Form
    {
        private string login;
        private DataTable dt;
        public Home(string login)
        {
            this.login = login;
            InitializeComponent();
        }
        private void getAllTransactionTable()
        {
            myDB db = new myDB(); 
            DataTable dt = new DataTable(); 
            dt = db.getAllTransactions();
            if (dt != null)
            {
                this.dt = dt;
            } else
            {
                this.dt = null;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            add_transaction form = new add_transaction(this.login);   
            form.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            myDB db = new myDB();
            string name = db.getUserByLogin(this.login, "full_name");
            this.getAllTransactionTable();

            DataTable categories = db.getCategories();
            if (categories == null) { MessageBox.Show("Something went wrong, try later"); Application.Exit(); }
            DataRow allRow = categories.NewRow();
            allRow["category_title"] = "Все категории";
            allRow["category_id"] = -1;
            allRow["category_type"] = "Расход";
            categories.Rows.InsertAt(allRow, 0);
            
            category.DataSource = categories;
            category.DisplayMember = "category_title";
            category.ValueMember = "category_id";

            if (name != "")
            {
                user_login.Text =  "Helloo "+name;
            }
            if (this.dt != null) {
                dataGridView1.DataSource = this.dt;
                dataGridView1.Columns["Sum"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridView1.Columns["Sum"].DefaultCellStyle.Format = "N2";
                return;
            }
            MessageBox.Show("Something went wrong, try later pls!)");
            Application.Exit();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); 
        }

        private void sort_by_date_Click(object sender, EventArgs e)
        {
            this.dt.DefaultView.Sort = "Date";
        }

        private void sort_by_user_Click(object sender, EventArgs e)
        {
            this.dt.DefaultView.Sort = "User";
        }

        private void sort_by_category_Click(object sender, EventArgs e)
        {
            this.dt.DefaultView.Sort = "Category";
        }

        private void user_login_Click(object sender, EventArgs e)
        {
            myDB db = new myDB();
            this.dt = db.getAllTransactionsOfUser(this.login);
            if (this.dt != null)
            {
                dataGridView1.DataSource = this.dt;
                return;
            }
            MessageBox.Show("There is not your transactions");
        }

        private void Home_ResizeEnd(object sender, EventArgs e)
        {
            label1.Left = (this.ClientSize.Width - label1.Width) / 2;

        }

        private void category_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView selectedRow = category.SelectedItem as DataRowView;
            if (selectedRow != null)
            {
                string ct = selectedRow["category_title"].ToString();
                myDB db = new myDB();
                if (ct == "Все категории") {
                    this.dt = db.getAllTransactions();
                }else
                {
                    this.dt = db.getAllTransactionByCategory(ct);
                }
                if (this.dt != null)
                {
                    dataGridView1.DataSource = this.dt;
                    return;
                }
            }
            MessageBox.Show("There is not transaction with this category");
        }

        private void add_category_Click(object sender, EventArgs e)
        {
            this.Hide();
            add_category ac = new add_category(this.login);
            ac.Show();
        }
    }
}
