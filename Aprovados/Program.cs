using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aprovados {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InstalledUICulture;

            int n, i;
            double media;
            
            Console.Write("Quantos alunos serao digitados? ");
            n = int.Parse(Console.ReadLine());

            string[] nomes = new string[n];
            double[] nota1 = new double[n];
            double[] nota2 = new double[n];

            for (i = 0; i < n; i++) {
                Console.WriteLine("Digite nome, primeira e segunda nota do " + (i + 1) + "o aluno: ");
                nomes[i] = Console.ReadLine();
                nota1[i] = double.Parse(Console.ReadLine(), CI);
                nota2[i] = double.Parse(Console.ReadLine(), CI);
            }

            media = 0;
            Console.WriteLine("Alunos aprovados:");
            for (i = 0; i < n; i++) {
                media = nota1[i] + nota2[i];
                if (media >= 120) {
                    Console.WriteLine(nomes[i]);
                }
            }
        }
    }
}
