using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.ifConditions
{
    /*En anställd som har timlön får, när arbetstiden överstiger 40 timmar per  vecka, 
    övertidsbetalning för tiden utöver 40 timmar med en och halv timme. Läs in timlön och en veckas arbetstid. 
    Den totala veckolönen beräkans och skrivs ut.*/
    class övning19
    {
        
        public double CalcTimLön(double TimLön, double ArbetsTimmar)
        {
            double TotalLön;
            double ÖvertidsLön;
            double ÖvertidsTimmar;
            
            if(ArbetsTimmar>40)
            {
                ÖvertidsTimmar = ArbetsTimmar - 40;
                ÖvertidsLön = TimLön *  1.5;

                TotalLön = (ArbetsTimmar - ÖvertidsTimmar) * TimLön + ÖvertidsTimmar * ÖvertidsLön;


                return TotalLön;
                
            }
            else
            {
                TotalLön = ArbetsTimmar * TimLön;
                return TotalLön;
            }
            
        }
        public void PrintVeckoLön()
        {
            Console.WriteLine("Ange din timlön: ");
            double TL = double.Parse(Console.ReadLine());
            Console.WriteLine("Ange antal timmar: ");
            double AT = double.Parse(Console.ReadLine());
            Console.WriteLine("Din veckolön är: {0}", CalcTimLön(TL, AT));
            
        }
    }
}
