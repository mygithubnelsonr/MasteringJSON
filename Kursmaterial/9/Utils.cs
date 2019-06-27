﻿using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace JSONParse
{
    class Utils
    {
        public static List<Course> LoadAllCourses()
        {
            return JsonConvert.DeserializeObject<List<Course>>(File.ReadAllText("Courses/courses.json"));
        }
        //        public static List<Course> LoadAllCourses(List<Course> resgisteredCourses)
        //        {
        //            var allCourses = JsonConvert.DeserializeObject<List<Course>>(File.ReadAllText("Courses/courses.json"));
        //
        //            var exceptedList = allCourses.Except(resgisteredCourses, new CompareCourses()).ToList();
        //            return allCourses.Except(resgisteredCourses, new CompareCourses()).ToList<Course>();
        //        }

        public static List<Course> LoadAllCourses(List<Course> courses)
        {
            string strCourses = File.ReadAllText("Courses/courses.json");
            var coursesAll = JsonConvert.DeserializeObject<List<Course>>(strCourses);

            var exceptedList = coursesAll.Except(courses, new CompareCourses()).ToList();


            return exceptedList;
        }
    }
}