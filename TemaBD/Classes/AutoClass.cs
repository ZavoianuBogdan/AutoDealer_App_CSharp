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
    class AutoClass         //clasa responsabila pentru butoanele din Homescreen
    {
        //definesc conexiunea cu baza de date definita in XML-ul de config
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        
        //functia pe care o apelez pentru a interoga baza de date cu parametrul ce imi indica care din butoane a fost apasat
            //sau ce cautare s-a realizat
        public DataTable Select(string s)
        {
            //initiez conexiunea cu baza de date
            SqlConnection conn = new SqlConnection(myconnstring);
            //creez variabila ce va contine rezultatul sub forma de tabel
            DataTable dt = new DataTable();
            try
            {
                //in functie de ce parametru a fost dat functiei, imi dau seama ce interogare este ceruta
                string sql = "";

                //interogarile si semnificatia lor se vor gasi in documentatie
                if (s.Equals("facturi"))
                    sql = "SELECT MA.Nume AS Marca,MO.NumeModel AS Model,MV.VIN AS VIN,MV.CapacitateCilindrica AS 'Capacitate Cilindrica',MV.Combustibil AS Combustibil,MV.Culoare AS Culoare,MV.TipCaroserie AS 'Tip Caroserie', MV.Pret AS Pret FROM MasinaVanduta MV JOIN Model MO ON MO.IDModel = MV.IDModel JOIN Marca MA ON MA.IDMarca = MO.IDMarca JOIN Factura F ON F.IDFactura = MV.IDFactura ORDER BY MV.Pret";
                else
                    if (s.Equals("masini"))
                    sql = "SELECT MA.Nume AS Marca,M.NumeModel AS Model FROM Model M JOIN Marca MA ON MA.IDMarca = M.IDMarca ORDER BY MA.Nume,M.NumeModel ASC ";
                else
                         if (s.Equals("angajati"))
                    sql = "SELECT A.Nume+' '+A.Prenume AS 'Nume Angajat',COUNT(MV.IDMasina) AS 'Numar Masini Vandute' FROM Angajat A left JOIN Factura F ON F.IDAngajat = A.IDAngajat left JOIN MasinaVanduta MV ON MV.IDFactura = F.IDFactura GROUP BY A.Nume,A.Prenume ORDER BY COUNT(MV.IDMasina) DESC";
                else
                             if (s.Equals("modele"))
                    sql = "SELECT MA.Nume AS Marca,MO.NumeModel AS Model,COUNT(MV.IDMasina) AS 'Numar exemplare vandute' FROM Model MO JOIN Marca MA ON MA.IDMarca = MO.IDMarca JOIN MasinaVanduta MV ON MV.IDModel = MO.IDModel GROUP BY MA.Nume,MO.NumeModel ORDER BY COUNT(MV.IDMasina) DESC,MA.Nume ASC";
                else
                                        if (s.Equals("scumpe"))
                    sql = "SELECT DISTINCT TOP 50  MA.Nume AS Marca,M.NumeModel AS Model,MV.Pret FROM MasinaVanduta MV JOIN Model M ON M.IDModel=MV.IDModel JOIN Marca MA ON MA.IDMarca = M.IDMarca ORDER BY MV.Pret desc";
                else
                    sql = "SELECT MA.Nume AS Marca, M.NumeModel AS Model FROM Model M JOIN Marca MA ON MA.IDMarca = M.IDMarca WHERE MA.Nume LIKE '%"+s+"%' OR M.NumeModel LIKE '%"+s+"%' ";
                
                //definesc comanda ce va fi transmisa bazei de date si clasa ce face tranzitia intre cele 2 tipuri de date
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
            //returnez raspunsul interogarii ca DataTable pentru a putea fi afisat in interfata
            return dt;
        }

    }
}
