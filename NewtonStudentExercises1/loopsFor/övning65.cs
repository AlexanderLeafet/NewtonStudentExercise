using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.loopsFor
{
    //Indata består av 10 positiva tal. Beräkna skillnaden mellan det största och näst största talet.
    class övning65
    {
        public void PrintDiff()
        {
            int biggest = -1;
            int secondBiggest = -1;
            int diff;
            for(int i = 1; i < 11; i++)
            {
                Console.WriteLine($"Enter number {i}");
                int Input = Convert.ToInt32(Console.ReadLine());

                if (Input > biggest)
                {
                    secondBiggest = biggest;
                    biggest = Input;
                }
                else if(Input > secondBiggest)
                {
                    secondBiggest = Input;
                }
            }
            diff = biggest - secondBiggest;
            Console.WriteLine($"The difference between the biggest nr and the second biggest nr is: {diff}");
        }

        public static void Runövning65()
        {
            övning65 o65 = new övning65();
            o65.PrintDiff();
        }
    }
}
