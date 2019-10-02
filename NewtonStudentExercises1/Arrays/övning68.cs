using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.Arrays
{
    //Skapa en array med fem tal, fördubbla värdet på talen på varje indexplats i arrayn. 

    class övning68
    {
        public void doubleArray()
        {
            int[] numbers = new int[5] { 2, 4, 6, 8, 10 };
            int i = 0;
            foreach(var num in numbers)
            {
                i = num * 2;
                Console.WriteLine($"Number {num} * 2 is: {i}");
            }
            
        }
        public static void Runövning68()
        {
            övning68 o68 = new övning68();
            o68.doubleArray();
        }
    }
}


   
            
   


           
