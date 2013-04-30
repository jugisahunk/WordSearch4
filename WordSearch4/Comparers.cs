using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSearch4
{
    public class DescendingComparer : IComparer<string>
    {
        public int Compare(string a, string b)
        {
            return -string.Compare(a, b);
        }
    }
}