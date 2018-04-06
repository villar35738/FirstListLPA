using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostrarAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno("35738", "Daniel Vilar", "danielvilar@hotmail.com");

            Console.WriteLine("Matricula: " + aluno.Matricula + "\nNome: " + aluno.Nome + "\nEmail: " + aluno.Email);

            Console.WriteLine("\n----------------------------------------------------\n");
            aluno.Matricula = "16969";
            aluno.Nome = "Eduardo Splinter";
            aluno.Email = "eduardo@uol.com";

            Console.WriteLine("Matricula: " + aluno.Matricula + "\nNome: " + aluno.Nome + "\nEmail: " + aluno.Email);
            Console.ReadKey();

        }
    }
}
