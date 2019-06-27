using Newtonsoft.Json;
using Newtonsoft.Json.Bson;
using System;
using System.IO;

namespace JsonAndBson
{
    public class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Student(string Name, string Email)
        {
            this.Name = Name;
            this.Email = Email;
        }

        public void SaveToFile()
        {
            if (!Directory.Exists("Students"))
            {
                Directory.CreateDirectory("Students");
            }

            var jsonData = JsonConvert.SerializeObject(this, Formatting.Indented);

            File.WriteAllText($"Students/{this.Name}.json", jsonData);

        }

        public void SaveToFile(string studentString)
        {
            if (!Directory.Exists("Students"))
            {
                Directory.CreateDirectory("Students");
            }

            File.WriteAllText($"Students/{this.Name}.json", studentString);

        }

        public static Student LoadFromFile(string studentName)
        {
            if (!File.Exists($"Students/{studentName}.json"))
                return null;

            var jsonData = File.ReadAllText($"Students/{studentName}.json");

            if (IsBase64Encoded(jsonData))
            {
                // deserialize from bsom string
                byte[] bsonBytes = Convert.FromBase64String(jsonData);
                MemoryStream stream = new MemoryStream(bsonBytes);
                BsonReader reader = new BsonReader(stream);
                JsonSerializer serializer = new JsonSerializer();
                var student = serializer.Deserialize<Student>(reader);
                return student;
            }
            else
            {
                return JsonConvert.DeserializeObject<Student>(jsonData);
            }
        }

        public override string ToString()
        {
            return $"{this.Name},{this.Email}";
        }

        public static bool IsBase64Encoded(string testString)
        {
            try
            {
                byte[] data = Convert.FromBase64String(testString);
                return (testString.Replace(" ", "").Length % 4 == 0);
            }
            catch
            {
                return false;
            }
        }
    }
}
