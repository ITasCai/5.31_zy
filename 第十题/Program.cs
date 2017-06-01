using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第十题
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 10.	回顾练习冒泡排序。(int类型数组)


            int[] arr = { 5, 7, 9, 15, 78, 26, 44, 16 };

            //循环多少轮
            for (int i = 0; i < arr.Length-1; i++)
            {
                //每轮循环多少次
                for (int j = 0; j < arr.Length-1-i; j++)
                {
                    //如果前面的一个数大于后面的一个数，则进行交换
                    if (arr[j]>arr[j+1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        
                    }
                }
            }
            //遍历输出
            foreach (int item in arr)
            {
                Console.Write(item+" ");
            }

            Console.ReadKey();
            #endregion
        }
    }
}
