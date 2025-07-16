using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace accounting
{
    internal class myDB
    {
        MySqlConnection connection = new MySqlConnection("server =localhost;port=3306;username=root;password=root;database=house_accounting");


        public void openConnection() {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        public void closeConnection() {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        public MySqlConnection getConnection() {
            return connection;
        }
        public bool check_user_exist(string login)
        {
            myDB db = new myDB();
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @L", db.getConnection());
            command.Parameters.Add("@L", MySqlDbType.VarChar).Value = login;

            adapter.SelectCommand = command;
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
                return true;
            else
                return false;

        }
        public bool check_user(string login, string password)
        {
            myDB db = new myDB();
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @L AND `Password` = @P", db.getConnection());
            command.Parameters.Add("@L", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@P", MySqlDbType.VarChar).Value = password;
            adapter.SelectCommand = command;
            adapter.Fill(dt);


            if (dt.Rows.Count > 0)
                return true;
            else
                return false;

        }
        public bool Insert_user(string login, string password, string full_name)
        {
            myDB db = new myDB();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`user_id`, `login`, `Password`, `full_name`) VALUES (NULL, @L, @P, @FL)", db.getConnection());
            command.Parameters.Add("@L", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@P", MySqlDbType.VarChar).Value = password;
            command.Parameters.Add("@FL", MySqlDbType.VarChar).Value = full_name;

            db.openConnection();
            int answer = command.ExecuteNonQuery();
            db.closeConnection();
            if (answer == 1)
            {
                return true;
            } else
            {
                return false;
            }

        }
        public string getUserByLogin(string login, string filed) {
            myDB db = new myDB();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @L", db.getConnection());
            command.Parameters.Add("@L", MySqlDbType.VarChar).Value = login;
            db.openConnection();
            MySqlDataReader reader = command.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);
            db.closeConnection();
            if (dt.Rows.Count > 0) {
                return dt.Rows[0][filed].ToString();
            }
            return "";
        }
        public DataTable getAllTransactions() {
            myDB db = new myDB();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT users.login as User, categories.category_title as Category, CASE WHEN categories.category_type = 1 THEN 'Доход' WHEN categories.category_type = 0 THEN 'Расход' END AS Type, transactions.total_sum as Sum, transactions.date as Date, transactions.comment as Comments FROM `transactions` INNER JOIN `users` ON transactions.user_id = users.user_id INNER JOIN `categories` ON transactions.category_id = categories.category_id", db.getConnection());
            db.openConnection();
            MySqlDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            db.closeConnection();
            if (dt.Rows.Count > 0)
            {
                return dt;
            }
            return null;
        }
        public DataTable getCategories() { 
            myDB db = new myDB();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT category_id, category_title, CASE WHEN category_type = 1 THEN 'Доход' WHEN category_type = 0 THEN 'Расход' END AS Type FROM `categories`", db.getConnection());
            db.openConnection();
            MySqlDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            db.closeConnection();
            if (dt.Rows.Count > 0)
                return dt;
            return null;
        }
        public bool InsertTransaction(int user_id, int category_id, int total_sum, DateTime date, string text)
        {
            myDB db = new myDB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `transactions` (`transaction_id`, `user_id`, `category_id`, `total_sum`, `date`, `comment`) VALUES (NULL, @U, @C, @TS, @D, @Com)", db.getConnection());
            command.Parameters.Add("@U", MySqlDbType.Int64).Value = user_id;
            command.Parameters.Add("@C", MySqlDbType.Int64).Value = category_id;
            command.Parameters.Add("@TS", MySqlDbType.Decimal).Value = total_sum;
            command.Parameters.Add("@D", MySqlDbType.Date).Value = date.Date;
            command.Parameters.Add("@Com", MySqlDbType.VarChar).Value = text;
            db.openConnection();
            int answer = command.ExecuteNonQuery();
            db.closeConnection();
            if (answer == 1)
                return true;
            return false;
        }
        
        public DataTable getAllTransactionsOfUser(string login)
        {
            myDB db = new myDB();
            MySqlCommand command = new MySqlCommand("SELECT users.login as User, categories.category_title as Category, CASE WHEN categories.category_type = 1 THEN 'Доход' WHEN categories.category_type = 0 THEN 'Расход' END AS Type, transactions.total_sum as Sum, transactions.date as Date, transactions.comment FROM `transactions`INNER JOIN `users` ON transactions.user_id = users.user_id INNER JOIN `categories` ON transactions.category_id = categories.category_id HAVING User = @L", db.getConnection());
            command.Parameters.Add("@L", MySqlDbType.VarString).Value = login;
            db.openConnection();
            MySqlDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            db.closeConnection();
            if (dt.Rows.Count > 0)
            {
                return dt;
            }
            return null;
        }
        public DataTable getAllTransactionByCategory(string category)
        {
            myDB db = new myDB();
            MySqlCommand command = new MySqlCommand("SELECT users.login as User, categories.category_title as Category, CASE WHEN categories.category_type = 1 THEN 'Доход' WHEN categories.category_type = 0 THEN 'Расход' END AS Type, transactions.total_sum as Sum, transactions.date as Date, transactions.comment FROM `transactions`INNER JOIN `users` ON transactions.user_id = users.user_id INNER JOIN `categories` ON transactions.category_id = categories.category_id HAVING Category = @C", db.getConnection());
            command.Parameters.Add("@C", MySqlDbType.VarString).Value = category;
            db.openConnection();
            MySqlDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            db.closeConnection();
            if (dt.Rows.Count > 0)
            {
                return dt;
            }
            return null;
        }
        public bool check_category(string category)
        {
            myDB db = new myDB();
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `categories` WHERE `category_title` = @CT", db.getConnection());
            command.Parameters.Add("@CT", MySqlDbType.VarChar).Value = category;
            adapter.SelectCommand = command;
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
                return true;
            else
                return false;

        }
        public bool InsertCategory(string category_title, bool type)
        {
            myDB db = new myDB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `categories` (`category_id`, `category_title`, `category_type`) VALUES (NULL, @CT, @T);", db.getConnection());
            command.Parameters.Add("@CT", MySqlDbType.VarChar).Value = category_title;
            command.Parameters.Add("@T", MySqlDbType.Int64).Value = type;
            
            db.openConnection();
            int answer = command.ExecuteNonQuery();
            db.closeConnection();
            if (answer == 1)
                return true;
            return false;
        }
        public bool deleteCategory(int category_id)
        {
            myDB db = new myDB();
            MySqlCommand command = new MySqlCommand("DELETE FROM `categories` WHERE `category_id` = @CI", db.getConnection());
            command.Parameters.Add("@CI", MySqlDbType.Int64).Value = category_id;

            db.openConnection();
            int answer = command.ExecuteNonQuery();
            db.closeConnection();
            if (answer == 1)
                return true;
            return false;
        }
    }

}
