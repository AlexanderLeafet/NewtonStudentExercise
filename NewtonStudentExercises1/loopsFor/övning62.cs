using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.loopsFor
{
    //10 tal ska läsas in, kontrollera om talen ligger mellan intervallet: 50 till 100
    //Om talen ligger i detta intervall, ska ordet CORRECT! skrivas ut, annars 
    // ska error skrivas ut. OBS! Intervall nr:et ska också skrivas ut.

    class övning62
    {
        public void PrintTrueOrFalse()
        {
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"Print nr {i}");
                int Input = Convert.ToInt32(Console.ReadLine());
                if(Input >= 50 && Input <= 100)
                {
                    Console.WriteLine($"Correct");
                }
                else
                {
                    Console.WriteLine($"Error");
                }
            }
        }

        public static void Runövning62()
        {
            övning62 o62 = new övning62();
            o62.PrintTrueOrFalse();
        }
        
    }
}
