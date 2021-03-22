using System;
using System.Collections.Generic;
using System.Text;

namespace Jewels_Columns_Student
{
    interface IComparable<T>
    {
        public int CompareTo(T other);
    }
}
