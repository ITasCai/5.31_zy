using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第二题
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 2.	随机生成10个1-100之间的数放到ArrayList中，要求这10个数不能重复，并且都是偶数(添加10次，可能循环多次)

            ArrayList list = new ArrayList();
            

            Random random = new Random();

            int index = 0;
            //集合中的元素不能超过110个
            while (list.Count < 10)
            {

                //随即生成一个1-100之间的数字
                int num = random.Next(1, 101);
                //判断随机数是偶数，并且不重复
                if (num % 2 == 0 && !list.Contains(num))
                {
                    list.Add(num);
                }
                index++;
            }

            //遍历
            foreach (int item in list)
            {
                Console.WriteLine(item);
                        
            }

            Console.ReadLine();

            #endregion
        }
    }
}
