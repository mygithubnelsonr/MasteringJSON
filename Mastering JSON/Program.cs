using System;
using System.Collections.Generic;
using System.Linq;

namespace JSONParse
{
    class Program
    {
        static void Main(string[] args)
        {
            //WriteToJsonFile();

            //ReadFromJsonFile();

            //SaveCoursesToArray();

            //Utils.ListExept();

            ProgramChoice();

            Console.WriteLine("\npress any key to continue...");
            Console.ReadKey();

        }

        static void ProgramChoice()
        {
            bool newStudent = false;

            while (true)
            {
                Console.Write("\nLogin: \n----------------------\n" +
                    "\t1. Instructor\n" +
                    "\t2. Student\n" +
                    "\t9. Exit\n" +
                    "\n\tChoice: "
                    );

                var input = Console.ReadLine();

                int choice;
                if (input == "")
                {
                    choice = 9;
                }
                else
                {
                    choice = Convert.ToInt32(input);
                }

                if (choice == 1)
                {
                    Console.Write("Enter Course Name: ");
                    string courseName = Console.ReadLine();
                    Console.Write("Enter your name: ");
                    string instructorName = Console.ReadLine();

                    var course = new Course(courseName, instructorName);
                    course.SaveToFile();
                    Console.WriteLine($"\n{course.CourseName} has been created successfully!");

                }
                else if (choice == 2)
                {
                    Console.Write("Enter your Login Name: ");
                    string studentName = Console.ReadLine();
                    var student = Student.LoadFromFile(studentName);

                    if (student == null)
                    {
                        newStudent = true;
                        Console.Write("Enter your E-Mail ID: ");
                        string studentemail = Console.ReadLine();
                        Console.Write("Enter your interested Subjects [in a comma seperated format]: ");
                        var studentInterests = Console.ReadLine();

                        if (studentInterests != null)
                        {
                            student = new Student()
                            {
                                Email = studentemail,
                                Name = studentName,
                                IntrestedSubjects = studentInterests.Split(',').ToList(),
                                Courses = new List<Course>()
                            };

                            student.SaveToFile();

                            if (newStudent == true)
                                Console.WriteLine($"\n{student.Name} has been created successfully!");
                        }
                        else
                            return;
                    }

                    bool content = true;
                    while (content)
                    {
                        Console.Write("\nOptions:\n" +
                            "\t1. View Profile\n" +
                            "\t2. View Avaiable Courses\n" +
                            "\t3. View registered Courses\n" +
                            "\t4. Register a new Course\n" +
                            "\t5. View interested Subjects\n" +
                            "\t9. Exit\n" +
                            "\n\tChoice: "
                            );

                        choice = Convert.ToInt32(Console.ReadLine());
                        var allCourses = Utils.LoadAllCourses();

                        switch (choice)
                        {
                            case 1: // View Profile
                                Console.WriteLine(student);
                                break;
                            case 2: // View Avaiable Courses
                                Console.WriteLine(String.Join(" \n", allCourses));
                                break;
                            case 3: // View registered Courses
                                Console.WriteLine("\nRegistered Courses:");
                                Console.WriteLine(new String('-', 60));
                                Console.WriteLine("\t" + String.Join("\n\t", student.Courses));
                                Console.WriteLine(new String('-', 60));
                                break;
                            case 4: // Register a new Course

                                int count = 0;
                                // Console.WriteLine(String.Join(" \n", allCourses));
                                Console.WriteLine("\nAvaiable Courses:");
                                Console.WriteLine(new String('-', 60));

                                var avaiableCourse = Utils.NotRegisteredCourses(student);

                                foreach (Course c in avaiableCourse)
                                {
                                    Console.WriteLine($"{++count})\t{c}");
                                }
                                Console.WriteLine(new String('-', 60));
                                Console.Write("\nChoice (0 is back): ");
                                try
                                {
                                    choice = Convert.ToInt32(Console.ReadLine());
                                    Course course = allCourses[choice - 1];
                                    student.RegisterCourse(course);
                                    student.SaveToFile();
                                    Console.WriteLine($"{avaiableCourse[choice - 1]} has been registered successfully!");
                                }
                                catch
                                {
                                    Console.WriteLine("Please enter a valid number!");
                                }

                                break;
                            case 5: // View interested Subjects
                                if (student.Courses == null)
                                    student.Courses = new List<Course>();
                                Console.WriteLine("\n" + String.Join(",", student.IntrestedSubjects));
                                break;

                            case 9: // Exit
                                Console.WriteLine($"{student} logout successfully!");
                                content = false;
                                break;
                            default:
                                Console.WriteLine("Enter a valide input!");
                                break;
                        }



                    }


                }
                else if (choice == 9)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid input!");
                    break;
                }
            }
        }

        static void SaveCoursesToArray()
        {
            var course1 = new Course("C#", "Mosh");
            course1.SaveToFile();
            var course2 = new Course("jNode", "Li Pi");
            course2.SaveToFile();
            var course3 = new Course("Java", "Peter Falk");
            course3.SaveToFile();
            var course4 = new Course("Angular", "Susi Sauer");
            course4.SaveToFile();
        }

        static void WriteToJsonFile()
        {
            var course1 = new Course("C#", "Mosh");
            var course2 = new Course("jNode", "Li Pi");
            var course3 = new Course("Java", "Peter Falk");
            var course4 = new Course("Angular", "Susi Sauer");

            var student1 = new Student()
            {
                Name = "Peter Pan",
                Email = "pp@gmail.com",
                IntrestedSubjects = new List<string>() { "C#", "jNode" },
                Courses = new List<Course>() { course1, course2 }
            };

            var student2 = new Student("Lolli Pop", "lollipop@aigo.com")
            {
                //Name = "Lolli Pop",
                //Email = "lollipop@aigo.com",
                IntrestedSubjects = new List<string>() { "Java", "angular" },
                Courses = new List<Course>() { course3, course4 }
            };

            var student3 = new Student("Pussy Cat", "pussycat@aol.com")
            {
                IntrestedSubjects = new List<string>() { "Java", "ASP.Net" },
                Courses = new List<Course>() { course3 }
            };

            student1.SaveToFile();
            student2.SaveToFile();
            student3.SaveToFile();

            //Console.WriteLine(course1);
            //Console.WriteLine(course2);

            //Console.WriteLine(student1);
            //Console.WriteLine(student2);

        }

        static void ReadFromJsonFile()
        {
            var student1 = Student.LoadFromFile("Peter Pan");
            var student2 = Student.LoadFromFile("Lolli Pop");
            var student3 = Student.LoadFromFile("Pussy Cat");
            Console.WriteLine(student1);
            Console.WriteLine(student2);
            Console.WriteLine(student3);
        }
    }
}
