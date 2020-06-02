using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaAlunos
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota1;
            int nota2;
            int nota3;
            decimal media;

            Console.Write("Digite sua primeira nota de 0 a 10: ");
            nota1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite sua segunda nota de 0 a 10: ");
            nota2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite sua terceira nota de 0 a 10: ");
            nota3 = Convert.ToInt32(Console.ReadLine());

            media = (nota1 + nota2 + nota3) / 3;


            if (media >= 7 && media < 10)
            {
                Console.Write("Aprovado!");            
            }
            if (media < 7)
            {
                Console.Write("Reprovado :(");
            }
            if (media == 10)
            {
                Console.Write("Vc é zica!");
            }


            Console.ReadLine();
        }
    }
}
