using System.Diagnostics;
using System.Timers;

namespace Typing_Speed_Test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Typing Speed Test");
            bool again = true;
            do
            {
                Console.WriteLine("Type what you see");
                Stopwatch stopwatch = new Stopwatch();
                string input;
                string output = "This";
                Console.WriteLine(output);
                stopwatch.Start();
                input = Console.ReadLine();
                Console.WriteLine(input);
                stopwatch.Stop();
                Console.WriteLine("{0:m//:ss\\.fff}", stopwatch.Elapsed);
                if (input == output)
                {
                    Console.WriteLine("Correct");
                }
                else
                {
                    Console.WriteLine("Incorrect");
                }
            } while (again);

        }
    }
}
