using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web.Services;

namespace FilmWebService
{
    public class Film
    {
        public int Id { get; set; }
        public string Titlu { get; set; }
        public string Gen { get; set; }
        public int An { get; set; }
        public double Rating { get; set; }
    }

    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    public class FilmService : WebService
    {
        private string connectionString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FilmeDB.mdf;Integrated Security=True";

        [WebMethod]
        public string AdaugaFilm(string titlu, string gen, int an, double rating)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Filme (Titlu, Gen, An, Rating) VALUES (@titlu, @gen, @an, @rating)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@titlu", titlu);
                cmd.Parameters.AddWithValue("@gen", gen);
                cmd.Parameters.AddWithValue("@an", an);
                cmd.Parameters.AddWithValue("@rating", rating);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            return "Film adaugat cu succes";
        }

        [WebMethod]
        public string ModificaFilm(int id, string titlu, string gen, int an, double rating)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "UPDATE Filme SET Titlu=@titlu, Gen=@gen, An=@an, Rating=@rating WHERE Id=@id";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@titlu", titlu);
                cmd.Parameters.AddWithValue("@gen", gen);
                cmd.Parameters.AddWithValue("@an", an);
                cmd.Parameters.AddWithValue("@rating", rating);

                con.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows == 0)
                    return "Filmul nu exista";
            }

            return "Film modificat cu succes";
        }

        [WebMethod]
        public string StergeFilm(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Filme WHERE Id=@id";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", id);

                con.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows == 0)
                    return "Filmul nu exista";
            }

            return "Film sters cu succes";
        }

        [WebMethod]
        public Film[] AfiseazaFilme()
        {
            List<Film> lista = new List<Film>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Filme";

                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new Film
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Titlu = reader["Titlu"].ToString(),
                        Gen = reader["Gen"].ToString(),
                        An = Convert.ToInt32(reader["An"]),
                        Rating = Convert.ToDouble(reader["Rating"])
                    });
                }
            }

            return lista.ToArray();
        }

        [WebMethod]
        public Film[] FiltreazaDupaGen(string gen)
        {
            List<Film> lista = new List<Film>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Filme WHERE Gen LIKE @gen";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@gen", "%" + gen + "%");

                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new Film
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Titlu = reader["Titlu"].ToString(),
                        Gen = reader["Gen"].ToString(),
                        An = Convert.ToInt32(reader["An"]),
                        Rating = Convert.ToDouble(reader["Rating"])
                    });
                }
            }

            return lista.ToArray();
        }

        [WebMethod]
        public Film[] CautaDupaTitlu(string titlu)
        {
            List<Film> lista = new List<Film>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Filme WHERE Titlu LIKE @titlu";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@titlu", "%" + titlu + "%");

                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new Film
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Titlu = reader["Titlu"].ToString(),
                        Gen = reader["Gen"].ToString(),
                        An = Convert.ToInt32(reader["An"]),
                        Rating = Convert.ToDouble(reader["Rating"])
                    });
                }
            }

            return lista.ToArray();
        }

        [WebMethod]
        public string PopuleazaBaza()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
                INSERT INTO Filme (Titlu, Gen, An, Rating) VALUES
                ('Inception', 'Sci-Fi', 2010, 8.8),
                ('Matrix', 'Sci-Fi', 1999, 8.7),
                ('Forrest Gump', 'Drama', 1994, 8.8),
                ('Titanic', 'Romance', 1997, 7.8),
                ('Avatar', 'Sci-Fi', 2009, 7.9),
                ('Joker', 'Drama', 2019, 8.4),
                ('Lion King', 'Animation', 1994, 8.5),
                ('Harry Potter', 'Fantasy', 2001, 7.6)";

                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
            }

            return "Baza populata cu succes";
        }
    }
}