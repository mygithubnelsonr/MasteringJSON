using System;
using System.Collections.Generic;
using System.Linq;

namespace JSONParse
{
    class Program
    {

        static void Main(string[] args)
        {

            // (new Playground()).Test();

            while (true)
            {
                Console.Write("Login:\n--------------------------------------\n\t1. Instructor\n\t2. Student\n\t\t Choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("Course Name: ");
                    var strCourseName = Console.ReadLine();
                    Console.WriteLine("Enter your Name: ");
                    var strInstructorName = Console.ReadLine();

                    var course = new Course(strCourseName, strInstructorName);
                    course.SaveToFile();
                    Console.WriteLine($"{strInstructorName}, {strCourseName} has been created successfully!");
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Enter your Login Name: ");
                    var studentName = Console.ReadLine();
                    var student = Student.LoadFromFile(studentName);
                    if (student == null)
                    {
                        Console.WriteLine("Enter your Email Id: ");
                        var studentEmail = Console.ReadLine();
                        Console.WriteLine("Enter your Intrested Subjects[in a comma seperated format]: ");
                        var subjCollection = Console.ReadLine();

                        if (subjCollection != null)
                        {
                            student = new Student()
                            {
                                Name = studentName,
                                Email = studentEmail,
                                IntrestedSubjects = subjCollection.Split(',').ToList(),
                                Courses = new List<Course>()
                            };
                            student.SaveToFile();
                        }
                        else
                        {
                            return;
                        }
                    }
                    while (true)
                    {
                        Console.Write("\nOptions:\n\t1. View Profile\n\t2. View Available Courses\n\t3. View Registered Courses\n\t4. Register to a New Course\n\t5. View Intrested Subjects\n\t6. Exit\n\t\tChoice: ");
                        choice = Convert.ToInt32(Console.ReadLine());
                        if (choice == 1)
                        {
                            Console.WriteLine(student);
                        }
                        else if (choice == 2)
                        {
                            Console.WriteLine(String.Join(", \n", Utils.LoadAllCourses()));
                        }
                        else if (choice == 3)
                        {
                            Console.WriteLine(String.Join(", \n", student.Courses));
                        }
                        else if (choice == 4)
                        {
                            var availaCourses = Utils.LoadAllCourses(student.Courses);
                            int count = 0;
                            Console.WriteLine("Available Courses: \n-----------------------------");
                            foreach (Course availaCourse in availaCourses)
                            {
                                Console.WriteLine($"{++count}) {availaCourse}");
                            }
                            Console.Write("Choice: ");
                            choice = Convert.ToInt32(Console.ReadLine());
                            student.RegisterCourse(availaCourses[choice - 1]);
                            student.SaveToFile();
                            Console.WriteLine($"{availaCourses[choice - 1].CourseName} has been Registered Sucessfully!");
                        }
                        else if (choice == 5)
                        {
                            Console.WriteLine(String.Join(", ", student.IntrestedSubjects));
                        }
                        else if (choice == 6)
                        {
                            Console.WriteLine($"{student.Name}, Logout Sucessfully!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"{student.Name}, Enter a Valid Input!");
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Please Enter a Valid Input!");
                    break;
                }
            }
        }
    }
}
