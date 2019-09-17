using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.sequencePrograming
{
    class övning7
    {
        /* Beräkna vad du ska betala för en tank bensin 
        Indata är är antal liter, pris per liter och rabatt. Utdata är priset du ska betala.*/
    
        double Rabatt;
        double PrisPerLiter;
        double AntalLiter;
        double Bruttopris;
        double Nettopris;

        public double CalcPris()
        {
            Bruttopris = (AntalLiter * PrisPerLiter * Rabatt);
            Nettopris = (100 - Rabatt) / 100 * Bruttopris;
            return Nettopris;
        }
        public void PrintBetala()
        {
            Console.WriteLine("Beräkna vad du ska betala för en tank bensin!");
            Console.WriteLine();

            Console.WriteLine("Ange antal liter: ");
            Console.WriteLine();
            AntalLiter = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ange pris per liter: ");
            Console.WriteLine();
            PrisPerLiter = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ange rabatt i heltal: ");
            Console.WriteLine();
            Rabatt = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ditt pris är: {0}", CalcPris());

        }
    
    }
}
