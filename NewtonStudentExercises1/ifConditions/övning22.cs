using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.ifConditions
{
    /*Let the user enter a number, test if the number is between 0 to 9 but not 5. 
     Print right or wrong.*/
    class övning22
    {
        /*Creating a Method that says if Userinput1 is greather than or equals to 0 AND if USerinput1
         is less than or equals to 9 AND if Userinput1 NOT equals to 5 Print Right*/

        public void TestInput(double UserInput1)
        {
            if(UserInput1 >= 0 && UserInput1 <= 9 && UserInput1 != 5)
            {
                Console.WriteLine("Right");
            }
            //If the if statement isn't true, Print False by a else statement.
            else
            {
                Console.WriteLine("Wrong");
            }
        }
        //Creating a print method where the user will get instructions and enter the number.
        public void PrintTestInput()
        {
            Console.WriteLine("Enter a number between 0 to 9 but it can not be 5.");
            double Num = double.Parse(Console.ReadLine());

            /*Calling on the first method and saying that the argument Userinput1
             is now in the print method Num*/

            TestInput(Num);
        }
    }
}
