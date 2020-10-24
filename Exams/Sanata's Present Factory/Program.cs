using System;
using System.Collections.Generic;
using System.Linq;

namespace _17_Dec_Santa_s_Present_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] materialInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] magicInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Dictionary<string, int> craftedGifts = new Dictionary<string, int>
            {
                { "Doll", 0 },
                { "Wooden train", 0 },
                { "Teddy bear", 0 },
                { "Bicycle", 0 }
            };
            int[] presents = new int[] { 150, 250, 300, 400 };

            Stack<int> materials = new Stack<int>(materialInput);
            Queue<int> magic = new Queue<int>(magicInput);

            while (materials.Count > 0 && magic.Count > 0)
            {
                int multiplyResult = materials.Peek() * magic.Peek();
                if (multiplyResult < 0)
                {
                    int sum = materials.Pop() + magic.Dequeue();
                    materials.Push(sum);
                }
                else if (!presents.Contains(multiplyResult) && multiplyResult != 0)
                {
                    magic.Dequeue();
                    int currentMaterial = materials.Pop() + 15;
                    materials.Push(currentMaterial);
                }
                else if(multiplyResult == 0)
                {
                    if(materials.Peek()== 0)
                    {
                        materials.Pop();
                    }
                    if(magic.Peek() == 0)
                    {
                        magic.Dequeue();
                    }
                }
                else if (presents.Contains(multiplyResult))
                {
                    materials.Pop();
                    magic.Dequeue();
                    if (multiplyResult == 150)
                    {
                        craftedGifts["Doll"]++;               
                    }
                    if (multiplyResult == 250)
                    {
                        craftedGifts["Wooden train"]++;
                    }
                    if (multiplyResult == 300)
                    {
                        craftedGifts["Teddy bear"]++;
                    }
                    if (multiplyResult == 400)
                    {
                        craftedGifts["Bicycle"]++;
                    }
                }
            }
            if((craftedGifts["Doll"] > 0 && craftedGifts["Wooden train"]> 0)
                || (craftedGifts["Teddy bear"] > 0 && craftedGifts["Bicycle"] > 0))
            {
                Console.WriteLine("The presents are crafted! Merry Christmas!");
            }
            else
            {
                Console.WriteLine("No presents this Christmas!");
            }

            if(materials.Count > 0)
            {
                Console.WriteLine($"Materials left: {string.Join(", ", materials)}");
            }
            if(magic.Count > 0)
            {
                Console.WriteLine($"Magic left: {string.Join(", ", magic)}");
            }
            foreach (var toy in craftedGifts.Where(x=>x.Value > 0).OrderBy(t=>t.Key).ToDictionary(x=>x.Key, y=>y.Value))
            {
                Console.WriteLine($"{toy.Key}: {toy.Value}");
            }
        }
    }
}
