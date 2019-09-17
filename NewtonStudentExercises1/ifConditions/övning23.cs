using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.ifConditions
{
    //Läs in ett tal, testa om talet är jämt delbart med 3, men inte med 30, I så fall divideras talet med 3.
    class övning23
    {
        decimal Kvot;
        public int CalcKvot(int num)
        {
            if(num % 3 == 0 && num % 30 != 0)
            {
                Kvot = num / 3;
            }
            return (int)Kvot;
        }
            
        public void PrintKvot()
        {
            Console.WriteLine("Skriv in ett tal");
            int t = int.Parse(Console.ReadLine());

            Console.WriteLine($"Kvoten är:{CalcKvot(t)}");
        }
    }
        
            
        
    }

