using System;

namespace Tema3Ex10
{
    class Program
    {
        static Boolean prim(int numar)
        {
            int i = 1;
            int aux = 0;

            while (i != numar)
            {
                if (numar % i == 0)
                {
                    aux = aux + 1;
                }

                i++;
            }

            return (aux == 1);

        }

        static Boolean patrat(int numar)
        {
            double aux = numar;

            numar = Convert.ToInt32(Math.Sqrt(numar));

            return (numar * numar == aux);          
        }

        static Boolean cub(int numar)
        {
            int i = 1;
            while (i*i*i <= numar)
            {
                if (i*i*i == numar)
                {
                    return true;
                }
                i++;
            }
            return false;
        }

        static Boolean diviz(int numar)
        {
            int i = 1;
            int sum = 0;

            for (i=1; i <= numar/2; i++)
            {
                if (numar % i ==0)
                {
                    sum = sum + i;
                }
            }
            return (sum == numar);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("introduceti N = ");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine("introduceti M = ");
            int M = int.Parse(Console.ReadLine());

            int gem = 0;
            int inghetata = 0;
            int ciocolata = 0;
            int zahar = 0;
            int simplu = 0;

            for (int i = N; i <= M; ++i)
            {
                bool aux = false;

                if (prim(i))
                {
                    ciocolata++;
                    aux = true;
                }
                if (aux == false && (patrat(i) || cub(i)))
                {
                    gem++;
                    aux = true;
                }
                if ( aux== false && diviz(i))
                {
                    inghetata++;
                    aux = true;
                }
                if (aux == false)
                {
                    if (i % 2 == 0)
                    {
                        zahar++;
                    }
                    else
                    {
                        simplu++;
                    }
                }

            }
            Console.WriteLine("Clatite mancate in total " + (M - N +1));
            Console.WriteLine("Ciocolata = " + ciocolata);
            Console.WriteLine("Gem = " + gem);
            Console.WriteLine("Inghetata = " + inghetata);
            Console.WriteLine("Zahar = " + zahar);
            Console.WriteLine("Simplu = " + simplu);
        }
    }
}
