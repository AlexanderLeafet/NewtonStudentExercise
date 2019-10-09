using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.Arrays
{
    class Online_övning1
    {
        public void PrintArray()
        {
            
            int[] array = new int[10];
            Console.WriteLine("Write 10 numbers for the array!");

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Enter element {i+1} :");
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Number {i+1}:  {array[i]}");
            }
        }

        public static void RunOnline_övning1()
        {
            Online_övning1 oö1 = new Online_övning1();
            oö1.PrintArray();
        }
      
    }
}
