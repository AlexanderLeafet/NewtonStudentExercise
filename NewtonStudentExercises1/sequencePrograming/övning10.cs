using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.sequencePrograming
{
    class övning10
    {

        //omvandla Farenheit till Celsius
            double Celsius;
            double Farenheit;

            public double CalcFarenheit()
        {
                return Celsius = (Farenheit - 32) / 1.8;
        }
            public void PrintCelsius()
            {
                Console.WriteLine("Ange temperatur i Farenheit: ");
                Farenheit = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("I celsius är det {0}", CalcFarenheit() + " grader");
            }
        }
}
