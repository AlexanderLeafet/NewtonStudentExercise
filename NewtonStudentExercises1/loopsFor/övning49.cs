using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises
{
    class övning49
    {
        //Beräkna och resultatet för följande algoritm: f(x)=x^n : x och n ska läsas in.



        public void PrintFunction()
        {
            Console.WriteLine($"Beräkna följande algoritm: f(x)=x^n.");

            Console.WriteLine($"Ange värdet för x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Ange värdet för n: ");
            double n = Convert.ToDouble(Console.ReadLine());

            double Sum = 1; 
            for (int i = 1; i <= n; i++)
            {
              Sum = Sum * x;
            }
            Console.WriteLine($"f({x}) = {x} ^ {n} = {Sum}");
        }
    }
}
