using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.ifConditions
{
    //Let the user enter two numbers, if number 1 is bigger than number 2, print it.
    class övning11
    {
        /*create a method with two arguments that says if number 1 is bigger than number 2
        then show the message "  ".*/
        public void IsNum1Bigger(double Num1, double Num2)
        {
            if (Num1>Num2 )
            {
                Console.WriteLine("Number one is bigger than number two");
            }
        }
        
         //Creating a print method where the user will get instructions and enter the two numbers.
        public void PrintIsNum1Bigger ()
        {
            Console.WriteLine("Enter the first number");
            double Number1 = (double)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            double Number2 = (double)Convert.ToDouble(Console.ReadLine());

            /*Calling on the first method and saying that the arguments Num1 and Num2
             is now in the print method Number 1 and Number 2*/

            IsNum1Bigger(Number1, Number2);
        }
    }
}
