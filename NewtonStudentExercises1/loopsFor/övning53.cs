using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.loopsFor
{
    //Läs in tio korrekta tal, korrekta tal är tal mellan 5ooo < n < 10000. Skriv ut summan och medelvärdet

    class övning53
    {
        int summa;
        public void PrintCorrectNum()
        {
            Console.WriteLine($"Write ten numbers, there is a algorithm that defines if the number is correct or incorrect: ");
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"Write number {i}");
                int inputNum = int.Parse(Console.ReadLine());
                if (inputNum < 5000 || inputNum > 10000)
                {
                    Console.WriteLine("Invalid number, try again!");
                    i--;
                }
                else
                {
                    summa += inputNum;
                }
                
            }

            Console.WriteLine($"Summan av de korrekta talen är: {summa}");
            Console.WriteLine($"Medelvärdet är: {summa / 10}");
        }
    }
}
