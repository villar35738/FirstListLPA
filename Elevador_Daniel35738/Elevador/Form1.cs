using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevador
{
    
    public partial class Form1 : Form
    {
        private  static Elevador elevador = new Elevador(10, 17);
        public Form1()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            labelTotalAndares.Text = elevador.totalAndares.ToString();
            labelCapacidade.Text = elevador.capacidade.ToString();
            labelAndarAtual.Text = elevador.andarAtual.ToString();
            labelPessoasAtual.Text = elevador.qtdPessoas.ToString();
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            elevador.Subir(Convert.ToInt16(numericAndar.Value));
            labelAndarAtual.Text = elevador.andarAtual.ToString();
        }

        private void btnDescer_Click(object sender, EventArgs e)
        {
            elevador.Descer(Convert.ToInt16(numericAndar.Value));
            labelAndarAtual.Text = elevador.andarAtual.ToString();
        }

        private void btnDeslocar_Click(object sender, EventArgs e)
        {
            elevador.Deslocar(Convert.ToInt16(txtDeslocar.Text));
            labelAndarAtual.Text = elevador.andarAtual.ToString();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            elevador.EntrarPessoa(Convert.ToInt16(numericPessoa.Value));
            labelPessoasAtual.Text = elevador.qtdPessoas.ToString();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            elevador.SairPessoa(Convert.ToInt16(numericPessoa.Value));
            labelPessoasAtual.Text = elevador.qtdPessoas.ToString();
        }
    }
}
