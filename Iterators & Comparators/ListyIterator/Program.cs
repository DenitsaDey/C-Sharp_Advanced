using System;
using System.Collections.Generic;
using System.Linq;

namespace ListyIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            ListyIterator<string> listyIterator = null;

            string input = Console.ReadLine();
            while (input != "END")
            {
                try
                {
                    string[] tokens = input.Split();
                    string command = tokens[0];
                    switch (command)
                    {
                        case "Create":
                            List<string> elements = tokens.Skip(1).ToList();

                            listyIterator = new ListyIterator<string>(elements);
                            break;
                        case "Move":
                            Console.WriteLine(listyIterator.Move());
                            break;
                        case "Print":
                            listyIterator.Print();
                            break;
                        case "HasNext":
                            Console.WriteLine(listyIterator.HasNext());
                            break;

                        case "PrintAll":
                            foreach (string item in listyIterator)
                            {
                                Console.Write(item + " ");
                            }
                            Console.WriteLine();
                            break;
                    }
                }

                catch (InvalidOperationException e)
                {
                    Console.WriteLine(e.Message);
                }
                input = Console.ReadLine();
            }
        }
    }
}

