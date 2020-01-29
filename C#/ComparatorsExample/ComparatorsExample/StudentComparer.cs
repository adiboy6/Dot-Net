using System;
using System.Collections.Generic;
using System.Collections;

namespace ComparatorsExample
{
    /// <summary>
    /// <para></para>A <c>StudentComparer</c> class which implements <c>IComparer</c> interface</para>
    /// <para>Mainly used for sorting purpose</para>
    /// </summary>
    /// <remarks>
    /// This class implements IComparer which is used for sorting.
    /// </remarks>
    public class StudentComparer : IComparer<Student>
    {   
        /// <summary>
        /// <para>Here, the soring is first done based on Name and if Name is same, then it's done based on Roll No</para>
        /// </summary>
        /// <param name="x">A Student object</param>
        /// <param name="y">A Student object</param>
        /// <returns>The difference between Name or Roll No.</returns>
        public int Compare(Student x, Student y)
        {
            //Check first if both the Names are equal or not
            if (x.Name == y.Name)
                return x.Roll_No.CompareTo(y.Roll_No);
            //If Names are different, then send the difference
            return x.Name.CompareTo(y.Name);
        }
    }
}
