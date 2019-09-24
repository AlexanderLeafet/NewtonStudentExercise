using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.loopsFor
{
    class övning37
    {

        //Läs in antal tal du vill ange, läs sedan in talen och printa ut de. OBS! 

        public void PrintInputNum()
        {
            Console.WriteLine("How many numbers do you want to type?");
            int Amount = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i<=Amount; i++)
            {
                Console.WriteLine("Write a number");
                int Amount1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{i}: number is {Amount1}");
            }
        }
        
    }
}
