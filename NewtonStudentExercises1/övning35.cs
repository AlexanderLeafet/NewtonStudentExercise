using System;
namespace NewtonStudentExercises
{
    public class övning35
    {
        //Beräkna och skriv ut kvadraten för talen 1 till 9
        //Resultet ska skrivas i formen som "Kvadraten för 1 är: 1"

        public void Kvadrat()
        {
            int Resultat;

            for (int i = 1; i <= 9; i++)
            {
                Resultat = i * i;
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.WriteLine($"Kvadraten för {i} är: {Resultat}");
            }
        }
    }
}
