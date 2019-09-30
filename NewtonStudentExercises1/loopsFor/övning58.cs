using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.loopsFor
{
    //Läs in tio tal, bestäm och skriv ut det största av de tio inlästa talen. 
    //Talordningen ska utryckas dynamisk, förutom för det första talet som läses in.
    class övning58
    {
        decimal num, biggestNum;

        public void PrintLargestNum()
        {
            Console.WriteLine($"Write ten numbers and the largest will be printed!");
            Console.WriteLine($"");

            Console.WriteLine($"Write a number, nr 1: ");
            num = Convert.ToDecimal(Console.ReadLine());
            biggestNum = num;

            for (int i = 2; i <= 10; i++)
            {
                Console.WriteLine($"Write a number, nr {i}: ");
                num = Convert.ToDecimal(Console.ReadLine());
                
            if(num > biggestNum)
                {
                    biggestNum = num;
                }
            }

            Console.WriteLine($"The largest number is: {Math.Round(biggestNum, 2)}");
        }


        public static void Runövning58()
        {
            övning58 o58 = new övning58();
            o58.PrintLargestNum();
        }
    }
}

