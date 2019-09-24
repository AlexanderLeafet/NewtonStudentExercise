using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.loopsFor
{
    class övning42
    {

        //Read and add 20 whole numbers. The sum is going to be printed.
        public void AddNum()
        {
            int Sum = 0;
            for(int i = 1; i<=4; i++)
            {
                Console.WriteLine($"Ange tal: {i}");
                int Numbers = Convert.ToInt32(Console.ReadLine());

                Sum += Numbers;

            }
            Console.WriteLine($"Summan av talen är: {Sum}");
        }
    }
}
