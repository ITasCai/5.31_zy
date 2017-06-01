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

            list1.AddRange(list2);

            //去除元素中重复的元素
            string[] str=list1.Cast<string>().Distinct().ToArray();

            foreach (string item in str)
            {
                Console.Write(item+" ");
                        
            }

            Console.ReadKey();

            #endregion
        }
    }
}
