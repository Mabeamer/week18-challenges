using System;
using System.Collections.Generic;

namespace _2ndCchallenges
{
    class Program{
        static void Main(string[] args)
        {
            Console.WriteLine("Challenge 1");
            Console.WriteLine("Type a number to be divided.");
            int firstNumber = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Now type a number");
            int secondNumber = Convert.ToInt16(Console.ReadLine());
            int division = firstNumber / secondNumber;
            Console.WriteLine(division);

            Console.WriteLine("Challenge 2");
            var car1 = new Car();
            car1.model = "honda";
            var car2 = new Car();
            car2.model = "Toyota";
            var car3 = new Car();
            car3.model = "Mitsubishi";
            Console.WriteLine("car 1's model is a {0}",car1.model);
            Console.WriteLine("car 2's model is a {0}", car2.model);
            Console.WriteLine("car 3's model is a {0}", car3.model);

            Console.WriteLine("Challenge 3");
            Dictionary<string, Int16> road2hire = new Dictionary<string, Int16>();

            road2hire.Add("Markus", 18);
            road2hire.Add("Ian", 20);
            road2hire.Add("Angel", 19);
            road2hire.Add("Ivan", 18);
            road2hire.Add("Micky", 19);
            road2hire.Add("Juan",  19);
            road2hire.Add("Miguel", 23);
            road2hire.Add("Chris", 22);
            road2hire.Add("Britney", 23);
            road2hire.Add("Hunter", 19);
            road2hire.Add("Victoria", 23);
            road2hire.Add("Lesley", 18);
            road2hire.Add("Malik", 22);
            road2hire.Add("Tia", 23);
            road2hire.Add("random with the wisest age of", 101);
            Console.WriteLine("Dictionary Count: {0}", road2hire.Count);
            foreach (KeyValuePair<string, Int16> kvp in road2hire)
            {
                Console.WriteLine("{0}, {1}",
                    kvp.Key, kvp.Value);
            }
            road2hire.Remove("random with the wisest age of");
            Console.WriteLine("Removed random, the current value`: {0}", road2hire.Count);
            //challenge four

            Console.WriteLine("challenge 4");
            Differntcar love = new Differntcar(4, 2003, "Subaru", "Coupe");
            Differntcar hate = new Differntcar(2, 3017, "pontiac", "bar");
            Console.WriteLine(love.model);
            Console.WriteLine(hate.model);
        }
    }
}
