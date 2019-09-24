using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.loopsWhile
{
    class övning34
    {
        public void PrintNumUntil()
        {
           
            while (true)
            {
                Console.WriteLine("Skriv in tal: ");
                string Input = Console.ReadLine();
                if (Input == "*")
                {
                    break;
                }

            }
        }
    }
}
