using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.ifConditions
{
    /*Läs in ett tal, Printa ut om talet är mindre än 10, mindre än 100, eller  större än 100.*/
    class övning30
    {
        public void CheckNum(double UserInput1)
        {
            if(UserInput1 < 10 || UserInput1 < 100 || UserInput1 > 100)
            {
                Console.WriteLine($"{UserInput1}");
            }
        }
        public void PrintCheckNum()
        {
            Console.WriteLine("Ange ett tal");
            double tal = double.Parse(Console.ReadLine());

            CheckNum(tal);
        }
    }
}
