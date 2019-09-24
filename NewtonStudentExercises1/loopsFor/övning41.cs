using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.loopsFor
{
    class övning41
    {
        //Print the sum of the numbers 1-50! ex Round 1 is th sum 1. Round 2 is the sum 3...
        public void PrintAddNum()
        {
            int sum = 0;
            for(int i = 1; i<=50; i++)
            {
                sum = sum + i;
                Console.WriteLine($"Round {i} is the sum: {sum}");
            }
        }
    }
}
