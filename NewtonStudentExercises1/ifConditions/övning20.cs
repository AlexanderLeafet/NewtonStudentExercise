using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.ifConditions
{ /*Läs in ett tal, testa om talet är mellan 0 till 9, i så fall skriv ut  kvadraten. Annars generera en felmeddalnde.*/
    class övning20
    {
        

        public void TestaTal(double UserInput1)
        {
            if (UserInput1 >= 0 && UserInput1 <= 9)
            {
                double Answere = UserInput1* UserInput1;
                Console.WriteLine($"Kvadraten av {UserInput1} är {Answere}");
            }
            else
            {
                Console.WriteLine("ERROR!! Talet är inte mellan 0-9!!!");
            }

        }
        public void PrintTestaTal()
        {
            Console.WriteLine("Ange ett tal mellan 0-9 och beräkna kvadraten");
            Console.WriteLine("");

            Console.WriteLine("Ange tal: ");
            double tal = double.Parse(Console.ReadLine());

            TestaTal(tal);
            

        }
    }
}
