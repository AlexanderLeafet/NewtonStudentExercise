using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.sequencePrograming
{
    class övning3
    // Beräkna antal minuter och sekunder efter att ha anget antal timmar.
    {
        //deklarera alla värden
        double Timmar;
        double Minuter;
        double Sekunder;

        //gör en funktion som returnerar hur man får fram antal minuter från timmar. 
        public double CalcMinuter()
        {
            return Minuter = Timmar * 60;
        }
        //gör en funktion som returnerar hur man får fram antal sekunder från minuter.
        public double CalcSekunder()
        {
            return Sekunder = Timmar * 60 * 60;
        }
        //skapa en printmetod för att få ut beräkningarna och läsa in antal timmar.
        public void PrintTid()
        {
            Console.WriteLine("Ange antal timmar:");
            Timmar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Minuter: {0}", CalcMinuter());
            Console.WriteLine("Sekunder: {0}", CalcSekunder());
        }
    
}
}
