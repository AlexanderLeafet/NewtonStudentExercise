using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.ifConditions
{
    /*Läs in tempratur, om temp är mellan 18 till 25 grader, så ska Lagom skrivas  ut.  
     * Om det är varmare än 25 grader så ska För varmt skrivas ut.  
     * Om det är under 18 grader så ska det skrivas ut, För kallt.*/
    class övning28
    {
        public void CalcTemp(double UserInput1)
        {
            if(UserInput1>=18 && UserInput1 <= 25)
            {
                Console.WriteLine("Temperaturen är lagom.");
            }
            else if (UserInput1 > 25)
            {
                Console.WriteLine("Temperaturen är för hög.");
            }
            else if (UserInput1 < 18)
            {
                Console.WriteLine("Temperaturen är för låg.");
            }
        }
        public void PrintTemp()
        {
            Console.WriteLine("Ange ett värde för temperaturen: ");
            double tal = double.Parse(Console.ReadLine());

            CalcTemp(tal);
        }
    }
}
