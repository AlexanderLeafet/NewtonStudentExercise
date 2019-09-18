using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.ifConditions
{
    /*Läs in ett tal, testa om talet är mellan 0 till 9, men inte 5.  Printa ut Rätt eller Fel.*/
    class övning22
    {
        public void TestaInput(double UserInput1)
        {
            if(UserInput1 >= 0 && UserInput1 <= 9 && UserInput1 != 5)
            {
                Console.WriteLine("rätt");
            }
            else
            {
                Console.WriteLine("fel");
            }
        }
        public void PrintTestaInput()
        {
            Console.WriteLine("Ange ett tal mellan 0-9 men det får inte vara 5.");
            double tal = double.Parse(Console.ReadLine());

            TestaInput(tal);
        }
    }
}
