using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.ifConditions
{
    /*Läs in ett tal, testa om talet är mindre än -10 eller större än 10, i så  fall skriv ut “Talet är minst två siffrigt.*/
    class övning21
    {
        public void TestaTal(double UserInput1)
        {
            if (UserInput1 <= -10 || UserInput1 >= 10)
            {
                double Answere = UserInput1 * UserInput1;
                Console.WriteLine("Talet är minst två siffrigt");
            }
            else
            {
                Console.WriteLine("ERROR!! Talet är inte tvåsiffrigt");
            }

        }
        public void PrintTestaTalet()
        {
            
            Console.WriteLine("Ange tal: ");
            double tal = double.Parse(Console.ReadLine());

            TestaTal(tal);
        }
    }
}
