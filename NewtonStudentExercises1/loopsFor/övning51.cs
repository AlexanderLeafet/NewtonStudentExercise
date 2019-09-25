using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.loopsFor
{
    class övning51
    {
        /*Read 10 Whole numbers and print how many times the number 7 has been readed.
         The number 7 must be readed at least 1 time.*/

        /*Creating a method called "PrintNumSeven"*/
        public void PrintNumSeven()
        { 
            //Instruction for the user.
            Console.WriteLine($"Write 10 whole numbers! ");
            //Declaring "Input" and "Times"
            int Input;
            int Times = 0;

            //Creating a for loop that lets the user type in 10 numbers in a row.
            for(int i = 1; i <= 10; i++)
            {
            //by Saying {i} in the write line it will show the round number of the loop.
                Console.WriteLine($"Write Number {i}");
           
             /*When user write in program its stored as a string in the variable ''Input''
             so i have to convert it to its original datatype again which is a int.*/
                Input = Convert.ToInt32(Console.ReadLine());
                
             /*if user types 7 in the for loop, Store it in the variable ''Times'' 
               and add 1 to the variable every time it's typed.*/
                if (Input == 7)
                {
                    Times++;
                }
            }
            //Shows the value of the variable Times
            Console.WriteLine($"Number 7 is given {Times} times ");



        }
    }
}
