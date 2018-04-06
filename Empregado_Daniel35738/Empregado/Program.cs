using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empregado
{
    class Program
    {
        static void Main(string[] args)
        {
            Empregado empreg = new Empregado("Daniel","Vilar",11000);
            Empregado empreg2 = new Empregado("Eduardo","Gabriel",12000);

            Console.WriteLine(empreg.Nome + " " + empreg.Sobrenome + " || " + empreg.Salario + 
                "\n" + "" + empreg2.Nome + " " + empreg2.Sobrenome + " || " + empreg2.Salario);

            empreg.Salario *= 1.1;
            empreg2.Salario *= 1.1;

            Console.WriteLine("\n ---------- Salario + 10% ---------- \n");

            Console.WriteLine(empreg.Nome + " " + empreg.Sobrenome + " || " + empreg.Salario +
                "\n" + empreg2.Nome + " " + empreg2.Sobrenome + " || " + empreg2.Salario);

            Console.ReadKey();
        }
    }
}
