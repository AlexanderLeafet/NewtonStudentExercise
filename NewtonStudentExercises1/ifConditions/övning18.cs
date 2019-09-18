using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.ifConditions
{
    /*Läs in värden av två tal, X och Y. Tilldela sedan variablen A värdet 2 om   X är större än 5 + Y.  
    I annat fall så tilldelas variablen A värdet 5.*/

    class övning18
    {
        int a;
        public void CalcEkv(int x, int y)
        {
            
            if(x> 5 + y)
            {
                a = 2;
                Console.WriteLine("Värdet för A är 2");
            }
            else
            {
                a = 5;
                Console.WriteLine("Värdet för A är 5");
            }
        }
        public void PrintEkv()
        {
            Console.WriteLine("Skriv värde för X: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv värde för Y:");
            int y = int.Parse(Console.ReadLine());

            CalcEkv(x, y);
        }
    }
}
