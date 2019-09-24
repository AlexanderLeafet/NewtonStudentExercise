using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.loopsFor
{
    class ForEachExample
    {
        string[] Customers = { "SAAB", "Boeing", "Airbus" };

        public void ForEachex1()
        {
            foreach (var Customer in Customers)
            {
                Console.WriteLine($"Aircraft makers: {Customer}" );
            }
        }
    }
}
