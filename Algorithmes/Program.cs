using System;
using System.Threading;

namespace Algorithmes
{
    class Program
    {
        static void Main()
        {
            int option = -1;

            while (option != 0)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine(Resource.Debut);
                Console.WriteLine();
                Console.WriteLine(Resource.Option01);
                Console.WriteLine(Resource.Option02);
                Console.WriteLine(Resource.Option03);
                Console.WriteLine(Resource.Option04);
                Console.WriteLine(Resource.Option05);
                Console.WriteLine();
                Console.WriteLine(Resource.QuitterSysteme);
                Console.WriteLine("");
                Console.Write(Resource.InformezOption);

                var optionUtilisateur = Console.ReadLine();

                if (Int32.TryParse(optionUtilisateur, out int resultat))
                {
                    option = resultat;
                }
                else
                {
                    option = -1;
                    Console.WriteLine("");
                    Console.WriteLine(Resource.OptionInvalide);
                    Thread.Sleep(1000);
                }
            }

            Console.WriteLine("");
            Console.WriteLine(Resource.Bye);
            Thread.Sleep(2000);
        }
    }
}
