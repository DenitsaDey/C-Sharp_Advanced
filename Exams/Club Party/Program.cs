using System;
using System.Collections.Generic;
using System.Linq;

namespace _24_Feb_Club_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int hallCapacity = int.Parse(Console.ReadLine());
            Stack<string> input = new Stack<string>(Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries));

            Queue<string> halls = new Queue<string>();
            Dictionary<string, List<int>> output = new Dictionary<string, List<int>>();// crete a Dictionary for each hall and its List of parties(in order to use the Sum() when comapring to the capacity)

            while (input.Count > 0) //while there is elements in the initial output
            {
                string current = input.Pop();

                string currentHall = string.Empty;
                int currentPplWaiting = 0;

                if (!int.TryParse(current, out currentPplWaiting)) // element is a hall  
                {
                    currentHall = current;
                    halls.Enqueue(currentHall); // we add it to the available open halls
                    output.Add(currentHall, new List<int>()); // we create a list to keep the parties that have entered that hall
                }
                else // element is a reservation indicating number of people in a party
                {
                    currentPplWaiting = int.Parse(current);
                    if (halls.Count > 0) // if there is open halls
                    {
                        if((output[halls.Peek()].Sum() + currentPplWaiting) > hallCapacity) // we close the hall and print it without adding the people waitng 
                        {
                            Console.WriteLine($"{halls.Peek()} -> {string.Join(", ", output[halls.Peek()])}");
                            halls.Dequeue();
                           
                        }           
                        if(halls.Any()) // if there is still any available open halls in the Queue add party to the next available hall 
                        {
                            output[halls.Peek()].Add(currentPplWaiting);
                        }                       
                    }
                }
            }
        }
    }
}