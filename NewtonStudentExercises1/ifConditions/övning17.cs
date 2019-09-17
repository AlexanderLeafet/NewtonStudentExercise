using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.ifConditions
{
    /*Läs in två tal, och dividera det första talet med det andra talet,  
    Om det andra talet är 0, ska fel meddelande skrivas ut “ERROR!!!  
    Nämnaren är 0, noll division är inte tillåtet”  Annars skriv ut kvoten.*/

    class övning17
    {
        double Summa;
        public double CalcDivision(double t1, double t2)
        {
            Summa = t1 / t2;
            if (t2 == 0)
            {
             Console.WriteLine("ERROR!!! Nämnaren är 0, noll division är inte tillåtet");
                return 0;
                //Hur får jag bort svar: ??
            }
            else
            {
                return Summa;
            }
            
        }
        public void PrintSumma()
        {
            Console.WriteLine("Räkna ut tal 1 delat med tal 2!");
            Console.WriteLine("Ange det första talet: ");
            double tal1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ange det andra talet: ");
            double tal2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Svaret är: " + CalcDivision(tal1, tal2));
        }
    }
}
