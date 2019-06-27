using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace JSONParse
{
    public class Course
    {
        public string CourseName { get; set; }
        public string Instructor { get; set; }

        public Course(string courseName, string instructor)
        {
            CourseName = courseName;
            Instructor = instructor;
        }

        public void SaveToFile()
        {
            if (!Directory.Exists("Courses"))
            {
                Directory.CreateDirectory("Courses");
                File.WriteAllText("Courses/courses.json", "[]");
            }

            // 1. read all courses from courses.json
            string jsonString = File.ReadAllText(@"Courses\courses.json");
            var courseList = JsonConvert.DeserializeObject<List<Course>>(jsonString);

            // 2. add current Course to that list
            courseList.Add(this);

            // 3. save the resultant list back to the courses.json
            jsonString = JsonConvert.SerializeObject(courseList, Formatting.Indented);
            File.WriteAllText("Courses/courses.json", jsonString);

        }

        public override string ToString()
        {
            return $"Course Name: {this.CourseName}, " +
                   $"Instructor: {this.Instructor}";
        }
    }
}