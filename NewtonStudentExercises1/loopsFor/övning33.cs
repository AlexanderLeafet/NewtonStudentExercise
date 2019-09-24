using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.loopsFor
{
    class övning33
    {
        //Skriv ut talen 100, 99, 98, ...., 0.
        public void PrintOdd()
        {
            for(int i=100; i>=0; i -= 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
