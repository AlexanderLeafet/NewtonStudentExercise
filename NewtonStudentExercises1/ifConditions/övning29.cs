using System;
using System.Collections.Generic;
using System.Text;

/*Beräkna ankomsttiden för ett tåg.
Mata in följande:
 tidpunkt i timma och minut för avgången, tex 12:41
 körtid i timma och minuter.
Om minuter anges i 60 min eller mer, hantera det genom att lägga ett påslag på variabeln för timmar.*/
namespace NewtonStudentExercises.ifConditions
{
    class övning29
    {
        int ArrHour, ArrMin;
        public void TrainTime(int DepHour, int DepMin, int TravelHour, int TravelMin)
        {
            ArrHour = DepHour + TravelHour;
            ArrMin = DepMin + TravelMin;
            if(ArrMin >= 60)
            {
                ArrMin = ArrMin - 60;
                ArrHour = ArrHour + 1;
            }
            if (ArrHour >= 24)
            {
                ArrHour = ArrHour - 24;
                Console.WriteLine("Arrival NEXT DAY");
            }
            Console.WriteLine($"Arrival is at: {ArrHour}:{ArrMin}");
        }

        public void PrintTrainTime()
        {
            Console.WriteLine("Depature time in hours");
            int dh = int.Parse(Console.ReadLine());

            Console.WriteLine("Depature time in minutes");
            int dm = int.Parse(Console.ReadLine());

            Console.WriteLine("Travel time in hours");
            int th = int.Parse(Console.ReadLine());

            Console.WriteLine("Travel time in minutes");
            int tm = int.Parse(Console.ReadLine());

            TrainTime(dh, dm, th, tm);

        }
    }
}
