using System;

class Program
{
    static void Main()
    {
        double f = 11223432423423234.34834534;

        int fi = (int)f;                    // it will -INT_MIN value as default
        int ff = Convert.ToInt32(f);        // it will through exception as f is out of range of int32


        // int to string

        int a = 10;
        string str = Convert.ToString(a);
        Console.WriteLine(a);

        // string to int
        string s = "123";
        int b = Convert.ToInt32(s);
        Console.WriteLine(b);
    }
}