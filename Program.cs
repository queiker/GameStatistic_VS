using System.IO;
using System.Threading.Tasks;
using System;


namespace GameStatistic_VS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string text =
            "TEST OK";
            write_to_file(text, "WriteText.txt");

        }

        static void write_to_file(string line, string src_to_file)
        {
            File.WriteAllTextAsync(src_to_file, line);
        }







    }
}
