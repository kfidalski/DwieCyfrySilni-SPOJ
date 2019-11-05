using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCTRL3

{

    class Program
    {



        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());
            string[] tab = new string[n];
            if (n >= 0 && n <= 1000000000)
            {


                long silniaWynik = 0;
                int liczba = 0;
                int j, d;
                for (int i = 0; i < n; i++)
                {
                    liczba = Convert.ToInt32(Console.ReadLine());
                    if (liczba < 10)
                    {
                        silniaWynik = silnia(liczba);
                        j = Convert.ToInt32(silniaWynik % 10);
                        d = Convert.ToInt32(silniaWynik / 10 % 10);
                        tab[i] = d.ToString() + " " + j.ToString();
                    }
                    else
                    {
                        j = 0;
                        d = 0;
                        tab[i] = d.ToString() + " " + j.ToString();
                    }

                   
                }

                // Console.WriteLine(tab[i]);
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(tab[i]);
            }

            Console.ReadKey();


        }

        public static long silnia(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            else
            {
                int s = 1;
                for (int i = 1; i <= n; i++)
                {
                    s *= i;
                }
                return s;

            }

        }
    }
}

    

