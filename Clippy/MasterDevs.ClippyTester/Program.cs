using Clippy;
using System;

namespace MasterDevs.ClippyTester
{
    public class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            var output = @"Hello world";
            Console.WriteLine("Writing <{0}> to clipboard", output);

            using (var writer = new ClipboardWriter())
            {
                writer.Write(output);
            }

            string input = "nothing";
            using (var reader = new ClipboardReader())
            {
                input = reader.ReadToEnd();
            }

            Console.WriteLine("Read <{0}>", input);

            Console.WriteLine("Do they match? {0}", input == output ? "yes" : "no");

            Console.ReadLine();
        }
    }
}