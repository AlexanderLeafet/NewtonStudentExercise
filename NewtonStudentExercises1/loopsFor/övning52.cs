using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.loopsFor
{
    /*Read 10 whole numbers and write the sum of the positive numbers. At least one
     of the 10 numbers must be negative */
    class övning52
    {
       
        public void PrintSumOfPosNum()
        {
            int Sum = 0;
            int UserInput;
            int Num = 0;
            Console.WriteLine($"Write 10 numbers and see the sum of the positive ones.");
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"Number {i}: ");
                UserInput = int.Parse(Console.ReadLine());

                if (UserInput > Num)
                {
                    Sum = Sum + UserInput;
                }
               
            }

            Console.WriteLine($"The sum of the positive numbers is: {Sum}");

        }
    }
}
