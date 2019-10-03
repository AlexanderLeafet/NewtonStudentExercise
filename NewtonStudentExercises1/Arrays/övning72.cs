using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.Arrays
{
    /*Skapa en array av 5 tal, skriv ut indexet för det sista negativa talet i arrayn. 
     * Ett litet tips, om ni löser det med en for loop, börja loopen omvänd. Med följande talföjd:
   2, 3, -5, 8, 10. så SKA printe vara i följande format:*/
    class övning72
    {
        public void PrintNegNumInArray()
        {
            /*int saveIndex = 0;
            int i = 0;
            int negativeNum = 500;
            int input;
            int[] array = new int[5];
            foreach (var num in array)
            {
                Console.WriteLine($"Enter Element [{i+1}]");
                input = int.Parse(Console.ReadLine());
            
                if(input < 0)
                {
                    negativeNum = input;
                    saveIndex = i;
                }
                i++;
            }
            Console.WriteLine($"The last negative number in array is: {negativeNum} on index place {saveIndex}");*/

            int[] array = { 2, 3, -5, 8, 10 };

            for (int i = 4; i >= 0; i --)
            {
                if (array[i] < 0)
                {
                    Console.WriteLine($"Last negative: {array[i]}, index: {i}");
                    break;
                }
            }
            


        }
        public static void Runövning72()
        {
            övning72 o72 = new övning72();
            o72.PrintNegNumInArray();
        }
    }
}
