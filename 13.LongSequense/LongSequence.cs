using System;

class LongSequence
{
    static void Main()
    {
        Console.BufferHeight = 1010;
        int i = 2;
        for (int n = 1; n <= 1000; n++, i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine(-i);
            }
        }
    }
}
