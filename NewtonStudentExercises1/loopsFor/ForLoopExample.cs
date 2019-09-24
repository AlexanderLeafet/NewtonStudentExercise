using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.loopsFor
{
    class ForLoopExample
    {
        /* In a ForLoop the syntax is different from a while loop. Here we first give the start value
         followed by the condition and at last the increment, ALL in the same parentheses.*/
        public void ForLoopEx()
        {
            for (int i = 0; i < 10; i++)
            {
                /*This will print "The value of i is 0", on a new line, "The value of i is 1"
                 on a new line, "The value of i is 2" and so on up to 9.*/
                Console.WriteLine($"The value of i is: {i}");
            }
        }
        /*An additional assignement we did was create a method that prints every 4th year from
         the year you were born up to this year*/

        public void FoorLoopEx1()
        {
            for(int i = 1998; i < 2019; i += 4)
            {
                Console.WriteLine($"Year : {i}");
            }
        }
    }
}
