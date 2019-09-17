using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.ifConditions
{
    //Läs in två tal och avgör om det första talet är jämt delbart  delbart med det andra talet
    class övning15
    {
        public void CheckEven (int t1, int t2)
        {
            if(t1 % t2 == 0)
            {
                Console.WriteLine("Tal1 är jämnt delbart med tal2");
            }
        }
        public void PrintCheckEven()
        {
            Console.WriteLine("Skriv det första talet: ");
            int tal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skriv det andra talet");
            int tal2 = Convert.ToInt32(Console.ReadLine());

            CheckEven(tal1, tal2);

        }
    }
}
