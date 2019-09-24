using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.loopsWhile
{
    class övning39
    {
        //Läs in ett pris och skriv ut priset inkl moms på 25%. Inläsningen avslutas med 0
        public void PrintPriceWithVat()
        {

            while (true)
            {


                Console.WriteLine($"What's the price without VAT?");
                float Price = Convert.ToInt32(Console.ReadLine());

                float PriceWithVat = Price * 1.25f;
                Console.WriteLine($"Price with VAT is: {PriceWithVat}");

                if(Price == 0)
                {
                    break;
                }
            }
           

        }
    }
}
