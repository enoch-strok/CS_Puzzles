using System;
using System.Collections.Generic;
using System.Linq;

namespace CS_Puzzles
{
    class Program
    {
        public static void RandomArray()
        {
            // Given an integer array, say [1, 5, 10, -2], create a function that prints the maximum number in the array, 
            // the minimum value in the array, and the average of the values in the array.
            int[] randomArray = new int[10];
            Random rnd = new Random();
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                int num = rnd.Next(25);
                randomArray[i] = num;
                Console.WriteLine($"{randomArray[i]} added to Array...");
                sum += num;
            }
            int minValue = randomArray.Min();
            Console.WriteLine($"Min: {minValue}");
            
            int maxValue = randomArray.Max();
            Console.WriteLine($"Max: {maxValue}");

            Console.WriteLine($"Sum: {sum}");

        }

                public static int TossCoin()
        {
            Random rnd = new Random();
            int num = rnd.Next(2);
            
            if (num == 0)
                {
                    Console.WriteLine($"Heads was chosen... ");
                }
                else
                {
                    Console.WriteLine($"Tails was chosen... ");
                }
                return num;
        }




        public static double TossMultipleCoins(int num)
        {
            int headsCount = 0;
            for (int i = 0; i < num; i++ ){
                int coinToss = TossCoin();
                if(coinToss == 0)
                {
                    headsCount += 1;
                }
            }
                double headsRatio = ((double) headsCount / num) * 100;
                Console.WriteLine($"Heads was chosen {headsCount} times ({headsRatio}%).");
                return headsRatio;
        }

        public static List<string> Names()
        {
            List<string> people = new List<string>();
            List<string> peopleFiltered = new List<string>();
            //Use the Add function in a similar fashion to push
            people.Add("Todd");
            people.Add("Tiffany");
            people.Add("Charlie");
            people.Add("Geneva");
            people.Add("Sydney");
            
            foreach(string person in people){
                Console.WriteLine(person);
            }

            Random rnd = new Random();
            for (int i = 0; i < people.Count; i++)
            {
                int selection = rnd.Next(people.Count-1);
                string value = people[selection];
                people[selection] = people[i];
                people[i] = value;

                Console.WriteLine($"{selection} was the randomly selected number");
                Console.WriteLine($"{value} is what is in that spot");
                Console.WriteLine($"{people[selection]} is swapping with {people[i]}");
            }

            foreach(string person in people){
                Console.WriteLine(person);
            }
            for (int i = 0; i < people.Count; i++)
            {
                string currentPerson = people[i];
                if(currentPerson.Length > 5){
                    peopleFiltered.Add(currentPerson);
                    Console.WriteLine($"Added {currentPerson} to new list");
                }
            }

            

            return peopleFiltered;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // RandomArray();
            // TossCoin();
            // TossMultipleCoins(21);
            Names();
        }
    }
}
