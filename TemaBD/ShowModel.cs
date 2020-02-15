using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TemaBD.Classes;

namespace TemaBD
{
    public partial class ShowModel : Form
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;


        Model M = new Model();
        public ShowModel()
        {
            DataTable dt = M.Select();
            InitializeComponent();
            dataGridViewModel.DataSource = dt;
            //Completez acel comboBox care se refera la Marca Modelului cu optiuni din baza de date
            comboBoxMarca.Items.Clear();
            dt = M.SelectMarca();
            foreach(DataRow dr in dt.Rows)
            {
                comboBoxMarca.Items.Add(dr[0].ToString());
            }
        }
        //Atucni cand se selecteaza cu mouse-ul una din liniile din tabel, se vor auto-completa toate campurile 
        private void dataGridViewModel_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            textBoxIDModel.Text = dataGridViewModel.Rows[rowIndex].Cells[0].Value.ToString();
            comboBoxMarca.Text = dataGridViewModel.Rows[rowIndex].Cells[1].Value.ToString();
            textBoxNumeModel.Text = dataGridViewModel.Rows[rowIndex].Cells[2].Value.ToString();
        }
        //Butonul de clear va reseta toate campurile pentru a nu le sterge de mana
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxIDModel.Text = "";
            textBoxNumeModel.Text = "";
            comboBoxMarca.Text = "";
            M.IDModel = textBoxIDModel.Text;
            M.NumeModel = textBoxNumeModel.Text;
            M.Marca = comboBoxMarca.Text;

        }
        //Butonul de delete apeleaza functia care are acest querry in ea si afiseaza o fereastra in functie de rezultat
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            M.IDModel = textBoxIDModel.Text;
            bool succes = M.Delete(M);
            if (succes)
            {
                MessageBox.Show("Model Sters cu Succes!");
                DataTable dt = M.Select();
                dataGridViewModel.DataSource = dt;
            }
            else
                MessageBox.Show("Operatiunea a esuat!");
        }
        //Butonul de insert apeleaza functia din obiect ce implementeaza Insertul, comunicand parametrii introdusi 
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            M.IDModel = textBoxIDModel.Text;
            M.NumeModel = textBoxNumeModel.Text;
           
            SqlConnection conn = new SqlConnection(myconnstring);
            DataSet idmarca = new DataSet();
            try
            {
                //Descifram la ce marca se refera comboBox-ul
                string sql = "SELECT IDMarca FROM Marca WHERE Nume=@NumeMarca";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@NumeMarca", comboBoxMarca.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(idmarca);
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
            M.Marca = idmarca.Tables[0].Rows[0]["IDMarca"].ToString();

            bool succes = M.Insert(M);
            if (succes)
            {
                MessageBox.Show("Model Inserat cu Succes!");
                DataTable dt = M.Select();
                dataGridViewModel.DataSource = dt;
            }
            else
                MessageBox.Show("Operatiunea a esuat!");
        }
        //Butonul de update apeleaza functia din obiect ce implementeaza Update, comunicand parametrii introdusi 
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            M.IDModel = textBoxIDModel.Text;
            M.NumeModel = textBoxNumeModel.Text;

            SqlConnection conn = new SqlConnection(myconnstring);
            DataSet idmarca = new DataSet();
            try
            {
                //Descifram la ce marca se refera comboBox-ul
                string sql = "SELECT IDMarca FROM Marca WHERE Nume=@NumeMarca";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@NumeMarca", comboBoxMarca.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(idmarca);
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
            M.Marca = idmarca.Tables[0].Rows[0]["IDMarca"].ToString();

            bool succes = M.Update(M);
            if (succes)
            {
                MessageBox.Show("Model Updatat cu Succes!");
                DataTable dt = M.Select();
                dataGridViewModel.DataSource = dt;
            }
            else
                MessageBox.Show("Operatiunea a esuat!");
        }
    }
}
