using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.loopsWhile
{
    //Läs in ett antal positiva heltal sorterade i växande ordning. Talföljden slut anges med 0. 
    class övning61
    {
        public void PrintUnknown()
        {
            int round = 1;
            int CompareNum;

            Console.WriteLine("Input first nr: ");
            int Input = int.Parse(Console.ReadLine());
            CompareNum = Input;

            while (Input !=0)
            {
                round = round + 1;
                Console.WriteLine($"input nr {round} ");
                Input = Convert.ToInt32(Console.ReadLine());
                

                if (Input < CompareNum)
                {
                    Console.WriteLine($"The nr {round} is wrong, it should be {CompareNum} or bigger.");
                }
                CompareNum = Input;
            }
        }

        public static void RunÖvning61()
        {
            övning61 o61 = new övning61();
            o61.PrintUnknown();
        }
    }
}
