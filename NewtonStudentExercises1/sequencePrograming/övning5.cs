using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.sequencePrograming
{
    class övning5
    {
        //omvandla sek till pund och dollar.
        
            int dollar = 11;
            int pund = 13;

            public double SekToDollar(int sek)
            {
                return (double)sek / dollar;
            }
            public double SekToPund(int sek)
            {
                return (double)sek / pund;
            }

            public void ConvertCurrency()
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.WriteLine("Ange antal kr");
                int sek = (int)Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Dollar: {0}", SekToDollar((int)sek));
                Console.WriteLine("Pund: {0}", SekToPund((int)sek));
                Console.ReadKey();

            }

    }
}

