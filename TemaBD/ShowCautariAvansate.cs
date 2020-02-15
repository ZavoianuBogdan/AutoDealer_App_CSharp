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
    public partial class ShowCautariAvansate : Form
    {
        //Definesc un obiect ce contine toate functiile implementate dorite in aceasta pagina
        Cautari Caut = new Cautari();
        DataTable dt = new DataTable();
        public ShowCautariAvansate()
        {
            InitializeComponent();
            dataGridViewRezultate.DataSource = dt;
        }

        public void UpdateDataSource()
        {
            dataGridViewRezultate.DataSource = dt;
        }
        //Apeleaza functia de afisare a Modelelor Nevandute la apasarea butonului corespunzator
        private void buttonNevandtue_Click(object sender, EventArgs e)
        {
            dt = Caut.SelectModeleNevandute();
            UpdateDataSource();
        }
        //Apeleaza functia de afisare Modelelor vandute peste pretul mediu la apasarea butonului corespunzator
        private void buttonMedie_Click(object sender, EventArgs e)
        {
            dt = Caut.SelectModeleMedie();
            UpdateDataSource();
        }
        //Apeleaza functia de afisare a Modelelor Vandute la apasarea butonului corespunzator
        private void buttonVandute_Click(object sender, EventArgs e)
        {
            dt = Caut.SelectModeleVandute();
            UpdateDataSource();
        }
        //Apeleaza functia de afisare a Modelelor Vandute cu pretul intre si intre de catre angajati ce au vandut mai mult de o masina la apasarea butonului corespunzator
        private void buttonSpecial_Click(object sender, EventArgs e)
        {
            dt = Caut.SelectModelePret(numericUpDownPret1.Value.ToString(),numericUpDownPret2.Value.ToString());
            UpdateDataSource();
        }
        //Elibereaza fereastra unde se afiseaza rezultatele si de asemenea reseteaza cele 2 inputuri numerice
        private void buttonClear_Click(object sender, EventArgs e)
        {
            numericUpDownPret1.Value = 0;
            numericUpDownPret2.Value = 0;
            dataGridViewRezultate.DataSource = null;
        }
    }
}
