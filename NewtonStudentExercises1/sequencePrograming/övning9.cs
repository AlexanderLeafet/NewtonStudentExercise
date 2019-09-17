using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.sequencePrograming
{
    class övning9
    {
        /*beräkna en cirkels diameter, omkrets och area. Läs in cirkelns radie.
   Printa resultaten med string interpolation i en enda writeline metod.*/
      
        
            //skapar en funktion där vi räknar ut cirkelns diameter
            public double CalcDiameter(double radie)
            {
                return radie * 2;
            }
            //skapar en funktion där vi räknar ut cirkelns omkrets
            public double CalcOmkrets(double radie)
            {
                return 2 * radie * Math.PI;
            }
            //skapar en funktion där vi räknar ut cirkelns area
            public double CalcArea(double radie)
            {
                return Math.PI * radie * radie;
            }
            //skapar en metod där vi skriver ut följande beräkningar med hjälp av ett invärde för radien från användaren
            public void PrintCirkel()
            { //här använder vi ToString 0.00 för att få det uskrivna talet i 2 decimaler.
                Console.WriteLine("Beräkna cirkelns Diameter, omkrets och area. Ange ett värde för cirklens radie:");
                double radie = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Diametern är: {0}", CalcDiameter(radie).ToString("0.00"));
                Console.WriteLine();

                Console.WriteLine("Omkretsen är: {0}", CalcOmkrets(radie).ToString("0.00"));
                Console.WriteLine();

                Console.WriteLine("Arean är: {0}", CalcArea(radie).ToString("0.00"));
                Console.WriteLine();

                Console.ReadKey();


            }
        }
}
