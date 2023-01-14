using System;
using System.Collections.Generic;
using System.Linq;

namespace P11KeyRevolver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int gunSize = int.Parse(Console.ReadLine());

            int[] bulletsInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] locksInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int inteligence = int.Parse(Console.ReadLine());

            Stack<int> bullets = new Stack<int>(bulletsInput);
            Queue<int> locks = new Queue<int>(locksInput);
            int bulletsLeft = gunSize;
            int locksPicked = 0;
            int bulletsFiered = 0;
            while (bullets.Count > 0 && locks.Count > 0)
            {
                int currBullet = bullets.Pop();
                bulletsFiered++;
                int currentLock = locks.Peek();
                bulletsLeft--;
                if (currBullet <= currentLock)
                {
                    Console.WriteLine("Bang!");
                    locksPicked++;
                    locks.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }
                if (bulletsLeft == 0)
                {
                    if (bullets.Count > 0)
                    {
                        Console.WriteLine("Reloading!");
                        bulletsLeft = gunSize;
                    }
                }
            }

            if (locks.Count > 0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
            else
            {
                int totalMoney = inteligence - bulletsFiered * bulletPrice;
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${totalMoney}");
            }
        }
    }
}
