using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.Arrays
{
    /* Skapa en array av 5 positiva tal, skriv ut summan och medel av de fem talen, 
     * svaret ska vara med 2 decimaler tex med nedanstående array värden: 2, 3.5, 5, 8, 10 */
    class övning73
    {
        public void PrintSumOfArray()
        {
            double mean = 0;
            double sum = 0;
            double[] array = { 20, 40.5, 60, 80, 100 };
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            mean = sum / array.Length;
            Console.WriteLine($"The sum of the numbers in the array is: {sum} and the mean is: {mean}");

        }
        public static void Runövning73()
        {
            övning73 o73 = new övning73();
            o73.PrintSumOfArray();
        }
        

    }
}
