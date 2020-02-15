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
    public partial class ShowData : Form
    {
        //Aceasta fereastra primeste parametru pentru a apela functia de select corespunzatoare si afiseaza rezultatul
        public ShowData(string s)
        {
            AutoClass A = new AutoClass();
            InitializeComponent();
            DataTable dt = new DataTable();
            dt = A.Select(s);
            RezultateData.DataSource = dt;
        }
        //Buton de back pentru intoarcere rapida
        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
