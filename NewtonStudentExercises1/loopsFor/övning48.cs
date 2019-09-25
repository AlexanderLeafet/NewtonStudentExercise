using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.loopsFor
{
    class övning48
    {
        //Skriv ut n! (fakulteten). n ska läsas in. ex: 3!=1*2*3 ex: 5!=1*2*3*4*5
        public void PrintN()
        {
            int n;
            Console.WriteLine("Ange värdet för N (fakulteten)");
            n =Convert.ToInt32(Console.ReadLine());

            
            int Calc;
            for (int i = 1 ; i <= n; i++)
            {
                
                if(i == 1)
                {
                    Console.Write($"{n}! = {i}");
                }
                else
                {
                    Console.Write($" * {i} ");
                }
            }
        }
    }
}
