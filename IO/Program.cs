using System;
using System.IO;


namespace IO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, please enter any number:");
            int num = Convert.ToInt32(Console.ReadLine());
            using (StreamWriter file = new StreamWriter(@"C\Users\tamar\Logs\log.txt", true))
            {
                file.Write(num);
            }
        }
    }
}
