using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZahnradSpint2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Geben Sie mindestens zwei Werte an, für die restlichen Werte geben Sie 0 ein");
            Console.WriteLine("Modul:");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Zähnezahl:");
            double z = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Teilkreisdurchmesser:");
            double d = Convert.ToDouble(Console.ReadLine());


            if (m != 0 && z != 0)
            {
                double p = Math.PI / m;
                d = m * z;
                double c = 0.167 * m;
                double df = d - 2 * (m + c);
                double da = d + 2 * m;
                double h = 2 * m + c;
                double hf = m + c;
                double ha = m;

                Console.WriteLine("Teilung:" + p);
                Console.WriteLine("Kopfspiel:" + c + "mm");
                Console.WriteLine("Fußkreisdurchmesser:" + df + "mm");
                Console.WriteLine("Kopfkreisdurchmesser:" + da + "mm");
                Console.WriteLine("Ergebnis für die Zahnhöhe:" + h + "mm");
                Console.WriteLine("Zahnfußhöhe" + hf + "mm");
                Console.WriteLine("Ergebnis für die Zahnkopfhöhe:" + ha + "mm");
                Console.ReadKey();
            }


            else if (m != 0 && d != 0) 
            {
                z = d / m;
                double p = Math.PI / m;
                double c = 0.167 * m;
                double df = d - 2 * (m + c);
                double da = d + 2 * m;
                double h = 2 * m + c;
                double hf = m + c;
                double ha = m;

                Console.WriteLine("Zähnezahl:" + z);
                Console.WriteLine("Teilung:" + p);
                Console.WriteLine("Kopfspiel:" + c + "mm");
                Console.WriteLine("Fußkreisdurchmesser:" + df + "mm");
                Console.WriteLine("Kopfkreisdurchmesser:" + da + "mm");
                Console.WriteLine("Ergebnis für die Zahnhöhe:" + h + "mm");
                Console.WriteLine("Zahnfußhöhe" + hf + "mm");
                Console.WriteLine("Ergebnis für die Zahnkopfhöhe:" + ha + "mm");
                Console.ReadKey();


            }

            else if ( z!=0 && d!=0 )
            {
                m = d / z;
                double p = Math.PI / m;
                double c = 0.167 * m;
                double df = d - 2 * (m + c);
                double da = d + 2 * m;
                double h = 2 * m + c;
                double hf = m + c;
                double ha = m;
                Console.WriteLine("Modul:" + m);
                Console.WriteLine("Teilung:" + p);
                Console.WriteLine("Kopfspiel:" + c + "mm");
                Console.WriteLine("Fußkreisdurchmesser:" + df + "mm");
                Console.WriteLine("Kopfkreisdurchmesser:" + da + "mm");
                Console.WriteLine("Ergebnis für die Zahnhöhe:" + h + "mm");
                Console.WriteLine("Zahnfußhöhe" + hf + "mm");
                Console.WriteLine("Ergebnis für die Zahnkopfhöhe:" + ha + "mm");
                Console.ReadKey();
            }
        }


    }
}
