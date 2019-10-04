using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.Arrays
//Läs in en array med fem värden. Lägg över dessa i en annan array, så att talen kommer i omvänd ordning. 
//Använd array metodern Array.Copy och Array.Reverse
{
    class övning76
    {
        public void PrintReversedArray()
        {
            int x = 0;
            
            
            Console.WriteLine($"Enter the amount of elements for the array: ");
            x = int.Parse(Console.ReadLine());

            int[] array1 = new int[x];
            int[] array2 = new int[x];

            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine($"Enter the [{i+1}] Element");
                array1[i] = int.Parse(Console.ReadLine());
            }
            Array.Copy(array1, array2, array1.Length);
            Array.Reverse(array2);

            foreach (var num in array1)
            {
                Console.WriteLine($"The numbers in array1 is: {num}");
            }
            Console.WriteLine($"________________________________________");
            foreach (var num in array2)
            {
                Console.WriteLine($"The numbers in array2 is: {num}");
            }
        }
        public static void Runövning76()
        {
            övning76 o76 = new övning76();
            o76.PrintReversedArray();
        }
    }
}
