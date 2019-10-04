using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.Arrays
{
    //Övn75: Skapa en array med fem heltal, beräkna summan av alla positiva och alla negativa tal och skriv ut dem.
    class övning75
    {
        public void PrintArraySum()
        {
            int i = 0;
            int[] array = new int[5];

            for (i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Write the [{i + 1}] element: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            

            int sumPos = 0;
            int sumNeg = 0;

            for (i = 0; i < array.Length; i++)
            {
                if(array[i] >= 0)
                {
                    sumPos += array[i];
                }
                else if (array[i] < 0)
                {
                    sumNeg += array[i];
                }
            }
            Console.WriteLine($"The sum of the positive numbers is: {sumPos} and the sum of the negative numbers is: {sumNeg}");
        }

        public static void Runövning75()
        {
            övning75 o75 = new övning75();
            o75.PrintArraySum();
        }
    }
}
