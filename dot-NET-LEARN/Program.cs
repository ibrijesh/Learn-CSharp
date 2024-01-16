using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter Your Roll Number");
        int userNumber = int.Parse(Console.ReadLine());

        if (userNumber == 1)
        {
            Console.WriteLine("User Roll Number is 1");
        }
        else if (userNumber == 2)
        {
            Console.WriteLine("User Roll Number is 2");
        }
        else if (userNumber == 3)
        {
            Console.WriteLine("User Roll Number is 3");
        }
        else
        {
            Console.WriteLine("Your roll number not between 1 and 3");
        }

    }
}