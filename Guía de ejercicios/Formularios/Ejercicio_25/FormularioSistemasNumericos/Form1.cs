using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ejercicio_13;

namespace FormularioSistemasNumericos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBinToDec_Click(object sender, EventArgs e)
        {
            double auxDec;

            auxDec = Conversor.BinarioDecimal(txtBinario.Text);
            txtResultadoDec.Text = auxDec.ToString();
        }

        private void btnDecToBin_Click(object sender, EventArgs e)
        {
            string auxBin;

            auxBin = Conversor.DecimalBinario(double.Parse(txtDecimal.Text));
            txtResultadoBin.Text = auxBin;
        }
    }
}
