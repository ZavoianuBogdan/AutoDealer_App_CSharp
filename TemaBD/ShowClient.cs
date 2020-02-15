using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TemaBD.Classes;

namespace TemaBD
{
    public partial class ShowClient : Form
    {
        //Initializam obiectul din clasa cu toate functiile pt a le folosi
        Client C = new Client();
        public ShowClient()
        {
            InitializeComponent();
            DataTable dt =  C.Select();
            dataGridViewClienti.DataSource = dt;
           
        }
        //Cand apasam pe butonul de Insert, vom citi din campurile text si le vom transmite prin parametrul functiei
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            C.IDClient = textBoxIDClient.Text;
            C.Nume = textBoxNume.Text;
            C.Prenume = textBoxPrenume.Text;
            C.Tip = comboBoxTip.Text;
            C.Sex = comboBoxSex.Text;
            C.DataNasterii = dateTimePickerDataNasterii.Value;

            bool succes = C.Insert(C);
            if (succes)
            {
                //Afisam o mica fereastra ce ne anunta daca s-a realizat cu succes operatiunea sau nu
                MessageBox.Show("Client Nou adaugat cu Succes!");
                DataTable dt = C.Select();
                dataGridViewClienti.DataSource = dt;
            }
            else
                MessageBox.Show("Operatiunea a esuat!");

        }
        //Aceasta functie se asigura ca atunci cand dam click pe unul din randurile rezultatului, se vor autocompleta campurile text
        private void dataGridViewClienti_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            textBoxIDClient.Text = dataGridViewClienti.Rows[rowIndex].Cells[0].Value.ToString();
            textBoxNume.Text = dataGridViewClienti.Rows[rowIndex].Cells[1].Value.ToString();
            textBoxPrenume.Text = dataGridViewClienti.Rows[rowIndex].Cells[2].Value.ToString();
            comboBoxTip.Text = dataGridViewClienti.Rows[rowIndex].Cells[3].Value.ToString();
            dateTimePickerDataNasterii.Text = dataGridViewClienti.Rows[rowIndex].Cells[4].Value.ToString();
            comboBoxSex.Text = dataGridViewClienti.Rows[rowIndex].Cells[5].Value.ToString();
        }
        //Cand apasam pe butonul de Update, vom citi din campurile text si le vom transmite prin parametrul functiei
        //Ca la Insert
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            C.IDClient = textBoxIDClient.Text;
            C.Nume = textBoxNume.Text;
            C.Prenume = textBoxPrenume.Text;
            C.DataNasterii = dateTimePickerDataNasterii.Value;
            C.Tip = comboBoxTip.Text;
            C.Sex = comboBoxSex.Text;
      
            bool succes = C.Update(C);
            if (succes)
            {
                MessageBox.Show("Client Updatat cu Succes!");
                DataTable dt = C.Select();
                dataGridViewClienti.DataSource = dt;
            }
            else
                MessageBox.Show("Operatiunea a esuat!");

        }
        //Odata ce am selectat pe cineva cu mouse-ul, il putem sterge, obtinandu-i ID-ul prin click
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            C.IDClient = textBoxIDClient.Text;
            bool succes = C.Delete(C);
            if (succes)
            {
                MessageBox.Show("Client Sters cu Succes!");
                DataTable dt = C.Select();
                dataGridViewClienti.DataSource = dt;
            }
            else
                MessageBox.Show("Operatiunea a esuat!");

        }
        //Ne reseteaza toate campurile de completat pentru a nu sta sa stergem noi
        private void buttonClear_Click(object sender, EventArgs e)
        {
            Console.WriteLine(textBoxPrenume.Text);
            textBoxIDClient.Text = "";
            textBoxNume.Text = "";
            textBoxPrenume.Text = "";
            comboBoxTip.Text = "";
            dateTimePickerDataNasterii.Text = "";
            comboBoxSex.Text = "";
            C.IDClient = textBoxIDClient.Text;
            C.Nume = textBoxNume.Text;
            C.Prenume = textBoxPrenume.Text;
            C.DataNasterii = dateTimePickerDataNasterii.Value;
            C.Tip = comboBoxTip.Text;
            C.Sex = comboBoxSex.Text;
        }

    } 
}

