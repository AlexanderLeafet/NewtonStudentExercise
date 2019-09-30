using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.loopsWhile
{
    //Läs in ett antal tal. Inläsningar stoppas av talet 9999. 
    //Skriv ut medelvärdet av de inlästa talen.
    class övning56
    {
        int amount;
        int sum;
        int InputNum;
        public void PrintUnknown()
        {
            Console.WriteLine($"Write som numbers, to stop inserting numbers write 9999");
            
            while(InputNum != 9999)
            {
                Console.WriteLine("Write a number: ");
                int InputNum = int.Parse(Console.ReadLine());
                

                if (InputNum == 9999)
                {
                    Console.WriteLine($"The mean is: {sum / amount}");
                    break;
                    
                }
                else
                {
                    sum += InputNum;
                    amount += 1;
                }
            }

            
        }

        public static void Runövn56()
        {
            övning56 o56 = new övning56();
            o56.PrintUnknown();
        }
    }
}
