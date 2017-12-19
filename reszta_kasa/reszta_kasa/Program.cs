using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reszta_kasa
{
    class Program
    {
        static void Main(string[] args)
        {
            double kwota, reszta, zaplata;
            int i = 0;
            int temp;
            double[] nominaly = { 500, 200, 100, 50, 20, 10, 5, 2, 1, 0.5, 0.2, 0.1, 0.05, 0.02, 0.01 };
            Console.WriteLine("Podaj ile musisz zaplacic");
            zaplata = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj ile dajesz pieniedzy kasjerowi");
            kwota = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("reszta = {0}zl", Math.Round(kwota - zaplata, 2));
            while (kwota < zaplata)
            {
                Console.WriteLine("Uuu jestes za biedny xD Daj kasjerowi wiecej pieniedzy");
                kwota = Convert.ToDouble(Console.ReadLine());
            }
            reszta = kwota - zaplata;
            while (reszta > 0)
            {
                if (reszta >= nominaly[i])
                {
                    temp = (int)(reszta / nominaly[i]);
                    reszta = Math.Round(reszta - (nominaly[i] * temp), 2);
                    Console.WriteLine("{0} zl x {1}", nominaly[i], temp);
                }
                i++;
            }
            Console.ReadKey();
        }
    }
}