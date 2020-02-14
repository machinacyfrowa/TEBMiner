using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEBMiner
{
    public partial class Form1 : Form
    {
        int kasa;
        int gowniaki;
        public Form1()
        {
            InitializeComponent();
            kasa = 0;
            gowniaki = 0;
        }

        private void Kop(object sender, EventArgs e)
        {
            kasa++;
            UpdateLabels();
        }

        private void DokupGowniakiButton_Click(object sender, EventArgs e)
        {
            if(kasa >= 10)
            {
                gowniaki++;
                kasa -= 10;
                UpdateLabels();
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            kasa += 1 * gowniaki;
            UpdateLabels();
        }
        private void UpdateLabels()
        {
            GowniakiLabel.Text = "Gówniaki: " + gowniaki.ToString();
            KasaLabel.Text = "Kasa: " + kasa.ToString() + " zł";
        }
    }
}
