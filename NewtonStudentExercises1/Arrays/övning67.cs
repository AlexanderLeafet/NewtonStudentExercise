using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.Arrays
{
    //Avgör med personnr om det är en man eller kvinna, med formatet YYMMDD-NNNN.
    //Om nästsista nr är jämnt delbart så är det en kvinna, annars en man.
    class övning67
    {
        public void PrintManorFemale()
        {
            char[] person = { '9', '8', '1', '0', '0', '8', '-', '0', '0', '7', '5' };

            if(person[6] != '-')
            {
                Console.WriteLine("Error, you have to write a dash before ur 4 last digits.");
            }
            else if (person[6] == '-' && person[9] %2 == 0)
            {
                Console.WriteLine("We recieved your SSN succesfully!");
                Console.WriteLine("HOLA SENORITAAAA");
            }
            else if (person[6] == '-' && person[9] % 2 != 0)
            {
                Console.WriteLine("We recieved your SSN succesfully!");
                Console.WriteLine("Hello BOYYYY");
            }

        }
        public static void Runövning67()
        {
            övning67 o67 = new övning67();
            o67.PrintManorFemale();
        }
        
    }
}
