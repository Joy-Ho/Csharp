using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test3.Extensions
{
    public static class ListExtensions
    {
        public static List<int> TakeEverySecond(this List<int> list)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < list.Count;  i++)
            {
                if(i%2 == 0)
                {
                    result.Add(list[i]);
                }
            }
            return result; 
        }

    }
}
