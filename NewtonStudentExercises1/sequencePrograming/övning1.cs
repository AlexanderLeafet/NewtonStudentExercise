using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.sequencePrograming
{
    class övning1
    {//Beräkna kvadraten av ett tal som läses in
        int tal;
        //skapar en funktion för att beräkna kvadraten
        public int CalcKvadrat()
        {
            return tal * tal;
        }
        //skapa en printmetod
        public void PrintKvadraten()
        {
            Console.WriteLine("Ange ett tal för att beräkna kvadraten:");
            tal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ditt tal är: {0}", CalcKvadrat());


        }
    }

}
