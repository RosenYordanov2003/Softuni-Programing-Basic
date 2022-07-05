using System;

namespace High_Jump
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int goal = int.Parse(Console.ReadLine());
            int start = goal - 30;
            int succeesJumps = 0;
            int failedJump = 0;
            int total = 0;
            int jumps = 0;
            while (true)
            {
                if (start > goal)
                {
                    break;
                }
                if (failedJump == 3)
                {
                    break;
                }
                for (int i = 1; i <= 3; i++)
                {
                    int atempts = int.Parse(Console.ReadLine());
                    if (atempts > start)
                    {
                        start += 5;
                        succeesJumps++;
                        failedJump = 0;
                        jumps++;
                    }
                    else
                    {
                        failedJump++;
                        jumps++;
                    }
                    if (start > goal)
                    {
                        total = start - 5;
                        break;
                    }
                    if (failedJump == 3)
                    {
                        break;
                    }
                }
            }
            if (failedJump == 3)
            {
                Console.WriteLine($"Tihomir failed at {start}cm after {jumps} jumps.");
            }
            else
            {
                Console.WriteLine($"Tihomir succeeded, he jumped over {total}cm after {jumps} jumps.");
            }
        }
    }
}
