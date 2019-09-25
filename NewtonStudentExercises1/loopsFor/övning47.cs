using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.loopsFor
{
    class övning47
    {
        //Calculate and print the product of the odd whole numbers between 1-15.
       
        public void PrintProduct()
        {
            int Calc = 1;
            int Total = 0;
            int EndSum = 0;

            for (int i = 1; i <= 15; i+=2)
            {
                Calc = i + 2;
                Total = i * Calc;
                Console.WriteLine($"{i} * {Calc} = {Total}");
               
            }
            Console.WriteLine($"{EndSum}");
            
            
        }
    }
}
