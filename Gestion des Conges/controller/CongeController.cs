using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Gestion_des_Conges.config;
using Gestion_des_Conges.dao;
using Gestion_des_Conges.model;
using System.Windows.Forms;

namespace Gestion_des_Conges.controller
{
    class CongeController : IConge
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;

        public void create(Conge conge)
        {
            connection = Database.getConnection();

            string query = "INSERT INTO [Conge](ID_User,Nbr_Jours,Date_Debut,Date_Fin,Adresse,Num_Tel ,Date_Demande,Etat) VALUES(@ID_User,@Nbr_Jours,@Date_Debut,@Date_Fin,@Adresse,@Num_Tel ,@Date_Demande,@Etat)";
            
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID_User", conge.User.ID);
            command.Parameters.AddWithValue("@Nbr_Jours", conge.Nbr_Jours);
            command.Parameters.AddWithValue("@Date_Debut", conge.Date_Debut);
            command.Parameters.AddWithValue("@Date_Fin", conge.Date_Fin);
            command.Parameters.AddWithValue("@Adresse", conge.Adresse);
            command.Parameters.AddWithValue("@Num_Tel", conge.Num_Tel);
            command.Parameters.AddWithValue("@Date_Demande", conge.Date_Demande);
            command.Parameters.AddWithValue("@Etat", conge.Etat);
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

            string query = "DELETE FROM [Conge] WHERE ID=@ID";

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

        public List<Conge> readAll()
        {
            connection = Database.getConnection();

            string query = "SELECT c.*, u.Name FROM [User] AS u, [Conge] AS c WHERE u.ID = c.ID_User";

            command = new SqlCommand(query, connection);
            command.CommandTimeout = 60;

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                List<Conge> conges = new List<Conge>();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        User user = new User();
                        user.ID = Convert.ToInt32(reader["ID_User"]);
                        user.Name = Convert.ToString(reader["Name"]);

                        Conge conge = new Conge();
                        conge.ID = Convert.ToInt32(reader["ID"]);
                        conge.User = user;
                        conge.Nbr_Jours = Convert.ToInt32(reader["Nbr_Jours"]);
                        conge.Date_Debut = Convert.ToString(reader["Date_Debut"]);
                        conge.Date_Fin = Convert.ToString(reader["Date_Fin"]);
                        conge.Adresse = Convert.ToString(reader["Adresse"]);
                        conge.Num_Tel = Convert.ToString(reader["Num_Tel"]);
                        conge.Date_Demande = Convert.ToString(reader["Date_Demande"]);
                        conge.Etat = Convert.ToString(reader["Etat"]);

                        conges.Add(conge);
                    }
                }
                connection.Close();
                return conges;
            }
            catch (Exception e)
            {
                MessageBox.Show("" + e.Message, "Erreur");
            }

            return new List<Conge>();
        }

        public List<Conge> readAllById(int id)
        {
            connection = Database.getConnection();

            string query = "SELECT c.*, u.Name FROM [User] AS u, [Conge] AS c WHERE u.ID = c.ID_User AND c.ID_USER=@ID";

            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", id);
            command.CommandTimeout = 60;

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                List<Conge> conges = new List<Conge>();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        User user = new User();
                        user.ID = Convert.ToInt32(reader["ID_User"]);
                        user.Name = Convert.ToString(reader["Name"]);

                        Conge conge = new Conge();
                        conge.ID = Convert.ToInt32(reader["ID"]);
                        conge.User = user;
                        conge.Nbr_Jours = Convert.ToInt32(reader["Nbr_Jours"]);
                        conge.Date_Debut = Convert.ToString(reader["Date_Debut"]);
                        conge.Date_Fin = Convert.ToString(reader["Date_Fin"]);
                        conge.Adresse = Convert.ToString(reader["Adresse"]);
                        conge.Num_Tel = Convert.ToString(reader["Num_Tel"]);
                        conge.Date_Demande = Convert.ToString(reader["Date_Demande"]);
                        conge.Etat = Convert.ToString(reader["Etat"]);

                        conges.Add(conge);
                    }
                }
                connection.Close();
                return conges;
            }
            catch (Exception e)
            {
                MessageBox.Show("" + e.Message, "Erreur");
            }

            return new List<Conge>();
        }

        public Conge readOne(int id)
        {
            connection = Database.getConnection();

            string query = "SELECT c.*, u.Name FROM [User] AS u, [Conge] AS c WHERE u.ID = c.ID_User AND c.ID=@ID";

            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", id);
            command.CommandTimeout = 60;

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                User user = new User();
                Conge conge = new Conge();

                if (reader.HasRows)
                {
                    reader.Read();
                    user.ID = Convert.ToInt32(reader["ID_User"]);
                    user.Name = Convert.ToString(reader["Name"]); 

                    conge.ID = Convert.ToInt32(reader["ID"]);
                    conge.User = user;
                    conge.Nbr_Jours = Convert.ToInt32(reader["Nbr_Jours"]);
                    conge.Date_Debut = Convert.ToString(reader["Date_Debut"]);
                    conge.Date_Fin = Convert.ToString(reader["Date_Fin"]);
                    conge.Adresse = Convert.ToString(reader["Adresse"]);
                    conge.Num_Tel = Convert.ToString(reader["Num_Tel"]);
                    conge.Date_Demande = Convert.ToString(reader["Date_Demande"]);
                    conge.Etat = Convert.ToString(reader["Etat"]);
                }
                connection.Close();
                return conge;
            }
            catch (Exception e)
            {
                MessageBox.Show("" + e.Message, "Erreur");
            }

            return null;
        }

        public int solde(int id)
        {
            connection = Database.getConnection();

            string query = "SELECT COUNT(Nbr_Jours) AS Solde FROM Conge WHERE ID_User=@ID";

            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", id);
            command.CommandTimeout = 60;

            int solde = 0;

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                 
                if (reader.HasRows)
                {
                    reader.Read();
                    solde = Convert.ToInt32(reader["Solde"]);
                }
                connection.Close(); 
            }
            catch (Exception e)
            {
                MessageBox.Show("" + e.Message, "Erreur");
            }

            return solde;
        }

        public void update(Conge conge)
        {
            connection = Database.getConnection();

            string query = "UPDATE [Conge] SET ID_User=@ID_USER, Nbr_Jours=@Nbr_Jours, Date_Debut=@Date_Debut, Date_Fin=@Date_Fin, Adresse=@Adresse, Num_Tel=@Num_Tel,Etat=@Etat WHERE ID=@ID";

            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID_User", conge.User.ID);
            command.Parameters.AddWithValue("@Nbr_Jours", conge.Nbr_Jours);
            command.Parameters.AddWithValue("@Date_Debut", conge.Date_Debut);
            command.Parameters.AddWithValue("@Date_Fin", conge.Date_Fin);
            command.Parameters.AddWithValue("@Adresse", conge.Adresse);
            command.Parameters.AddWithValue("@Num_Tel", conge.Num_Tel);
            command.Parameters.AddWithValue("@Etat", conge.Etat);
            command.Parameters.AddWithValue("@ID", conge.ID);
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
