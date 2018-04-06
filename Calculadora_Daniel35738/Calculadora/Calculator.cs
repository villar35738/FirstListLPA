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
    public partial class Calculator : Form
    {

        double resultado = 0;

        public Calculator()
        {
            InitializeComponent();

            atualizarRestulado();
        }

        public double getN1()
        {
            return double.Parse(txtNumero1.Text);
        }

        public double getN2()
        {
            return double.Parse(txtNumero2.Text);
        }

        private void atualizarRestulado()
        {
            labelResultado.Text = "" + resultado;
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
                resultado = Calculadora.Somar(getN1(), getN2());
                atualizarRestulado();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
                resultado = Calculadora.Subtrair(getN1(), getN2());
                atualizarRestulado();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
                resultado = Calculadora.Dividir(getN1(), getN2());
                atualizarRestulado();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
                resultado = Calculadora.Multiplicar(getN1(), getN2());
                atualizarRestulado();
        }

        private void btnBask_Click(object sender, EventArgs e)
        {
            double a, b, c;

            try
            {
                a = double.Parse(textA.Text);
                b = double.Parse(textB.Text);
                c = double.Parse(textC.Text);

                double[] x = Calculadora.Baskara(a, b, c);

                if (x != null)
                {
                    labelX1.Text = "" + x[0];
                    labelX2.Text = "" + x[1];
                }

                else
                {
                    MessageBox.Show("Não é possível aplicar a formula de Baskara para os números inseridos!");
                }

            }
            catch (Exception)
            {
               
            }
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            resultado = Calculadora.Potencia(Convert.ToInt32(getN1()), Convert.ToInt32(getN2()));
            atualizarRestulado();
        }
    }
}
