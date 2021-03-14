using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion_des_Conges.config;
using Gestion_des_Conges.dao;
using Gestion_des_Conges.model;

namespace Gestion_des_Conges.controller
{
    class UserController : IUser
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;

        public void create(User user)
        {

            connection = Database.getConnection();

            string query = "INSERT INTO [User](Name, Email, Password, Role) VALUES(@Name, @Email, @Password, @Role)";

            user.Role = "AGENT";

            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", user.Name);
            command.Parameters.AddWithValue("@Email", user.Email);
            command.Parameters.AddWithValue("@Password", user.Password);
            command.Parameters.AddWithValue("@Role", user.Role);
            command.CommandTimeout = 60;

            try
            {
                connection.Open();
                reader = command.ExecuteReader();
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("" + e.Message, "Erreur");
            }
        }

        public void delete(int id)
        {
            connection = Database.getConnection();

            string query = "DELETE FROM [User] WHERE ID=@ID";

            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", id);
            command.CommandTimeout = 60;

            try
            {
                connection.Open();
                reader = command.ExecuteReader();
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("" + e.Message, "Erreur");
            }
        }

        public User login(User user)
        {
            connection = Database.getConnection();

            string query = "SELECT * FROM [User] WHERE Email=@Email AND Password=@Password";

            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Email", user.Email);
            command.Parameters.AddWithValue("@Password", user.Password);
            command.CommandTimeout = 60;

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                User u = new User();

                if (reader.HasRows)
                {
                    reader.Read();
                    u.ID = Convert.ToInt32(reader["ID"]);
                    u.Name = Convert.ToString(reader["Name"]);
                    u.Email = Convert.ToString(reader["Email"]);
                    u.Password = Convert.ToString(reader["Password"]);
                    u.Role = Convert.ToString(reader["Role"]);
                }
                connection.Close();
                return u;
            }
            catch (Exception e)
            {
                MessageBox.Show("" + e.Message, "Erreur");
            }

            return new User();
        }

        public List<User> readAll()
        {
            connection = Database.getConnection();

            string query = "SELECT * FROM [User] WHERE Role=@Role";

            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Role", "AGENT");
            command.CommandTimeout = 60;

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                List<User> users= new List<User>();

                if (reader.HasRows)
                {
                    while(reader.Read())
                    {
                        User user = new User();
                        user.ID = Convert.ToInt32(reader["ID"]);
                        user.Name = Convert.ToString(reader["Name"]);
                        user.Email = Convert.ToString(reader["Email"]);
                        user.Password = Convert.ToString(reader["Password"]);
                        users.Add(user);
                    }
                }
                connection.Close();
                return users;
            }
            catch (Exception e)
            {
                MessageBox.Show("" + e.Message, "Erreur");
            }

            return new List<User>();
        }

        public User readOne(int id)
        {
            connection = Database.getConnection();
             
            string query = "SELECT * FROM [User] WHERE ID=@ID";
             
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", id);
            command.CommandTimeout = 60;

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                User user = new User();

                if (reader.HasRows)
                {
                    reader.Read();
                    user.ID = Convert.ToInt32(reader["ID"]);
                    user.Name = Convert.ToString(reader["Name"]);
                    user.Email = Convert.ToString(reader["Email"]);
                    user.Password = Convert.ToString(reader["Password"]);
                }
                connection.Close();
                return user;
            }
            catch (Exception e)
            {
                MessageBox.Show("" + e.Message, "Erreur");
            }

            return null;
        }

        public void update(User user)
        {
            connection = Database.getConnection();

            string query = "UPDATE [User] SET Name=@Name, Email=@Email, Password=@Password WHERE ID=@ID";
 
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", user.Name);
            command.Parameters.AddWithValue("@Email", user.Email);
            command.Parameters.AddWithValue("@Password", user.Password);
            command.Parameters.AddWithValue("@ID", user.ID);
            command.CommandTimeout = 60;

            try
            {
                connection.Open();
                reader = command.ExecuteReader();
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("" + e.Message, "Erreur");
            }
        }
    }
}
