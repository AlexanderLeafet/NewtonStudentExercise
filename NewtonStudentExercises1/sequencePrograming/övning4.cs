using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.sequencePrograming
{ // //Läs in tre tal, beräkna sedan medelvärdet av dess och summan
    class övning4
    {
        double Sum;
        double Average;

        public double CalcAverage(double Input1, double Input2, double Input3)
        {
            Sum = Input1 + Input2 + Input3;
            Console.WriteLine("Summan:" + $"{Sum}");
            return Average = Sum / 3;
        }
        public void PrintAverage()
        {
            Console.WriteLine("Ange tre tal och beräkna medelvärdet!");
            Console.WriteLine();

            Console.WriteLine("Ange det första talet: ");
            double firstNum = double.Parse(Console.ReadLine());

            Console.WriteLine("Ange det andra talet: ");
            double secondNum = double.Parse(Console.ReadLine());

            Console.WriteLine("Ange det tredje talet: ");
            double thirdNum = double.Parse(Console.ReadLine());

            Console.WriteLine("Medelvärdet av talen är: {0}", CalcAverage(firstNum, secondNum, thirdNum));

            
        }
    }
}
