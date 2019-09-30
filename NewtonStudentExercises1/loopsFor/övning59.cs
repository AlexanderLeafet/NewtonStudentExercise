using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.loopsFor
{
    //Bestäm hur många tal du vill läsa in. Det största och minsta värdet av talen ska ska skrivas ut.
    //I nedanstående exempel så är det fem tal 
    class övning59
    {
        public void PrintLargestAndSmallest()
        {
            int LargestNum, SmallestNum;


            Console.WriteLine($"How many numbers would you like to write?");
            int numChoice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Write the first number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            LargestNum = num;
            SmallestNum = num;
            
            for(int i = 2; i < numChoice; i++)
            {
                Console.WriteLine($"Write number {i} : ");
                num = Convert.ToInt32(Console.ReadLine());

                if(num > LargestNum)
                {
                    LargestNum = num;
                }
                else if(num < SmallestNum)
                {
                    SmallestNum = num;
                }
            }

            Console.WriteLine($"The smallest number is: {SmallestNum} and the largest number is: {LargestNum}.");
        }

        public static void RunÖvning59()
        {
            övning59 o59 = new övning59();
            o59.PrintLargestAndSmallest();
        }
    }
}
