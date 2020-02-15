using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaBD.Classes
{
    class Client
    {
        //Acesta clasa se ocupa de pagina cu Clientii, ceea ce inseamna ca
        // trebuie sa ii asociem intr-un fel atributele pentru a le putea
        // stoca mai usor si extrage de pe pagina
        public string IDClient { get; set; }
        public string Nume  { get; set; }
        public string Prenume { get; set; }
        public string Sex { get; set; }
        public string Tip { get; set; }
        public DateTime DataNasterii { get; set; }


        //Ne definim o conexiune la baza de date
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        
        //Selectul folosit pentru a afisa toti clientii
        public DataTable Select()
        {
            //Returnez un DataTable pe care il pot afisa in dataGridView-ul de pe pagina 
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM Client";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        //Functia de insert de pe pagina
        public bool Insert(Client C)
        {
            //Returnez adevarat/fals, daca am reusit sau nu inserarea
            bool succes = false;

            SqlConnection conn = new SqlConnection(myconnstring);
            
            try
            {
                //Parametrii au fost cititi de pe pagina in momentul in care a fost apelata aceasta functie 
                // si sunt in atributele obiectului de tip Client.


                //Folosim un querry parametrizat pentru a completa cu valorile citite
                string sql = "INSERT INTO Client (Nume, Prenume, DataNasterii, Tip, Sex) VALUES (@Nume, @Prenume, @Data, @Tip, @Sex)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Nume",C.Nume);
                cmd.Parameters.AddWithValue("@Prenume", C.Prenume);
                cmd.Parameters.AddWithValue("@Tip", C.Tip);
                cmd.Parameters.AddWithValue("@Data", C.DataNasterii.ToString());
                cmd.Parameters.AddWithValue("@Sex", C.Sex);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                //Daca raspunsul este 1 rand, atunci operatia a fost realizata cu succes si marcam asta
                if (rows > 0)
                    succes = true;
                else
                    succes = false;
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
            return succes;
        }
        //Aproape identic functiei de Insert functioneaza si Update
        public bool Update(Client C)
        {
            bool succes = false;

            SqlConnection conn = new SqlConnection(myconnstring);
            
            //Diferenta apare ca noi ne vom folosi de ID-ul persoanei tocmai selectate cu mouse-ul pentru a face update unde trebuie
            // De asemenea, si ID-ul e stocat ca atribut, pentru o mai buna prelucrare
            try
            { 
                string sql = "UPDATE Client SET Nume=@Nume, Prenume=@Prenume, DataNasterii=@Data, Sex=@Sex, Tip=@Tip  " +
                             " WHERE IDClient=@ID";

                SqlCommand cmd = new SqlCommand(sql, conn);
                //Parametrizam comanda cu variabilele corespunzatoare
                cmd.Parameters.AddWithValue("@ID", C.IDClient);
                cmd.Parameters.AddWithValue("@Nume", C.Nume);
                cmd.Parameters.AddWithValue("@Prenume", C.Prenume);
                cmd.Parameters.AddWithValue("@Data", C.DataNasterii.ToString());
                cmd.Parameters.AddWithValue("@Sex", C.Sex);
                cmd.Parameters.AddWithValue("@Tip", C.Tip);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //Daca avem raspuns un rand, marcam succesul operatiei
                if (rows > 0)
                    succes = true;
                else
                    succes = false;
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
            return succes;
        }
        //Identic cu modul in care ne folosim de ID-ul selectat prin click la Insert,
        // Delete-ul se foloseste de el pentru a sterge respectiva inregistrare
        public bool Delete(Client C)
        {
            bool succes = false;

            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                DataTable dt = new DataTable();

                string sql = "DELETE FROM Client WHERE IDClient = @ID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ID", C.IDClient);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                    succes = true;
                else
                    succes = false;

            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
            return succes;
        }
    }
}
