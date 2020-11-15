using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZahnradSpint2
{
    class Program
    {
        
        
        
            static void Main()
            {
                double m;
                double z;
                double p;
                double df;
                double h;
                double hf;
                double ha;
                double db;
                Math.Cos(20);



            }
            // Berechnung mit Modul und Zähnezahl
            static void Berechnung(double Ergebnis)
            {


                double h = 2 * m + c;
                Console.WriteLine(h);
                double d = (m * z);
                Console.WriteLine(d);
                double p = (Math.PI * m);
                Console.WriteLine(p);
                double hf = (m + c);
                Console.WriteLine(hf);
                double ha = m;
                Console.WriteLine(ha);
                double db = (z * m * Math.Cos(20));
                Console.WriteLine(db);

            }

            // Berechnung mit Modul und Teilkreisdurchmesser 
            static void Berechnung2(double Ergebnis)
            {
                double z = (d / m);
                double p = (Math.PI * m);
                double hf = (m + c);
                double h = (2 * m + c);
                double ha = m;


            }

            // Berechnungen mit Zähnezahl und Teilkreisdurchmesser 
            static void Berechnung3(double Ergebnis)
            {
                double m = (d / z);
                double da = (d + 2 * m);
                double df = (d - 2 * (m + c));


            }

        

    }



}
}
