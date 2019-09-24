using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.loopsFor
{
    class övning35
    {
        //Beräkna kvadraten för talen 1 till 9.
        public void PrintSquareforNum()
        {

            for (int i = 1; i <= 9; i++)
            {
                float Square = i * i;
                Console.WriteLine($"The square of {i} is: {Square}");
            }
        }

        

    }
}
