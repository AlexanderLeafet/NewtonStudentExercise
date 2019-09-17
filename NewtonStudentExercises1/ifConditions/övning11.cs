using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.ifConditions
{
    //Läs in två tal, skriv ut det första talet om det är störst.
    class övning11
    {
        public void IsVal1Bigger(double t1, double t2)
        {
            if (t1> t2)
            {
                Console.WriteLine("Tal1 är större än tal2");
            }
        }

        public void PrintIsVal1Bigger ()
        {
            Console.WriteLine("Läs in tal1");
            double tal1 = (double)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Läs in tal2");
            double tal2 = (double)Convert.ToDouble(Console.ReadLine());

            IsVal1Bigger(tal1, tal2);
        }
    }
}
