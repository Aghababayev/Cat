using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
namespace Cat
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo keyinfo;
            do
            {
                Generator generator = new();
                var data = generator.Generate();
                Console.WriteLine(" \nfact: {0} length:{1} ", data.Result.fact, data.Result.length);
                Console.Write("Press Escape (Esc) for exit or other key to continue... \n");
                keyinfo = Console.ReadKey();
            } while (keyinfo.Key != ConsoleKey.Escape);
        }
    }
}
