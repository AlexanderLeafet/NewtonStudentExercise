using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.Arrays
{
    // Skapa en array av både positiva och negativa tal, skriv ut alla positiva tal.
    //Med följande värden i arrayn:  2, 3, -5, 8, -10
    class övning70
    {
        public void PrintPosArrayNum()
        {

            /*int[] array = { 2, 3, -5, 8, -10 };
            foreach (var num in array)
            {
                
                if(num > 0)
                {
                    Array.IndexOf(array, num);
                    Console.WriteLine($"{num}");
                }
                
            }*/

            int i = 0;
            int[] arr = new int[5];
            Console.WriteLine("Enter Array elements: ");

            for(i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Element[{i+1}]");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write($"List of positive numbers : ");
            for(i = 0; i<arr.Length; i++)
            {
                if (arr[i] >= 0)
                    Console.Write($"{arr[i]} "); 
            }

        }
        public static void Runövning70()
        {
            övning70 o70 = new övning70();
            o70.PrintPosArrayNum();
        }
    }
}
