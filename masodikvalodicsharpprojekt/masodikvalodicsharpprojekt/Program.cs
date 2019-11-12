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
            Console.WriteLine("Egytől 100-IGrouping azok a számok, melyek valódi osztóinak összege osztható héttel.");
            for (int i = 0; i < 101; i++)
            {

                if (osszegHettel(i))
                {
                    Console.WriteLine($"{szam} valódi osztóinak az összege osztható 7tel.");
                }
            }
            
            Console.ReadKey();
        }
        static bool osszegHettel(int szam)
        {
            int osszeg = 0;
            bool hettel = true;

            for (int i = 1; i < szam; i++)
            {
                if (szam % 1 == 0)
                {
                    osszeg += i;
                }
            }

            if (osszeg % 7 != 0)
            {
                hettel = false;
            }
            return hettel;
        }
    }
}