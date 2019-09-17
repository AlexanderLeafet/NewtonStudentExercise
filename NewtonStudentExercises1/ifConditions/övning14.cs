using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.ifConditions
{
    //Läs in ett, är talet jämt, skriv Jämt tal, om inte, skriv Udda tal, använd modulus operatorn %.
    class övning14
    {
        public void IsEven(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine("Ditt tal är jämnt delbart");
            }
            else
            {
                Console.WriteLine("Ditt tal är inte jämnt delbart");
            }
          
        }

        public void PrintIsEvenElse()
        {
            Console.WriteLine("Läs in ett tal");
            int num = (int)Convert.ToInt32(Console.ReadLine());

            IsEven(num);
        }
    }
}






             


           


