using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace HoveniersAdministratieNew_DomeinClasses
{
    public class SQLConnection
    {
        public string Klant1;
        public void SqlConnect1()
        {
            string connetionString;
            SqlConnection con;
            connetionString = @"Data Source = P-STUDSQL02; Initial Catalog = dbi485207; User ID = dbi485207; Password = Welkom123";
            con = new SqlConnection(connetionString);
            string query = "Select * from Flora where aantal_flora=@aantal_flora";
            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Naam", "Shama");
                con.Open();
                //string saveKlant = "INSERT into ExampleData (id, first_name, last_name, afspraak_datum, afspraak_tijd, aantal_flora) " +
                //    "VALUES (@id,@first_name,@last_name, @afspraak_datum, @afspraak_tijd, @aantal_flora)";
                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        Klant1 = oReader["Naam"].ToString();
                    }
                    con.Close();
                }
            }
            catch (SqlException ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }





        string connect = @"Data Source = P-STUDSQL02; Initial Catalog = dbi485207; User ID = dbi485207; Password = Welkom123";
        SqlConnection con = new SqlConnection();

        public SqlDataReader loadSQL(string query)
        {
            SqlConnection databaseConnection = new SqlConnection(connect);
            SqlCommand cmd = new SqlCommand(query, databaseConnection);
            cmd.CommandTimeout = 60;
            SqlDataReader reader;
            databaseConnection.Open();
            reader = cmd.ExecuteReader();

            return (reader);
        }

        public static DataTable GetValues(string Naam, string Wachtwoord)
        {
            string query = string.Format("SELECT g.* FROM Gebruiker g " +
                "JOIN inlog i ON g.Voornaam = i.Naam " +
                "WHERE i.Naam = '" + Naam + "' AND i.Wachtwoord = '" + Wachtwoord + "'");
            SqlConnection databaseConnection = new SqlConnection("Server=mssqlstud.fhict.local;Database=dbi485207;User Id=dbi485207;Password=Welkom123;");
            SqlCommand cmd = new SqlCommand(query, databaseConnection);
            cmd.CommandTimeout = 60;
            databaseConnection.Open();

            DataTable dt = new DataTable(); //this is creating a virtual table
            dt.Load(cmd.ExecuteReader());

            return dt;
        }

        public string GetGebruikerNaam(int ID)
        {
            string GebruikerNamen = "";
            DataTable dt = new();
            SqlDataAdapter da = new($"SELECT CONCAT(Voornaam, ' ', Achternaam) AS Naam " +
                $"FROM Gebruiker " +
                $"WHERE ID = {ID}", connect);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                GebruikerNamen = dr["Voornaam"].ToString();
            }

            return GebruikerNamen;
        }

        public string GetKlantNaam(int ID)
        {
            string KlantNamen = "";
            DataTable dt = new();
            SqlDataAdapter da = new($"SELECT CASE WHEN TussenVoegsels is not null THEN CONCAT_WS(' ', Voornaam, TussenVoegsels, Achternaam)" +
                $"ELSE CONCAT(Voornaam, ' ', Achternaam) END AS Naam" +
                $"FROM Klant" +
                $"WHERE ID = {ID}", connect);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                KlantNamen = dr["Voornaam"].ToString();
            }
            return KlantNamen;
        }

        //public string GetFunctie(int ID)
        //{
        //    string FunctieNamen = "";
        //    DataTable dt = new();
        //    SqlDataAdapter da = new($"SELECT F.Functie FROM Gebruiker AS G INNER JOIN Functie AS F ON F.ID = G.FunctieID WHERE G.ID = {ID}", connect);
        //    da.Fill(dt);
        //    foreach (DataRow dr in dt.Rows)
        //    {
        //        FunctieNamen = dr["Functie"].ToString();
        //    }

        //    return FunctieNamen;
        //}

        //public string GetPersoonlijkheden(int ID)
        //{
        //    string PersoonlijkheidNamen = "";
        //    DataTable dt = new();
        //    SqlDataAdapter da = new($"SELECT STRING_AGG(P.Persoonlijkheid, ', ') AS Persoonlijkheid FROM Gebruiker AS G JOIN Gebruiker_Persoonlijkheid AS GP ON GP.Gebruiker_id = G.ID JOIN Persoonlijkheid AS P ON GP.Persoonlijkheid_id = P.ID WHERE G.ID = {ID}", connect);
        //    da.Fill(dt);
        //    foreach (DataRow dr in dt.Rows)
        //    {
        //        PersoonlijkheidNamen = dr["Persoonlijkheid"].ToString();
        //    }

        //    return PersoonlijkheidNamen;
        //}
    }
}
