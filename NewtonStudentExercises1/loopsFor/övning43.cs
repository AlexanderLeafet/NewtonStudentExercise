using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.loopsFor
{
    class övning43
    {
        //Print the sum of the even whole numbers from 2-30
        public void PrintEvenNum()
        {
            int Sum = 0;
            for(int i = 2; i<=30; i+=2)
            {
                Sum = Sum + i;
                Console.WriteLine($"Round {i/2} is the sum: {Sum}");
            }
        }
    }
}
