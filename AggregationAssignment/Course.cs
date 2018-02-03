using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregationAssignment
{
    class Course
    {
        public Course()
        {
            
        }

        public Course(string title, string number, int numberOfCredits)
        {
            Title = title;
            Number = number;
            NumberOfCredits = numberOfCredits;
            Roster = new List<Student>();
            CourseInstructor = new Instructor();
        }

        [Key]
        public int CourseID { get; set; }

        public string Title { get; set; }

        public string Number { get; set; }

        public int NumberOfCredits { get; set; }

        public Instructor CourseInstructor { get; set; }

        public List<Student> Roster { get; set; }

        public override string ToString()
        {
            return Title;
        }

        public static List<Course> GetCourses()
        {
            Course course1 = new Course()
            {
                CourseID = 1,
                Number = "CPW 212",
                Title = "Advanced .NET Programming",
                NumberOfCredits = 5,
                CourseInstructor = GetInstructor("CPW 212"),
                Roster = LoadRoster("CPW 212")
            };

            Course course2 = new Course()
            {
                CourseID = 2,
                Number = "CPW 101",
                Title = "Programming Fundamentals",
                NumberOfCredits = 5,
                CourseInstructor = GetInstructor("CPW 101"),
                Roster = LoadRoster("CPW 101")
            };

            Course course3 = new Course()
            {
                CourseID = 2,
                Number = "CPW 116",
                Title = ",NET Programming",
                NumberOfCredits = 5,
                CourseInstructor = GetInstructor("CPW 116"),
                Roster = LoadRoster("CPW 116")
            };

            Course course4 = new Course()
            {
                CourseID = 2,
                Number = "CPW 118",
                Title = "C++",
                NumberOfCredits = 5,
                CourseInstructor = GetInstructor("CPW 118"),
                Roster = LoadRoster("CPW 118")
            };

            Course course5 = new Course()
            {
                CourseID = 2,
                Number = "CPW 150",
                Title = "Principles of Relational Databases",
                NumberOfCredits = 5,
                CourseInstructor = GetInstructor("CPW 150"),
                Roster = LoadRoster("CPW 150")
            };

            Course course6 = new Course()
            {
                CourseID = 2,
                Number = "CPW 213",
                Title = ".NET Web Programming",
                NumberOfCredits = 5,
                CourseInstructor = GetInstructor("CPW 213"),
                Roster = LoadRoster("CPW 213")
            };

            List<Course> courses = new List<Course>();
            courses.Add(course1);
            courses.Add(course2);
            courses.Add(course3);
            courses.Add(course4);
            courses.Add(course5);
            courses.Add(course6);

            return courses;
        }

        public static Instructor GetInstructor(string courseNumber)
        {
            if (courseNumber == "CPW 212" || courseNumber == "CPW 213" || courseNumber == "CPW 150" || courseNumber == "CPW 116")
            {
                Instructor instructor1 = new Instructor()
                {
                    Name = "Joseph Ortiz",
                    Email = "Joe@cptc.edu",
                    OfficeLocation = "B11R111W"
                };

                return instructor1;
            }
            else if (courseNumber == "CPW 101" || courseNumber == "CPW 118")
            {
                Instructor instructor2 = new Instructor()
                {
                    Name = "Ken Meerdink",
                    Email = "Ken@cptc.edu",
                    OfficeLocation = "B11R111E"
                };

                return instructor2;
            }
            else
            {
                return null;
            }
        }

        public static List<Student> LoadRoster(string courseNumber)
        {
            if (courseNumber == "CPW 213")
            {
                Student student1 = new Student()
                {
                    FirstName = "Elise",
                    LastName = "Vanderbeaken"
                };

                Student student2 = new Student()
                {
                    FirstName = "Andy",
                    LastName = "Baker"
                };

                Student student3 = new Student()
                {
                    FirstName = "Ethan",
                    LastName = "Drake"
                };

                List<Student> students = new List<Student>();
                students.Add(student1);
                students.Add(student2);
                students.Add(student3);

                return students;
            }
            else if (courseNumber == "CPW 101")
            {
                Student student1 = new Student()
                {
                    FirstName = "Aaron",
                    LastName = "Anderson"
                };

                Student student2 = new Student()
                {
                    FirstName = "Evan",
                    LastName = "Almighty"
                };

                Student student3 = new Student()
                {
                    FirstName = "Sarah",
                    LastName = "Jacobson"
                };

                List<Student> students = new List<Student>();
                students.Add(student1);
                students.Add(student2);
                students.Add(student3);

                return students;
            }
            else if (courseNumber == "CPW 212")
            {
                Student student1 = new Student()
                {
                    FirstName = "Aiden",
                    LastName = "Schaefer"
                };

                Student student2 = new Student()
                {
                    FirstName = "Eli",
                    LastName = "Artz"
                };

                Student student3 = new Student()
                {
                    FirstName = "Dorothy",
                    LastName = "Dean"
                };

                List<Student> students = new List<Student>();
                students.Add(student1);
                students.Add(student2);
                students.Add(student3);

                return students;
            }
            else if (courseNumber == "CPW 150")
            {
                Student student1 = new Student()
                {
                    FirstName = "Tony",
                    LastName = "Stark"
                };

                Student student2 = new Student()
                {
                    FirstName = "Bruce",
                    LastName = "Banner"
                };

                Student student3 = new Student()
                {
                    FirstName = "Captain",
                    LastName = "America"
                };

                List<Student> students = new List<Student>();
                students.Add(student1);
                students.Add(student2);
                students.Add(student3);

                return students;
            }
            else if (courseNumber == "CPW 116")
            {
                Student student1 = new Student()
                {
                    FirstName = "Wonder",
                    LastName = "Woman"
                };

                Student student2 = new Student()
                {
                    FirstName = "Cat",
                    LastName = "Woman"
                };

                Student student3 = new Student()
                {
                    FirstName = "Black",
                    LastName = "Widow"
                };

                List<Student> students = new List<Student>();
                students.Add(student1);
                students.Add(student2);
                students.Add(student3);

                return students;
            }
            else if (courseNumber == "CPW 118")
            {
                Student student1 = new Student()
                {
                    FirstName = "Alice",
                    LastName = "Reese"
                };

                Student student2 = new Student()
                {
                    FirstName = "Anthony",
                    LastName = "Drew"
                };

                Student student3 = new Student()
                {
                    FirstName = "Mike",
                    LastName = "Harrison"
                };

                List<Student> students = new List<Student>();
                students.Add(student1);
                students.Add(student2);
                students.Add(student3);

                return students;
            }
            else
            {
                return null;
            }
        }
    }
}
