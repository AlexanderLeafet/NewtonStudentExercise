using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.loopsFor
{
    /*The salary for the first day is 1 SEK, The salary for the second day is 2 sek.
     The salaray for the third day is 4 sek and so on. 
     How many days will it take to earn 1 million SEK?*/
    class övning46
    {
        public void EarnAMillion()
        {
           
            double Salary = 0.01;
            double Sum = 0;
            for(int i = 1; i <= 1000; i++)
            {
                Sum = Sum + Salary;
                if(Sum >= 1000000)
                {
                    Console.WriteLine($"CONGRATULATIONS!! It took you {i} days to earn 1 million sek!");
                    break;
                }
                else
                {
                    Console.WriteLine($"Day {i}: The daily salary is: {Salary}");
                    Salary = 2 * Salary;
                    Console.WriteLine($"Your daily Sum is {Sum}");
                }
                
            }
        }
    }
}
