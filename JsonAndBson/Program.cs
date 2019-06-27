using Newtonsoft.Json;
using Newtonsoft.Json.Bson;
using System;
using System.IO;

namespace JsonAndBson
{
    class Program
    {
        static void Main(string[] args)
        {
            //WriteStudent();
            //WriteBson();
            //ReadBson();

            // student from BSON file
            var student1 = Student.LoadFromFile("Marlon");
            Console.WriteLine(student1);
            // student from JSON
            var student2 = Student.LoadFromFile("Alba");
            Console.WriteLine(student2);

            Console.WriteLine("\npress any key to continue...");
            Console.ReadKey();
        }

        static void WriteStudent()
        {
            var student = new Student(Name: "Marlon", Email: "marlon@gmx.com");
            student.SaveToFile();
        }

        static void WriteBson()
        {
            var studentString = File.ReadAllText($"Students/Marlon.json");
            Student student = JsonConvert.DeserializeObject<Student>(studentString);
            Console.WriteLine($"Student from file: {student}");

            // serialize to binary json
            MemoryStream stream = new MemoryStream();
            BsonWriter writer = new BsonWriter(stream);
            JsonSerializer serializer = new JsonSerializer();
            serializer.Serialize(writer, student);
            string bsonString = Convert.ToBase64String(stream.ToArray());
            Console.WriteLine($"Bson string:\n{bsonString}");
            student.SaveToFile(bsonString);
        }

        static void ReadBson()
        {
            // deserialize from bsom string
            var bsonString = File.ReadAllText($"Students/Marlon.json");
            byte[] bsonBytes = Convert.FromBase64String(bsonString);
            MemoryStream stream = new MemoryStream(bsonBytes);
            BsonReader reader = new BsonReader(stream);
            JsonSerializer serializer = new JsonSerializer();
            Student student = serializer.Deserialize<Student>(reader);

            Console.WriteLine($"Student object from bsom string:");
            Console.WriteLine(student);
        }
    }
}
