using System;
using System.Collections.Generic;
using System.Linq;

namespace _21._Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int gunSize = int.Parse(Console.ReadLine());
            int initialGunSize = gunSize;
            int[] bullets = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int[] locks = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int priseValue = int.Parse(Console.ReadLine());
            Queue<int> locksQueue = new Queue<int>(locks);
            Stack<int> bulletsAvailable = new Stack<int>(bullets);
            while(bulletsAvailable.Count != 0)
            {
                if (locksQueue.Count != 0)
                {
                    int currentBullet = bulletsAvailable.Pop();
                    priseValue -= bulletPrice;
                    gunSize--;

                    if (currentBullet <= locksQueue.Peek())
                    {
                        locksQueue.Dequeue();
                        Console.WriteLine("Bang!");
                    }
                    else if (currentBullet > locksQueue.Peek())
                    {
                        Console.WriteLine("Ping!");
                    }
                    
                }
                else if (locksQueue.Count == 0)
                {
                    break;
                }
                if (gunSize == 0 && bulletsAvailable.Count!=0)
                {
                    Console.WriteLine("Reloading!");
                    gunSize = initialGunSize;
                }
            }
            if(bulletsAvailable.Count == 0 && locksQueue.Count > 0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locksQueue.Count}");
            }
            else if(locksQueue.Count == 0)
            {
                Console.WriteLine($"{bulletsAvailable.Count} bullets left. Earned ${priseValue}");
            }
        }
    }
}
