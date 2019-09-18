using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.ifConditions
{
    class övning25
    {
        public void PosOrNeg(double UserInput)
        {
            if(UserInput < 0)
            {
                Console.WriteLine("Ditt tal är negativt");
            }
            else if(UserInput > 0)
            {
                Console.WriteLine("Dit tall är positivt");
            }
        }
        public void PrintPosOrNeg()
        {
            Console.WriteLine("Ange ett tal:");
            double tal = double.Parse(Console.ReadLine());

            PosOrNeg(tal);
        }
    }
}
