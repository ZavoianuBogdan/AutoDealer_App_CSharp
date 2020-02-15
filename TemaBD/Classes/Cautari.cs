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

    //asemenea clasei AutoClass, aceasta reprezinta clasa cu functii de interogare, dar pentru form-ul de Cautari Avansate
    class Cautari
    {
        //definesc conexiunea cu baza de date definita in XML-ul de config
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        //in aceasta clasa am ales sa separ functiile
        //astfel, am cate o functie cu o singura interogare pentru fiecare buton
        public DataTable SelectModeleNevandute()
        {
            //voi returna un DataTable, adaptat dupa raspunsul bazei de date la interogare
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(myconnstring);
            //incerca sa iau legatura cu baza de date si sa o interoghez
            try
            {
                string sql = "SELECT MA.Nume AS 'Marca', MO.NumeModel AS 'Model' FROM Model MO "+
                                "JOIN Marca MA ON MA.IDMarca = MO.IDMarca "+
                                "WHERE MO.IDModel NOT IN(SELECT DISTINCT MO.IDModel FROM Model MO "+
                                "JOIN Marca MA ON MA.IDMarca = MO.IDMarca "+
                                "JOIN MasinaVanduta MV ON MV.IDModel = MO.IDModel)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                //daca merge, voi salva raspunsul convertind la DataTable
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
        //aceeasi logica se aplica pentru toate functiile de mai jos
        public DataTable SelectModeleVandute()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "SELECT MA.Nume AS 'Marca', MO.NumeModel AS 'Model' FROM Model MO " +
                                "JOIN Marca MA ON MA.IDMarca = MO.IDMarca " +
                                "WHERE MO.IDModel IN(SELECT DISTINCT MO.IDModel FROM Model MO " +
                                "JOIN Marca MA ON MA.IDMarca = MO.IDMarca " +
                                "JOIN MasinaVanduta MV ON MV.IDModel = MO.IDModel)";
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
        public DataTable SelectModeleMedie()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "SELECT MA.Nume AS 'Marca', MO.NumeModel AS 'Model', MV.Pret AS 'Pret' FROM Model MO "+
                            "JOIN Marca MA ON MA.IDMarca = MO.IDMarca "+
                            "JOIN MasinaVanduta MV ON MV.IDModel = MO.IDModel "+
                            "JOIN Factura F ON F.IDFactura = MV.IDFactura "+
                            "WHERE MV.Pret >= (SELECT AVG(Pret) FROM MasinaVanduta)";
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
        public DataTable SelectModelePret(string Pret1,string Pret2)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "SELECT  MA.Nume AS 'Marca', MO.NumeModel AS 'Model', F.SumaTotala AS 'Pret' "+ 
                            "FROM Model MO "+
                            "JOIN Marca MA ON MA.IDMarca = MO.IDMarca "+
                            "JOIN MasinaVanduta MV ON MV.IDModel = MO.IDModel "+
                            "JOIN Factura F ON F.IDFactura = MV.IDFactura "+
                            "JOIN Client C ON C.IDClient = F.IDClient "+
                            "JOIN Angajat A ON A.IDAngajat = F.IDAngajat "+
                            "WHERE F.SumaTotala BETWEEN @Pret1 AND @Pret2 "+
                            "AND A.IDAngajat IN(SELECT Angajat.IDAngajat FROM Angajat "+
                                    "JOIN Factura ON Angajat.IDAngajat = Factura.IDAngajat "+
                                    "GROUP BY Angajat.IDAngajat "+
                                    "HAVING COUNT(*)> 1)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                //pentru a putea insera variabile in interogare, ma folosesc de parametrii pentru SqlCommand, asignandu-le o variabila
                cmd.Parameters.AddWithValue("@Pret1", Pret1);
                cmd.Parameters.AddWithValue("@Pret2", Pret2);
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
    }
}
