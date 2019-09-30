using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises.Collections
{
    public class Collection1
    {
        public void CollectionEx1()
        {
            ArrayList Medical = new ArrayList();
            Medical.Add("Alexander");
            Medical.Add(21);
            Medical.Add(183);
            Medical.Add(26.4f);

            foreach (object med in Medical)
            {
                Console.WriteLine(med);
            }
        }

        public void CollectionEx2()
        {
            int sum = 0;
            List<int> Grocery = new List<int>();
            Grocery.Add(34);
            Grocery.Add(134);
            Grocery.Add(4);
            Grocery.Add(304);
            Grocery.Add(56);

            foreach (var price in Grocery)
            {
                sum += price;
            }
            Console.WriteLine($"{sum}");

        }

        public static void RunCollection()
        {
            Collection1 c1 = new Collection1();
            c1.CollectionEx1();

            Collection1 c2 = new Collection1();
            c2.CollectionEx2();
        }
        
        
    }
}
