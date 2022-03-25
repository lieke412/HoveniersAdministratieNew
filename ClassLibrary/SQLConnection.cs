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
        /*public void SqlConnect1()
        {
            string connetionString;
            SqlConnection con;
            connetionString = @"Data Source = P-STUDSQL02; Initial Catalog = dbi485207; User ID = dbi485207; Password = Welkom123";
            con = new SqlConnection(connetionString);
            string query = "Select * from ExampleData where aantal_flora=@aantal_flora";
            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@aantal_flora", 52);
                con.Open();
                string saveKlant = "INSERT into ExampleData (id, first_name, last_name, afspraak_datum, afspraak_tijd, aantal_flora) " +
                    "VALUES (@id,@first_name,@last_name, @afspraak_datum, @afspraak_tijd, @aantal_flora)";
                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    con.Close();
                }
            }
            catch (SqlException ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }*/

        string connect = "Data Source = P-STUDSQL02; Initial Catalog = dbi485207; User ID = dbi485207; Password = Welkom123";
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
            string query = string.Format("SELECT * FROM Gebruiker WHERE Naam = '" + Naam + "' AND Wachtwoord = '" + Wachtwoord + "'");
            SqlConnection databaseConnection = new SqlConnection("Server=mssqlstud.fhict.local;Database=dbi485146;User Id=dbi485146;Password=Welkom01;");
            SqlCommand cmd = new SqlCommand(query, databaseConnection);
            cmd.CommandTimeout = 60;
            databaseConnection.Open();

            DataTable dt = new DataTable(); //this is creating a virtual table
            dt.Load(cmd.ExecuteReader());

            return dt;
        }
    }
}
