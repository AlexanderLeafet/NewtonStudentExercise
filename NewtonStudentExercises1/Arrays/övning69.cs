using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.Arrays
{
    //Skapa en array på 11 tal, Addera 2 till talen som befinner sig på indexplats 0, 2, 4, 6, 8, 10.

    class övning69
    {
        public void PrintArray()
        {
            int[] array = new int[11] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110 };
            for (int i = 0; i < array.Length; i += 2)
            {
                array[i] = array[i] + 2;
                Console.WriteLine($" index {i} has the value {array[i]}");

            }
            
        }
        public static void Runövning69()
        {
            övning69 o69 = new övning69();
            o69.PrintArray();
        }
    }
}
