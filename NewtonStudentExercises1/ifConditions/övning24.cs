using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.ifConditions
{
    /*Läs in kropptempraturen, skriv “VARNING!!“” om temp är mindre än 35, och  om temp överstiger 42.*/
    class övning24
    {
        public void TestaTemp (double KroppsTemp)
        {
            if(KroppsTemp <35 && KroppsTemp > 42)
            {
                Console.WriteLine("VARNING!! Din kroppstemperatur är INTE normal");
            }
            else
            {
                Console.WriteLine("Din kroppstemperatur är normal!");
            }
        }
        public void PrintKroppsTemp()
        {
            Console.WriteLine("Ange din kroppstemperatur");
            double Temp = double.Parse(Console.ReadLine());
        }

    }
}
