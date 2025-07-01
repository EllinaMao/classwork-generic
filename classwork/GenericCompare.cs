using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork
{
    /*https://learn.microsoft.com/ru-ru/dotnet/api/system.icomparable-1?view=net-9.0*/
    internal static class GenericCompare
    {
        public static T Max<T>(T a, T b, T c) where T : IComparable<T>
        {
            if (a.CompareTo(b) > 0 && a.CompareTo(c) > 0)
            {
                return a;
            }
            else if (b.CompareTo(a) > 0 && b.CompareTo(c) > 0)
            {
                return b;
            }
            else
            {
                return c;
            }
        }
    }
}
