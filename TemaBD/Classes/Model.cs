using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemaBD;

/* DISCLAIMER
 *  Pentru a vedea comentarii putin mai detaliate, 
 *      cititi codul de la fisierul Client.cs
 *  Abordarea este exact aceeasi, tot ce difera este numele Clasei si interogarile propriu-zis
 *  In rest, setup-ul e acelasi si nu prea e de comentat aici
 * 
 */

namespace TemaBD.Classes
{
    class Model
    {
        //Asemenea clasei Client, definim atributele cu care o sa lucram in principal,
        // pentru o mai buna logica in program
        public string IDModel { get; set; }
        public string NumeModel { get; set; }
        public string Marca { get; set; }

        //Definim vesnica variabila de conexiune pe care o sa o folosim
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        //Selectul ce ne selecteaza toate Numele de Marci disponibile pentru 
        // atunci cand dorim sa introducem un model nou
        public DataTable SelectMarca()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT Nume FROM Marca";
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
        //Selectul care ne arata toate modelele 
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT MO.IDModel AS IDModel,MA.Nume AS Marca,MO.NumeModel AS 'Nume Model' " +
                            "FROM Model MO JOIN Marca MA ON MA.IDMarca = MO.IDMarca";
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
        //Functionalitatea pentru butonul de Insert de model
        public bool Insert(Model M)
        {
            bool succes = false;

            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string sql = "INSERT INTO Model (IDMarca,NumeModel) VALUES (@IDMarca,@NumeModel)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@IDMarca", M.Marca);
                cmd.Parameters.AddWithValue("@NumeModel", M.NumeModel);
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
        //Functionalitatea pentru butonul de Update de model
        public bool Update(Model M)
        {
            bool succes = false;

            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string sql = "UPDATE Model SET IDMarca=@IDMarca, NumeModel=@NumeModel WHERE IDModel=@IDModel";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@IDModel", M.IDModel);
                cmd.Parameters.AddWithValue("@IDMarca", M.Marca);
                cmd.Parameters.AddWithValue("@NumeModel", M.NumeModel);
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
        //Functionalitatea pentru butonul de Delete de model
        public bool Delete(Model M)
        {
            bool succes = false;

            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string sql = "DELETE FROM Model WHERE IDModel = @ID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ID", M.IDModel);
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
