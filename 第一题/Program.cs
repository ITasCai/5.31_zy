using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第一题
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1.	两个ArrayList集合{“a”,“b”,“c”,“d”,“e”}和{“d”,“e”,“f”,“g”，“h”}，把这两个集合去除重复项合并一个。

            ArrayList list1 = new ArrayList(new string[] {"a","b","c","d","e" });
            ArrayList list2 = new ArrayList(new string[] { "d", "e", "f", "g", "h" });
            ArrayList list3 = new ArrayList();
            if (!list1.Contains(list2))
            {
                list3.AddRange(list1);
                list3.AddRange(list2);
            }

            foreach (string  item in list3)
            {
                Console.Write(item+" ");
            }

            Console.ReadKey();

            #endregion
        }
    }
}
