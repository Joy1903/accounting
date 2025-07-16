using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace accounting
{
    internal class myDB
    {
        private MySqlConnection connection;
        private MySqlDataAdapter adapter;
        private MySqlCommandBuilder builder;
        public myDB() {
            this.connection = new MySqlConnection("server =localhost;port=3306;username=root;password=root;database=house_accounting");
        }


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
            MySqlCommand command = new MySqlCommand("SELECT COUNT(*) FROM users WHERE login = @L", this.getConnection());
            command.Parameters.Add("@L", MySqlDbType.VarChar).Value = login;

            this.openConnection();
            int count = Convert.ToInt32(command.ExecuteScalar());
            this.closeConnection();

            return count > 0;
        }
        public bool check_user(string login, string password)
        {
            MySqlCommand command = new MySqlCommand("SELECT COUNT(*) FROM users WHERE login = @L AND password = @P", this.getConnection());
            command.Parameters.Add("@L", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@P", MySqlDbType.VarChar).Value = password;

            this.openConnection();
            int count = Convert.ToInt32(command.ExecuteScalar());
            this.closeConnection();

            return count > 0;
        }
        public bool Insert_user(string login, string password, string full_name)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `Password`, `full_name`) VALUES (@L, @P, @FL)", this.getConnection());
            command.Parameters.Add("@L", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@P", MySqlDbType.VarChar).Value = password;
            command.Parameters.Add("@FL", MySqlDbType.VarChar).Value = full_name;
            try
            {
                this.openConnection();
                int answer = command.ExecuteNonQuery();
                this.closeConnection();

                return answer == 1;
            }
            catch (Exception ex)
            {
                this.closeConnection(); 
                Console.WriteLine("ошибка при добавлении пользователя: " + ex.Message);
                return false;
            }

        }
        public string getUserByLogin(string login, string filed) {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @L", this.getConnection());
            command.Parameters.Add("@L", MySqlDbType.VarChar).Value = login;
            DataTable dt = new DataTable();
            try
            {
                this.openConnection();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    dt.Load(reader);
                }
                this.closeConnection();
            }
            catch (Exception ex)
            {
                this.closeConnection();
                Console.WriteLine("Ошибка: " + ex.Message);
                return "";
            }

            if (dt.Rows.Count > 0 && dt.Columns.Contains(filed))
            {
                return dt.Rows[0][filed].ToString();
            }
            return "";
        }
        public DataTable getAllTransactions() {
            MySqlCommand command = new MySqlCommand("SELECT users.login as User, categories.category_title as Category, CASE WHEN categories.category_type = 1 THEN 'Доход' WHEN categories.category_type = 0 THEN 'Расход' END AS Type, transactions.total_sum as Sum, transactions.date as Date, transactions.comment as Comments FROM `transactions` INNER JOIN `users` ON transactions.user_id = users.user_id INNER JOIN `categories` ON transactions.category_id = categories.category_id", this.getConnection());
            try
            {
                this.openConnection();
                MySqlDataReader reader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                reader.Close();
                this.closeConnection();

                return dt.Rows.Count > 0 ? dt : null;
            }
            catch (Exception ex)
            {
                this.closeConnection(); 
                Console.WriteLine("ошибка при чтении данных: " + ex.Message);
                return null;
            }
        }
        public DataTable getCategories() {
            this.adapter = new MySqlDataAdapter("SELECT category_id, category_title, CASE WHEN category_type = 1 THEN 'Доход' WHEN category_type = 0 THEN 'Расход' END AS category_type FROM `categories`", this.getConnection());
            this.builder = new MySqlCommandBuilder(this.adapter);
            DataTable dt = new DataTable();
            this.openConnection();
            this.adapter.Fill(dt);
            this.closeConnection();
            if (dt.Rows.Count > 0)
                return dt;
            return null;
        }
        public bool UpdateCategories(DataTable dt)
        {
            this.adapter = new MySqlDataAdapter("SELECT * FROM `categories`", this.getConnection());
            this.builder = new MySqlCommandBuilder(this.adapter);
            try
            {
                this.openConnection();
                this.adapter.Update(dt);
                this.closeConnection();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ошибка при сохранении: " + ex.Message);
                return false;
            }
        }
        public bool InsertTransaction(int user_id, int category_id, int total_sum, DateTime date, string text)
        {
            
            MySqlCommand command = new MySqlCommand("INSERT INTO `transactions` (`user_id`, `category_id`, `total_sum`, `date`, `comment`) VALUES (@U, @C, @TS, @D, @Com)", this.getConnection());
            command.Parameters.Add("@U", MySqlDbType.Int64).Value = user_id;
            command.Parameters.Add("@C", MySqlDbType.Int64).Value = category_id;
            command.Parameters.Add("@TS", MySqlDbType.Decimal).Value = total_sum;
            command.Parameters.Add("@D", MySqlDbType.Date).Value = date.Date;
            command.Parameters.Add("@Com", MySqlDbType.VarChar).Value = text;
            try
            {
                this.openConnection();
                int answer = command.ExecuteNonQuery();
                this.closeConnection();

                return answer == 1;
            }
            catch (Exception ex)
            {
                this.closeConnection();
                Console.WriteLine("ошибка при добавлении транзакции: " + ex.Message);
                return false;
            }
        }
        
        public DataTable getAllTransactionsOfUser(string login)
        {
            MySqlCommand command = new MySqlCommand("SELECT users.login as User, categories.category_title as Category, CASE WHEN categories.category_type = 1 THEN 'Доход' WHEN categories.category_type = 0 THEN 'Расход' END AS Type, transactions.total_sum as Sum, transactions.date as Date, transactions.comment FROM `transactions`INNER JOIN `users` ON transactions.user_id = users.user_id INNER JOIN `categories` ON transactions.category_id = categories.category_id WHERE users.login = @L", this.getConnection());
            command.Parameters.Add("@L", MySqlDbType.VarString).Value = login;
            this.openConnection();
            MySqlDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            this.closeConnection();
            if (dt.Rows.Count > 0)
            {
                return dt;
            }
            return null;
        }
        public DataTable getAllTransactionByCategory(string category)
        {
            MySqlCommand command = new MySqlCommand("SELECT users.login as User, categories.category_title as Category, CASE WHEN categories.category_type = 1 THEN 'Доход' WHEN categories.category_type = 0 THEN 'Расход' END AS Type, transactions.total_sum as Sum, transactions.date as Date, transactions.comment FROM `transactions`INNER JOIN `users` ON transactions.user_id = users.user_id INNER JOIN `categories` ON transactions.category_id = categories.category_id  WHERE categories.category_title = @C", this.getConnection());
            command.Parameters.Add("@C", MySqlDbType.VarString).Value = category;
            this.openConnection();
            MySqlDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            this.closeConnection();
            return dt.Rows.Count > 0 ? dt : null;
        }
        public bool check_category(string category)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `categories` WHERE `category_title` = @CT", this.getConnection());
            command.Parameters.Add("@CT", MySqlDbType.VarChar).Value = category;
            adapter.SelectCommand = command;
            adapter.Fill(dt);

            return dt.Rows.Count > 0;

        }
        public bool InsertCategory(string category_title, bool type)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `categories` (`category_id`, `category_title`, `category_type`) VALUES (NULL, @CT, @T);", this.getConnection());
            command.Parameters.Add("@CT", MySqlDbType.VarChar).Value = category_title;
            command.Parameters.Add("@T", MySqlDbType.Int64).Value = type;

            try
            {
                this.openConnection();
                int answer = command.ExecuteNonQuery();
                this.closeConnection();
                return answer == 1;
            }
            catch (Exception ex)
            {
                this.closeConnection(); 
                Console.WriteLine("ошибка при добавлении категории: " + ex.Message);
                return false;
            }
        }
        public bool deleteCategory(int category_id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `categories` WHERE `category_id` = @CI", this.getConnection());
            command.Parameters.Add("@CI", MySqlDbType.Int64).Value = category_id;

            try
            {
                this.openConnection();
                int answer = command.ExecuteNonQuery();
                this.closeConnection();
                return answer == 1;
            }
            catch (Exception ex)
            {
                this.closeConnection();
                Console.WriteLine("ошибка при удалении категории: " + ex.Message);
                return false;
            }
        }
    }

}
