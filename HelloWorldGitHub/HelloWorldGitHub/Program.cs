using System;

namespace HelloWorldGitHub
{
    class Program
    {

        static void EscreveNatela(string txt)
        {
            Console.WriteLine(txt);
        }

        static void EscreveNatela2(string txt)
        {
            EscreveNatela(txt);
        }

        static void Main(string[] args)
        {
            EscreveNatela("Primeiro teste com GitHub");
            Console.ReadKey();
        }
    }
}
