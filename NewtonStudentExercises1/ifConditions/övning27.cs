using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.ifConditions
{
    /*Läs in tre tal, skriv ut det minsta talet.*/
    class övning27
    {
        public void SmallestNum(double UserInput1, double UserInput2, double UserInput3)
        {
            if(UserInput1<UserInput2 && UserInput1 < UserInput3)
            {
                Console.WriteLine($"{UserInput1} är det minsta talet.");
            }
            else if (UserInput2<UserInput1 && UserInput2<UserInput3)
            {
                Console.WriteLine($"{UserInput2} är det minsta talet.");
            }
            else if (UserInput3<UserInput2 && UserInput3 < UserInput1)
            {
                Console.WriteLine($"{UserInput3} är det minsta talet.");
            }
        }
        public void PrintSmallestNum()
        {
            Console.WriteLine("Ange det första talet: ");
            double tal1 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Ange det andra talet: ");
            double tal2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ange det tredje talet: ");
            double tal3 = double.Parse(Console.ReadLine());

            SmallestNum(tal1, tal2, tal3);

        }
    }
}
