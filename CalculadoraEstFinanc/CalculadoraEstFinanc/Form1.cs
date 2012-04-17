using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculadoraEstFinanc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            Financeira CF = new Financeira();

            double teste;

            teste = CF.calculaTaxaNominalJuros(50000, 100000);
            
            MessageBox.Show(teste.ToString());
        }
    }
}
