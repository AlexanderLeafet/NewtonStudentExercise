using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.Arrays
{
    /*An array contains a Social security number, with the structure YYMMDD-NNNN. 
     Check that the SSN is followed by a dash before the last four numbers. If not print a error msg.*/
    class övning66
    {
        //Creating a method called PrintPersonNr where i write my code for this assignment.
        public void PrintPersonNr()
        {
            //Creating an array with the datatype Char, with the following values
            char[] personnr = { '9', '8', '1', '0', '0', '8', '-', '0', '0', '0', '2' };

            //saying IF index number 6 in the personnr Array is NOT a dash then write following cw.  
            if (personnr[6] != '-')
            {
                Console.WriteLine("Error you have to write a dash before your 4 last numbers.");
            }
            //In any other case Write the following: 
            else
                Console.WriteLine($"We recieved your SSN succesfully!");

        }
        // Declaring an object called o66 of the class övning 66 (this one) Inside of its own class.
        //Saying that object o66 should call on the method PrintPersonNr (where the code is)
        //Instead of doing this in main i can now Call the object + the run method in main.
        public static void Runövning66()
        {
            övning66 o66 = new övning66();
            o66.PrintPersonNr();
        }
    }
}
