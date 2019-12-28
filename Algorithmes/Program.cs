using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Algorithmes
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = -1;

            while (option != 0)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Début....");
                Console.WriteLine();
                Console.WriteLine("01 - ");
                Console.WriteLine("02 - ");
                Console.WriteLine("03 - ");
                Console.WriteLine("04 - ");
                Console.WriteLine("05 - ");

                Console.WriteLine();
                
                Console.WriteLine("*Pour quitter le système, saisir 0 (zero)");

                Console.WriteLine("");
                Console.Write("Informez une option: ");

                var optionUtilisateur = Console.ReadLine();

                if (Int32.TryParse(optionUtilisateur, out int resultat))
                {
                    option = resultat;
                }
                else
                {
                    option = -1;
                    Console.WriteLine("");
                    Console.WriteLine("Option Invalide !!!");
                    Thread.Sleep(1000);
                }                
            }

            Console.WriteLine("");
            Console.WriteLine("Bye !!!");
            Thread.Sleep(2000);            
        }
    }
}
