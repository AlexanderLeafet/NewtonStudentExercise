using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.ifConditions
{ /*Läs in två tal, och skriv ut det största talet, följt av orden “är störst”.  Om talet är lika, skriv ut “Talen är lika”.*/
    class övning26
    {
        public void BiggestNum(double UserInput1, double UserInput2)

        {
            if (UserInput1 > UserInput2)
            {
                Console.WriteLine($"{UserInput1} är störst.");
            }
            else if (UserInput2 > UserInput1)
            {
                Console.WriteLine($"{UserInput2} är störst.");
            }
            else
            {
                Console.WriteLine("Talen är lika!");
            }
        }
        public void PrintBiggestNum()
        {
            Console.WriteLine("Ange det första talet");
            double tal1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ange det andra talet");
            double tal2 = double.Parse(Console.ReadLine());

            BiggestNum(tal1, tal2);
        }
           
    }
}
