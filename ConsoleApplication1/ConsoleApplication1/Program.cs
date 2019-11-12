using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masodikvalodicsharpprojek
{
    class Program
    {
        static void Main(string[] args)

        {
            /*   Console.WriteLine("Egytől 100-IGrouping azok a számok, melyek valódi osztóinak összege osztható héttel.");
               for (int i = 0; i < 101; i++)
               {

                   if (osszegHettel(i))
                   {
                       Console.WriteLine($"{i} valódi osztóinak az összege osztható 7tel.");
                   }
               }*/
            Console.WriteLine("2-tol 100-ig a primszamok");
            for (int i = 2; i <101;i++)
            Console.ReadKey();
        }
     /*   static bool osszegHettel(int szam)
        {
            int osszeg = 0;
            bool hettel = true;

            for (int i = 1; i < szam; i++)
            {
                if (szam % i == 0)
                {
                    osszeg += i;
                }
            }

            if (osszeg % 7 != 0)
            {
                hettel = false;
            }
            return hettel;
        }*/
        static bool primszamE(int szam)
        {
            bool primE = true;
            int hatar = (int)Math.Floor(Math.Sqrt(szam)) + 1;

            for (int i = 0; i < hatar; i++)
            {
                if (szam % i == 0)
                {
                    primE = false;
                    break;
                }
            }
            return primE;

        }
    }
}