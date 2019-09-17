using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.ifConditions
{
    //Läs in ett, är talet jämt, skriv Jämt tal, använd modulus operatorn %.
    class övning13
    {
        public void IsEven(int num)
        {
            if(num % 2 == 0)
            {
                Console.WriteLine("Ditt tal är jämnt delbart");
            }
        }

        public void PrintIsEven()
        {
            Console.WriteLine("Läs in ett tal");
            int num = (int)Convert.ToInt32(Console.ReadLine());

            IsEven(num);
        }
    }
}
