using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadecisnei_2408
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Atividade Cisnei

            //Atividade 1
            int i_nro1 = 0;
            int i_nro2 = 0;

            Console.WriteLine("Exercício 1\n");
            Console.Write("Digite o 1º número inteiro: ");
            i_nro1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o 2° número inteiro: ");
            i_nro2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Soma: {0}", i_nro1 + i_nro2);
            Console.ReadLine();

            //Atividae 2
            Console.WriteLine("\nAtividade 2\n");
            double d_nro1 = 0;

            Console.Write("Escreva um número: ");
            d_nro1 = double.Parse(Console.ReadLine());

            Console.WriteLine("A terça parte do numero {0} é {1}", d_nro1, d_nro1 / 3);
            Console.ReadLine();

            //Atividade 3
            d_nro1 = 0;
            double d_nro2 = 0;

            Console.WriteLine("Atvidade 3\n");
            Console.Write("Digite o 1º número real: ");
            d_nro1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o 2° número real: ");
            d_nro2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Média: {0}", (d_nro1 + d_nro2)/2);
            Console.ReadLine();
            
            //Atividade 4
            double d_sld = 0;

            Console.WriteLine("\nAtividade 4\n");
            Console.Write("Digite um saldo: R$ ");
            d_sld = double.Parse(Console.ReadLine());

            Console.WriteLine("PO saldo é {0:c}", d_sld * 1.01);
            Console.ReadLine();
            

            //Atividade 5
            double d_nota1 = 0;
            double d_nota2 = 0;
            double d_nota3 = 0;
            double d_nota4 = 0;
            
            Console.WriteLine("\nAtividade 5\n");
            Console.Write("Digite 1° nota: ");
            d_nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite 2° nota: ");
            d_nota2 = double.Parse(Console.ReadLine());

            Console.Write("Digite 3° nota: ");
            d_nota3 = double.Parse(Console.ReadLine());

            Console.Write("Digite 4° nota: ");
            d_nota4 = double.Parse(Console.ReadLine());

            Console.WriteLine("Média: {0}", (d_nota1 + d_nota2 + d_nota3 + d_nota4) / 4);
            Console.ReadLine();
        }
    }
}
