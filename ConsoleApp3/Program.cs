using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        //PacelCase
        //camelCase
        //under_line

        public static int CalcularSoma()
        {
            int a = 1;
            int b = 2;
            int c = a + b;
            return c;
        }

        public static void MostrarMensagemNaTela()
        {
            Console.WriteLine("ola pessoal");
        }

        public static void Tabuada(int numero)
        {
            for(int i = 1;i<=10; i++)
            {
                Console.WriteLine(numero + " X " + i + " = " + (numero * i));
            }
            Console.WriteLine("");
        }

    private static void Main(string[] args)
        {
       
       int retorno = CalcularSoma();

        Console.WriteLine(retorno);

        MostrarMensagemNaTela();

        Tabuada(4);
        Tabuada(8);
        Tabuada(16);

        Console.Read();
        }
    }
}
