using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.loopsFor
{
    //Läs in 11 heltal. Bestäm och skriv ut summan av de tal som är större än första talet som lästes in
    //samt summan av de tal som var mindre än det första talet som lästes in. 
    class övning55
    {
        int sumPos;
        int sumNeg;
        public void PrintBiggerOrSmaller()
        {
            Console.WriteLine($"Write the first number to compare to others");
            int firstNum = int.Parse(Console.ReadLine());

            for(int i = 1; i < 11; i++)
            {
                Console.WriteLine($"Write number: {i}");
                int InputNum = int.Parse(Console.ReadLine());

                if(InputNum > firstNum)
                {
                    sumPos += InputNum;
                }
                else if(InputNum < firstNum)
                {
                    sumNeg += InputNum;
                }
            }
            Console.WriteLine($"The sum of the numbers bigger than the first is: {sumPos}");
            Console.WriteLine($"The sum of the numbers smaller than the first is: {sumNeg}");
        }

        public static void RunÖvning55()
        {
            loopsFor.övning55 o55 = new loopsFor.övning55();
            o55.PrintBiggerOrSmaller();
        }
    }
}
