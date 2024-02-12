using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace druhahodina
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            byte a = 20;
            long b = 65536;
            float c = 5.45f;
            double d = 5.65f;
            bool test = true;
            char f = 'j';
            string text = "wassup";
            long x = b;
            Console.WriteLine("Prom a je:" + a);
            Console.WriteLine("Prom b je:" + b);
            Console.WriteLine("Prom c je:" + c);
            Console.WriteLine("Prom d je:" + d);
            Console.WriteLine("Prom test je:" + test);
            Console.WriteLine("Prom text je:" + text);
            Console.WriteLine("Prom f je:" + f);
            Console.WriteLine("Prom x je:" + x);
            */
            /*
            Console.WriteLine("Napiš první číslo");
            int cislo1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Napiš druhé číslo");
            int cislo2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Výsledek:" +cislo1 * cislo);
            */
            /*
            Console.WriteLine("Kolik vteřin je rozdíl mezi bleskem a hromem?");
            byte vteriny = byte.Parse(Console.ReadLine());
            
            double vzdalenostM = vteriny * 350;
            double vzdalenostKm = vzdalenostM / 1000;

            Console.WriteLine("Bouřka od vás je:" + vzdalenostKm + "Km");
            */

            byte a = 8;

            if (a > 5)
            {
                Console.WriteLine("A je větší než 5");
            }
            if (a == 5)
            {
                Console.WriteLine("A se rovná 5");
            }
            if (a < 5)
            {
                Console.WriteLine("A je menší než 5");
            }
Console.ReadKey();
        }
    }
}
