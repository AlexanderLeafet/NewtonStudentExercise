using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.sequencePrograming
{
    class övning6
    {
        //Beräkna resultatet av funktionen ax^3+7. Variablerna a och x ska läsas in.
    
        int a;
        int x;

        public double CalcFunktion()
        {
            return (a * x * x * x) + 7;
        }
        public void PrintCalc()
        {
            Console.WriteLine("Beräkna funktionen ax^3+7 med egna värden för a och x.");

            Console.WriteLine("");

            Console.WriteLine("Ange ett värde för a: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ange ett värde för x: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Svaret är: {0}", CalcFunktion());
        }
    }
}
