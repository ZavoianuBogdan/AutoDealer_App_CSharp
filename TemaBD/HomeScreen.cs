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
    public partial class HomeScreen : Form
    {
        //definesc un obiect din clasa ce contine toate Selecturile implementate pentru aceasta pagina
        AutoClass A = new AutoClass();
        public HomeScreen()
        {
            InitializeComponent();

        }
        //Pentru fiecare buton voi deschide o noua fereastra de tip ShowData, definita de mine
        // al carui unic scop este de a afisa rezultatul unui select, dar trimit de asemenea parametru pt a stii 
        // ce buton a fost apasat
        private void Facturi_Click(object sender, EventArgs e)
        {
            ShowData ShowFacturi = new ShowData("facturi");
            ShowFacturi.Show();
        }

        private void Masini_Click(object sender, EventArgs e)
        {
            ShowData ShowMasini = new ShowData("masini");
            ShowMasini.Show();
        }

        private void Modele_Click(object sender, EventArgs e)
        {
            ShowData ShowModele = new ShowData("modele");
            ShowModele.Show();
        }

        private void Angajati_Click(object sender, EventArgs e)
        {
            ShowData ShowAngajati = new ShowData("angajati");
            ShowAngajati.Show();
        }

        private void Scumpe_Click(object sender, EventArgs e)
        {
            ShowData ShowAngajati = new ShowData("scumpe");
            ShowAngajati.Show();
        }
        //Butonul de Search in sine functioneaza pe aceeasi logica ca butoanele celelalte, 
        // dar trimit ca parametru ce s-a cautat in schimb
        private void SearchButton_Click(object sender, EventArgs e)
        {
            string search = SearchText.Text;
            ShowData ShowAngajati = new ShowData(search);
            ShowAngajati.Show();
        }
        //Pentru a deschide in fereastra de Clienti
        private void button2_Click(object sender, EventArgs e)
        {
            ShowClient Clienti = new ShowClient();
            Clienti.Show();
        }
        //Pentru a deschide fereastra de Modele
        private void button3_Click(object sender, EventArgs e)
        {
            ShowModel Model = new ShowModel();
            Model.Show();
        }
        //Pentru a deschide fereastra de cautari avansate
        private void buttonCautariAvansate_Click(object sender, EventArgs e)
        {
            ShowCautariAvansate CA = new ShowCautariAvansate();
            CA.Show();
        }
    }
}
