using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadecoruja2408
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Atividade Coruja 
            
            //Atividade 1 
            int i_nro = 0;

            Console.WriteLine("\nAividade 1\n");
            Console.Write("Digite um número inteiro: ");
            i_nro = int.Parse(Console.ReadLine());

            Console.WriteLine("O antecessor é {0} e o sucesor é {1}", i_nro - 1, i_nro + 1);
            Console.ReadLine();
            

            //Atividade 2 
            Console.WriteLine("\nAtividade 2\n");
            string s_nm = "";
            string s_end = "";
            string s_tel = "";

            Console.Write("Digite seu nome: ");
            s_nm = Console.ReadLine();

            Console.Write("Digite seu endereço: ");
            s_end = Console.ReadLine();

            Console.Write("Digite seu telefone: ");
            s_tel = Console.ReadLine();

            
            //Atividade 3
            int i_nro1  = 0;
            int i_nro2 = 0;

            Console.WriteLine("Atividade 3");
            Console.Write("Digite o 1º número: ");
            i_nro1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o 2° número: ");
            i_nro2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Soma: {0}", i_nro1 + i_nro2);
            Console.ReadLine();

            Console.WriteLine("Subtração: {0}", i_nro1 - i_nro2);
            Console.ReadLine();

            Console.WriteLine("Multiplicação: {0}", i_nro1 * i_nro2);
            Console.ReadLine();
            

            //Atividade 4 
            double d_peso = 0;
            double d_alt = 0;

            Console.Write("Digite seu peso: ");
            d_peso = double.Parse(Console.ReadLine());

            Console.Write("Digite sua altura: ");
            d_alt = double.Parse(Console.ReadLine());

            Console.Write("O IMC é: {0:f}", d_peso/Math.Pow(d_alt, 2));
            Console.ReadLine(); 
        }
    }
}
