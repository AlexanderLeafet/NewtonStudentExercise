using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.loopsFor
{
    class övning44
    {
        public void PrintChosenNum()
        {
            int sum = 0;

            Console.WriteLine("Write how many numbers you want to add: ");
            int Choice = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i<= Choice; i++)
            {
                Console.WriteLine($"Write the number {i}: ");
                int UserInput = Convert.ToInt32(Console.ReadLine());
                sum += UserInput;
                

            }
            Console.WriteLine($"The sum of the numbers is {sum} ");
        }
    }
}
