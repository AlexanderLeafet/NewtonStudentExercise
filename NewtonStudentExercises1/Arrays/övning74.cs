using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.Arrays
{
    //Skapa fem tal i en array, leta upp det största och minsta talen och skriv ut dem. 
    class övning74
    {
        public void PrintArrayBigAndSmall()
        {
            int[] array = new int[5];
            

            Console.WriteLine($"Write five elements as numbers: ");

            for (int i = 0; i < array.Length; i++)
            {
                
                Console.WriteLine($"Enter element [{i+1}]");
                array[i] = int.Parse(Console.ReadLine());
            }
            int biggestNum = array[0];
            int smallestNum = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if(smallestNum > array[i])
                {
                    smallestNum = array[i];
                }
                else if(biggestNum < array[i])
                {
                    biggestNum = array[i];
                }
            }

            Console.WriteLine($"The biggest num is: {biggestNum} and the smallest num is:  {smallestNum}.");
        }
        public static void Runövning74()
        {
            övning74 o74 = new övning74();
            o74.PrintArrayBigAndSmall();
        }


    }
}
