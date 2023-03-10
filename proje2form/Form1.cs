using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje2form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kisa = Convert.ToInt32(txtKısa.Text); //kisa kenarı tanımladım
            int uzun = Convert.ToInt32(txtUzun.Text); //uzun kenarı tanımladım
            int alan = kisa * uzun; //alan hesaplamasını girdim
            int cevre = (kisa + uzun) * 2; //cevre hesaplamasını girdim
            label3.Text = "cevre: " + cevre; //ekrana cevre sonucunu yazdırdım
            label4.Text = "alan: " + alan; //ekrana alan sonucunu yazdırdım




        }
    }
}
