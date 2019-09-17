using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.ifConditions
{
/*
En firma erbjuder sina kunder 10% rabatt om man vid ett köptillfälle handlar för minst 1000kr.
Antag för enkelhetens skull att man bara handlar varor av samma typ.  
Beräkna vad en kund ska betala, indata är antal köpta enheter, samt pris  per enhet.*/

    class övning16
    {
        int totalPris;

        public int CalcTotalPris(int pris, int enhet)
        {
            totalPris = pris * enhet;
            if(totalPris > 1000)
            {
                totalPris = (int)(totalPris * 0.9);
            }
            return totalPris;
        }
        public void PrintTotalPris()
        {
            Console.WriteLine("Skriv pris för vara: ");
            int p = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Skriv antal för vara");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Totalpriset är: " + CalcTotalPris(p, a));


        }
        
    }
}
