using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第六题
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 6.	从一个整数的List<int>中取出最大数（最大值），不能使用max方法。

            Console.WriteLine("请输入数字的个数：");
            int length = Convert.ToInt32(Console.ReadLine());

            //定义数组存放数据
            int[] arr1 = new int[length];

            //循环遍历你要输入的数据
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine("请输入第" + (i + 1) + "个数：");
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            //定义及集合存放数组中的数据
            List<int> list = new List<int>(arr1);

            //存放最大值
            int max = 0;

            //循环遍历进行判断
            for (int i = 0; i < list.Count; i++)
            {
                if (max<list[i])
                {
                    max = list[i];
                }
            }

            Console.WriteLine("最大值为："+max);

            Console.ReadKey();

            #endregion
        }
    }
}
