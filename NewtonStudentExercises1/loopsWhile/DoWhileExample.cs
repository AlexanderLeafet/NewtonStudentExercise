using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.loopsWhile
{
    public class DoWhileExample
    {
       public void DoWhileEx1()
        {

            int x = 5;

            do
            {
                Console.WriteLine("Tjena");
                Console.WriteLine(x++);

            } while (x<10);

        }
    }
}
