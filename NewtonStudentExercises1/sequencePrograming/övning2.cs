using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.sequencePrograming
{
    class övning2
    {
        /* En säljare har delvis prestationslön, grundlönen är 8000kr och provisionen är 9%.
         Försäljningssumman ska läsas in*/
        double Grundlön = 8000;
        double Provision = 0.09;
        double Försäljning;
        double lön;

        //skapar en funktion för att beräkna den totala månadslönen.

        public double CalcLön()
        {
            return lön = Grundlön + Provision * Försäljning;
        }

        //skapar en metod för att skriva ut den funktionen.
        public void PrintLön()
        {
            Console.WriteLine("Här kan du beräkna vad din månadslön är. Du har 8000kr i grundlön.");
            Console.WriteLine("Ange din försäljning för månaden");
            Försäljning = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Din månadslön är: {0}", CalcLön());

        }
    }
}
