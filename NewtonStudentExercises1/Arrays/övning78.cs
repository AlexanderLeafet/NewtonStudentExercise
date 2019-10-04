using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.Arrays
{
    //Läs in två tal till en bråk, dvs täljare och nämnare, spara de i en array med två platser. 
    //Kontrollera om nämnaren är 0, skriv i så fall ut ett felmeddelande
    class övning78
    {
        public void PrintErrorMsg()
        {
            Console.WriteLine($"Write one numerator and one denominator for a rational number. ");
            int[] array = new int[2];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Enter element [{i+1}]");
                array[i] = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine($"");

            if (array[1] == 0)
            {
                Console.WriteLine($"Error! The denominator can't be 0");
            }
            else
            {
                Console.WriteLine($"{array[0]} / {array[1]}");
            }

        }
        public static void Runövning78()
        {
            övning78 o78 = new övning78();
            o78.PrintErrorMsg();
        }
    }
}
