using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.ifConditions
{
    //Läs in två tal, kontrollera om det första talet är mer än dubbelt så stort som det andra talet.
    class övning12
    {
        public void IsVal1DoubleSize (double t1, double t2)
        {
            if(t1 * 2 > t2)
            {
                Console.WriteLine("Tal1 är dubbelt så stort som tal2");
            }
          
        }

        public void PrintVal1DoubleSize()
        {
            Console.WriteLine("Läs in tal1");
            double tal1 = (double)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Läs in tal2");
            double tal2 = (double)Convert.ToDouble(Console.ReadLine());

            IsVal1DoubleSize(tal1, tal2);

        }


    }
}
