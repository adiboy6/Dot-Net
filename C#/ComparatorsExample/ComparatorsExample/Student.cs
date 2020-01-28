using System;

namespace ComparatorsExample
{
    public class Student : IComparable , IEquatable<Student>
    {
        private int _roll_no;
        private string _name;
        
        public int Roll_No
        {
            get => _roll_no;
            set => _roll_no = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Student))
            {
                throw new ArgumentException("Invalid Object. It should be Student.");
            }

            Student student = (Student)obj;

            if (Name == student.Name)
                return Roll_No.CompareTo(student.Roll_No);
            return Name.CompareTo(student.Name);
        }

        public bool Equals(Student other)
        {
            return (Name == other.Name) && (Roll_No == other.Roll_No);
        }
    }
}
