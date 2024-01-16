using System;

class Program
{
    static void Main()
    {
        int[] evenNumbers = new int[3];

        evenNumbers[0] = 1;
        evenNumbers[1] = 2;
        evenNumbers[2] = 3;

        //Console.WriteLine(evenNumbers);

        for (int i = 0; i < 3; ++i)
            Console.WriteLine(i + "-> "+evenNumbers[i]);
    }
}