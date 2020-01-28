using System;
using System.Collections.Generic;
using System.Collections;

namespace ComparatorsExample
{
    public class StudentComparer : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            if (x.Name == y.Name)
                return x.Roll_No.CompareTo(y.Roll_No);
            return x.Name.CompareTo(y.Name);
        }
    }
}
