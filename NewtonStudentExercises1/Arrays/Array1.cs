using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.Arrays
{
    class Array1
    {
        public void ArrayEx()
        {
            double[] Laps = new double[3];

            Laps[0] = 3.25;
            Laps[1] = 2.25;
            Laps[2] = 3.89;

            double[] MachSpeed = { 2.1, 1.8, 3.5 };
            /*Console.WriteLine($"First laptime is: {Laps[0]}");
            Console.WriteLine($"First laptime is: {Laps[1]}");
            Console.WriteLine($"First laptime is: {Laps[2]}");*/

            for(int i = 0; i < MachSpeed.Length; i++)
            {
                Console.WriteLine($" Machspeed is:{MachSpeed[i]}");
            }
            /*Console.WriteLine($"First machspeed is: {MachSpeed[0]}");
            Console.WriteLine($"Second machspeed is: {MachSpeed[1]}");
            Console.WriteLine($"Third machspeed is: {MachSpeed[2]}");*/

            Array.Sort(Laps);
            Array.Reverse(Laps);
            foreach (var Speed in Laps)
            {
                Console.WriteLine($"Laptime is {Speed}");
            }

        }
        public void RunArray()
        {
            Array1 arr1 = new Array1();
            arr1.ArrayEx();
        }
    } 
}


