using System;

namespace ComparatorsExample
{
    /// <summary>
    /// Details of Student Class:
    /// <list type="bullet">
    /// <item>
    /// <term>Student Members</term>
    /// <description>A private integer <c>_roll_no</c></description>
    /// <description> A private string <c>_name</c></description>
    /// </item>
    /// <item>
    /// <term>IComparable</term>
    /// <description><c>CompareTo</c> method is implemented</description>
    /// </item>
    /// <item>IEquatable</item>
    /// <description><c>Equals</c> method is implemented</description>
    /// </list>
    /// </summary>
    /// <remarks>A class which has member variable and implements Icomparable and IEquatable.</remarks>
    public class Student : IComparable , IEquatable<Student>
    {
        public int Roll_No { get; set; }

        public string Name { get; set; }

        /// <summary>
        /// <c>CompareTo</c> method is used to compare the object in argument with the called object(Student).
        /// </summary>
        /// <param name="obj">An object varaiable.</param>
        /// <returns>The difference of Name or Roll No.</returns>
        public int CompareTo(object obj)
        {
            //Check if obj is of Student type or not
            if (!(obj is Student))
            {
                throw new ArgumentException("Invalid Object. It should be Student.");
            }

            //Type Conversion of obj to Student
            Student student = (Student)obj;

            if (Name == student.Name)
                return Roll_No.CompareTo(student.Roll_No);
            return Name.CompareTo(student.Name);
        }

        /// <summary>
        /// <c>Equals</c> method overrides the defualt method.
        /// </summary>
        /// <param name="other">A Student object</param>
        /// <returns>Returns whether the values are all equal or not.</returns>
        public bool Equals(Student other)
        {
            return (Name == other.Name) && (Roll_No == other.Roll_No);
        }
    }
}
