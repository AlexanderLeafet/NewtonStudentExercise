using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.sequencePrograming
{
    class övning8
    {
        int sida1;
        int sida2;



        public double Omkrets()
        {
            return (double)sida1 * 2 + sida2 * 2;
        }
        public double Area()
        {
            return (double)sida1 * sida2;
        }

        public void CalcRektangel()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Räkna ut omkretsen samt arean på en rektangel. Skriv in värdet av första sidan:");
            sida1 = (int)Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Skriv in värdet av andra sidan:");
            sida2 = (int)Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Omkretsen är: {0}", Omkrets());
            Console.WriteLine("Arean på rektangeln är: {0}", Area());
        }
    }
}
