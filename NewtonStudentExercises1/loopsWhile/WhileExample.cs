using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.loopsWhile
{
    public class WhileExample
    {
        /*Creating a method saying that x start value is 0. While x is less than 11,
       
        Print the value of X. After that is done it adds x by one (x++)
        
        and then check again. int x = 0+1, is 1 less than 11? YES, Print value of X again
        
        and add 1 and so on.. UNTIL the condition is false then the loop stops.*/
        public void WhileExampleEx()
        {
            int x = 0;
            while (x<11)
            {
                Console.WriteLine(x);
                x++;
            }
        }
    }
}
