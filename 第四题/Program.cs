using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第四题
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 4.	使用泛型List<int>实现第3题。


            int[] num = { 2, 7, 8, 3, 22, 9, 5, 11 };

            List<int> list = new List<int>();

            //遍历添加字符串中的奇数
            foreach (int i in num)
            {
                if (i % 2 == 1)
                {
                    list.Add(i);
                }
            }
            //遍历添加字符串中的偶数
            foreach (int j in num)
            {
                if (j % 2 == 0)
                {
                    list.Add(j);
                }
            }
            //遍历输出
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();

            #endregion

        }
    }
}
