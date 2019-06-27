using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace JSONParse
{
    class CourseCompair : IEqualityComparer<Course>
    {
        public bool Equals(Course x, Course y)
        {
            return x.CourseName.Equals(y.CourseName) && x.Instructor.Equals(y.Instructor);
        }

        public int GetHashCode(Course obj)
        {
            return (obj.CourseName != null ? obj.CourseName.GetHashCode() : 0) ^
                (obj.Instructor != null ? obj.Instructor.GetHashCode() : 0);
        }
    }

    class Utils
    {
        public static List<Course> LoadAllCourses()
        {
            string allCourses = File.ReadAllText("Courses/courses.json");
            return JsonConvert.DeserializeObject<List<Course>>(allCourses);
        }

        public static List<Course> NotRegisteredCourses(Student student)
        {
            var allCourses = LoadAllCourses();
            var registered = student.Courses;

            var exceptedList = allCourses.Except(registered, new CourseCompair()).ToList();

            return exceptedList;

        }
    }
}
