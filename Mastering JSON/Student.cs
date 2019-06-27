using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace JSONParse
{
    class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public List<string> IntrestedSubjects { get; set; }
        public List<Course> Courses { get; set; }

        public Student()
        {

        }

        public Student(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public void RegisterCourse(Course course)
        {
            if (Courses == null)
                Courses = new List<Course>();

            Courses.Add(course);

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

        public static Student LoadFromFile(string filename)
        {
            if (!File.Exists($"Students/{filename}.json"))
                return null;

            var jsonData = File.ReadAllText($"Students/{filename}.json");

            //var student = JsonConvert.DeserializeObject<Student>(jsonData);
            //return student;

            return JsonConvert.DeserializeObject<Student>(jsonData);
        }

        public override string ToString()
        {
            if (this.Courses == null)
                this.Courses = new List<Course>();

            return $"\n********************************************\n\t" +
                   $"Details of {this.Name}\n" +
                   $"********************************************\n" +
                   $"Name: {this.Name}\nEmail: {this.Email}\n" +
                   $"Intrested Subjects: {String.Join(", ", this.IntrestedSubjects)}\n" +
                   $"Registered Courses: " +
                   $"\n  {String.Join("\n  ", this.Courses)}";
        }
    }
}