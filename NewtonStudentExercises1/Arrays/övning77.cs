using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.Arrays
{
    // Läs in fem heltal, skriv sedan ut dem i omvänd ordning, enbart en array får användas.
    class övning77
    {
        public void PrintArrayReverse()
        {
            int[] array = new int[5];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Enter element [{i+1}]");
                array[i] = int.Parse(Console.ReadLine());
            }
            Array.Reverse(array);
            foreach (var num in array)
            {
                Console.WriteLine($"The numbers in the array printed reversed are: {num}");
            }
        }
        public static void Runövning77()
        {
            övning77 o77 = new övning77();
            o77.PrintArrayReverse();
        }

        
    }
}
