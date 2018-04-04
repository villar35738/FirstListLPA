using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevador
{
    class Elevador
    {
        public int andarAtual { get; private set; }
        public int totalAndares { get; set; }
        public int capacidade { get; set; }
        public int qtdPessoas { get; private set; }

        public Elevador(int capacidade, int totalAndares)
        {
            this.capacidade = capacidade;
            this.totalAndares = totalAndares;
            andarAtual = 0;
            qtdPessoas = 0;
        }

        public void EntrarPessoa(int addPessoa)
        {
            if ((qtdPessoas + addPessoa) <= capacidade)
            {
                qtdPessoas = qtdPessoas + addPessoa;
            }
            else
            {
                MessageBox.Show("A quantidade de pessoas excede a capacidade total do elevador");
            }
        }

        public void SairPessoa(int sairPessoa)
        {
            if ((qtdPessoas - sairPessoa) <= qtdPessoas)
            {
                qtdPessoas = qtdPessoas - sairPessoa;
            }
            else
            {
                MessageBox.Show("Não existe a quantidade de pessoas requisitadas para sair");
            }
        }

        public void Subir(int subir)
        {
            if ((andarAtual + subir) <= totalAndares)
            {
                andarAtual = andarAtual + subir;
            }
            else
            {
                MessageBox.Show("O andar desejado não existe não existe");
            }
        }

        public void Descer(int descer)
        {
            if ((andarAtual - descer) >= 0)
            {
                andarAtual = andarAtual - descer;
            }
            else
            {
                MessageBox.Show("O andar desejado não existe não existe");
            }
        }

        public void Deslocar(int andarDesejado)
        {
            if (andarAtual < andarDesejado)
            {
                if (andarDesejado <= totalAndares)
                {
                    andarAtual = 0;
                    Subir(andarDesejado);
                }
                else MessageBox.Show("Andar desejado inexistente!");
            }
            else if (andarAtual > andarDesejado)
            {
                Descer(andarAtual - andarDesejado);
            }
        }  
    }
}
