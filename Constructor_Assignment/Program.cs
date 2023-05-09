using System;

namespace Constructor_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            const string const1 = "Your name is: ";
            const string const2 = "Your favourite Number is: ";
            var answer = Console.ReadLine();
            if (float.TryParse(answer, out float x))
                }
            Console.WriteLine("const2");
            Chain newChain = new Chain(x);
            Console.ReadLine();
            }
            else
            {
            Console.WriteLine("const1");
            Chain newChain = new Chain(answer);
            Console.ReadLine();
        }
        }
    }
}
