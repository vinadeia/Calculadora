using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        Double Total;
        Double UltimoNumero;
        String Operador;


        private void Limpar()
        {
            Total = 0;
            UltimoNumero = 0;
            Operador = "+";
            tbResultado.Text = "0";

        }

        private void Calcular()
        {
            switch (Operador)
            {
                case "+": Total = Total + UltimoNumero;
                    break;

                case "-": Total = Total - UltimoNumero;
                    break;

                case "x": Total = Total * UltimoNumero;
                    break;

                case "/": Total = Total / UltimoNumero;
                    break;
            }

            UltimoNumero = 0;
            tbResultado.Text = Total.ToString();
        }

        public Form1()
        {
            InitializeComponent();

            Limpar();
        }


        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void bntNumero(object sender, EventArgs e)
        {
            if(UltimoNumero == 0)
            {
                tbResultado.Text = (sender as Button).Text;
            }
            else
            {
                tbResultado.Text = tbResultado.Text + (sender as Button).Text;
            }

            UltimoNumero = Convert.ToDouble(tbResultado.Text);

        }

        private void btnOperador(object sender, EventArgs e)
        {
            UltimoNumero = Convert.ToDouble(tbResultado.Text);

            Calcular();

            Operador = (sender as Button).Text;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            UltimoNumero = Convert.ToDouble(tbResultado.Text);

            Calcular();

            Operador = "+";
            Total = 0;

        }
    }
}
