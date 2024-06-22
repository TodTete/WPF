using MySql.Data.MySqlClient;
using System.Collections.ObjectModel;
using System.Configuration;
using WpfApp1.Models;

namespace WpfApp1.db
{
    internal class BD
    {
        private readonly string _connection;

        public string Conexion => _connection;

        public BD()
        {
            _connection = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
        }

        internal ObservableCollection<UserModel> Get()
        {
            ObservableCollection<UserModel> lstResult = new ObservableCollection<UserModel>();
            string query = "SELECT * from users";
            using (MySqlConnection cn = new MySqlConnection(Conexion))
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand(query, cn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lstResult.Add(new UserModel()
                    {
                        Id = reader.GetInt32("Id"),
                        Name = reader.GetString("Name"),
                        Surnames = reader.GetString("Surnames"),
                        Email = reader.GetString("Email"),
                        Password = reader.GetString("Password")
                    });
                }
                reader.Close();
                cn.Close();
            }
            return lstResult;
        }

        internal void Add(UserModel user)
        {
            string query = "INSERT INTO users (Id, Name, Surnames, Email, Password) VALUES (@Id, @Name, @Surnames, @Email, @Password);";
            using (MySqlConnection cn = new MySqlConnection(Conexion))
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@Id", user.Id);
                cmd.Parameters.AddWithValue("@Name", user.Name);
                cmd.Parameters.AddWithValue("@Surnames", user.Surnames);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }

        internal void Delete(UserModel user)
        {
            string query = "DELETE FROM users WHERE Id = @Id";
            using (MySqlConnection cn = new MySqlConnection(Conexion))
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@Id", user.Id);
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }

        internal void Update(UserModel user)
        {
            string query = "UPDATE users SET Name = @Name, Surnames = @Surnames, Email = @Email, Password = @Password WHERE Id = @Id";
            using (MySqlConnection cn = new MySqlConnection(Conexion))
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@Id", user.Id);
                cmd.Parameters.AddWithValue("@Name", user.Name);
                cmd.Parameters.AddWithValue("@Surnames", user.Surnames);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }
    }
}
