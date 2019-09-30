using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.loopsWhile
{
    // Läs in positiva heltal. Inläsningen avbryts med 0. Beräkna antalet ggr två intilliggande tal är lika.
    class övning60
    {
        public void PrintEqualNum()
        {
            int amount = 0;
            int compareNum;
            Console.WriteLine($"Input first number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            compareNum = num;
            while (num != 0)
            {
                Console.WriteLine($"Write nr to compare to previous nr");
                num = Convert.ToInt32(Console.ReadLine());
                
                if(compareNum == num)
                {
                    amount++;
                }

                compareNum = num;

            }

            Console.WriteLine($"The amount of same numbers is: {amount}");

        }
        public static void Runövning60()
        {
            övning60 o60 = new övning60();
            o60.PrintEqualNum();
        }
    }
}
