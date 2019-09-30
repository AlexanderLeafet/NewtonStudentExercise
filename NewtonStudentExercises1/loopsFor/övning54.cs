using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.loopsFor
{
    //Läs in tio heltal, skriv ut hur många av talen var positiva, respektive negativa.
    //Minst en förekomst av både positiva respektive tal måste förekomma i de inlästa talen.
    class övning54
    {
        int negNum;
        int posNum;
        public void PrintPosAndNeg()
        {
            Console.WriteLine("Write 10 numbers, the amount of positive and negative numbers will be printed.");

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"Write number {i}");
                int InputNum = Convert.ToInt32(Console.ReadLine());

                if(InputNum < 0)
                {
                    negNum += 1;
                }
                else
                {
                    posNum += 1;
                }
            }
            Console.WriteLine($"The amount of positive numbers is: {posNum}");
            Console.WriteLine($"The amount of negative numbers is: {negNum}");
        }
    }
}
