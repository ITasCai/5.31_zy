using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第五题
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 5.	将int数组中的奇数放到一个新的int数组中。

            Console.WriteLine("请输入数组的长度：");
            int length = Convert.ToInt32(Console.ReadLine());

            int[] arr1 = new int[length];

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine("请输入第" + (i + 1) + "个数：");
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }


            List<int> list = new List<int>();

            //遍历数组中的元素
            for (int i = 0; i < arr1.Length; i++)
            {
                //如果元素为奇数添加到集合中
                if (arr1[i] % 2 != 0)
                {
                    list.Add(arr1[i]);
                }
            }
              //将元素的内容复制到新数组中
                int[] num = list.ToArray(); 
            

                //遍历输出数组中的内容
                for (int i = 0; i < num.Length; i++)
                {
                    Console.Write(num[i] + " ");
                }
                Console.ReadKey();

                #endregion
            }
        }
    }

