using System;

namespace ComparatorsExample
{
    /// <summary>
    /// Main class.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //A Student array is created
            Student[] student = new Student[]
            {
                new Student()
                {
                    Name="John",
                    Roll_No=101
                },
                new Student()
                {
                    Name="Alice",
                    Roll_No=102
                },
                new Student()
                {
                    Name="Chihiro",
                    Roll_No=103
                },
                new Student()
                {
                    Name="John",
                    Roll_No=104
                }
            };

            Console.WriteLine("Before sorting:");
            Program.PrintArray(student);

            Console.WriteLine("\nAfter sorting:");

            //For Comparer
            //StudentComparer comparer = new StudentComparer();
            //Array.Sort(student, comparer);

            //For Comparable
            Array.Sort(student);

            Program.PrintArray(student);

            //For Equatable
            var student_test = new Student()
            {
                Name = "Alice",
                Roll_No = 102
            };

            Console.WriteLine("\nFinding Student:\nName : {0}\nRoll No : {1}", student_test.Name, student_test.Roll_No);

            foreach (var s in student)
            {
                if(student_test.Equals(s))
                {
                    Console.WriteLine("Student Found!");
                }
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Used to print the array on Console
        /// </summary>
        /// <param name="student">A student array</param>
        public static void PrintArray(Student[] student)
        {
            for (int i = 0; i < student.Length; i++)
                Console.WriteLine(student[i].Name + " " + student[i].Roll_No);
        }
    }
}
