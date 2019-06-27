using Newtonsoft.Json;
using System;
using System.IO;

namespace XMLandJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            string rawJson = File.ReadAllText("Courses.json");

            var jsonString = JsonConvert.DeserializeXNode(rawJson);
            Console.WriteLine(jsonString);

            var xmlString = JsonConvert.SerializeXNode(jsonString, Formatting.Indented);
            Console.WriteLine($"\n{xmlString}");

            Console.WriteLine("\npress any key to continue...");
            Console.ReadKey();
        }
    }
}
