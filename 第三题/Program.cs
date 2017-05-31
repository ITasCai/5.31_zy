using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第三题
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 3.	有一个字符串是用空格分隔的一系列整数，写一个程序将其中的整数做如下重新排列打印出来，奇数显示在左侧，偶数显示在右侧，比如“2 7 8 3 22 9 5 11”显示成“7 5 3 9 11 2 8 22”

            int[] num = { 2, 7, 8, 3, 22, 9, 5, 11 };

            ArrayList list= new ArrayList(); 

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
