using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadeaguia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Atividade Águia

            //Atividade 1 
            
            Console.WriteLine("Atividade 1 : Tabuada ");
            Console.ReadLine();

            int nm_tb = 0;
            Console.Write("Digite um número para ser multiplicado: ");
            nm_tb = int.Parse(Console.ReadLine());

            Console.WriteLine("Tabuada do {0}", nm_tb);
            Console.WriteLine("1 x {0}= {1}", nm_tb, nm_tb * 1);
            Console.WriteLine("2 x {0} = {1}", nm_tb, nm_tb * 2);
            Console.WriteLine("3 x {0} = {1}", nm_tb, nm_tb * 3);
            Console.WriteLine("4 x {0} = {1}", nm_tb, nm_tb * 4);
            Console.WriteLine("5 x {0} = {1}", nm_tb, nm_tb * 5);
            Console.WriteLine("6 x {0} = {1}", nm_tb, nm_tb * 6);
            Console.WriteLine("7 x {0} = {1}", nm_tb, nm_tb * 7);
            Console.WriteLine("8 x {0} = {1}", nm_tb, nm_tb * 8);
            Console.WriteLine("9 x {0} = {1}", nm_tb, nm_tb * 9);
            Console.WriteLine("10 x {0} = {1}", nm_tb, nm_tb * 10);
            Console.ReadLine();
           
            //Atividade 2 

            double d_ld = 0;

            Console.WriteLine("Atividade 2");
            Console.Write("Digite sua quantidade de Laudas: ");
            d_ld = double.Parse(Console.ReadLine());

            Console.WriteLine("O preço total é {0:c}", d_ld * 50);
            Console.ReadLine();
            Console.WriteLine("A quantidade de parcelas iguais de 3 partes será {0:c}", (d_ld * 50) / 3);
            Console.ReadLine();
             

            //Atividade 3

            Console.WriteLine("Atividade 3");
            Console.ReadLine();

            string s_nm = "";
            string s_msg = "Boas-vindas";

            Console.Write("Digite seu nome: ");
            s_nm = Console.ReadLine();

            Console.WriteLine("Olá {0}\n{1}", s_nm, s_msg);
            Console.WriteLine("Tecle ENTER para finalizar");
            Console.ReadLine();
  
        }
    }
}
