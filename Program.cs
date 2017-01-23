using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromo
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra = "anula la luz azul a la luna";
            string letraInicio;
            string letraFinal;
            char letraTest;
            
            int sigueLetra = palabra.Length;
            for (int i = 0; i <= palabra.Length - 1; i++)
            {
                sigueLetra--;
                letraInicio = palabra.Substring(i, 1);
                letraTest = palabra[sigueLetra];
                letraFinal = letraTest.ToString();
                
                if (letraInicio == " ")
                {
                    i++;
                    letraInicio = palabra.Substring(i, 1);
                }
                if (letraFinal == " ")
                {
                    sigueLetra--;
                    letraTest = palabra[sigueLetra];
                    letraFinal = letraTest.ToString();
                }

                if (letraInicio != letraFinal)
                {
                    Console.WriteLine("No es un palindromo");
                    Console.ReadLine();
                }
            }
            
            Console.WriteLine("Es palindromo");

            Console.ReadLine();
        }
    }
}
