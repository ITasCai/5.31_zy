using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第八题
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 8.	计算字符串中每种字母出现的次数“ hello, Welcome to jining! ” 提示：判断是否为字母方法char.IsLetter()方法。使用Dictionary < char,int>。 

            string str = "hello, Welcome to jining!";
            //把字符串转换为大写
            string strUpper = str.ToUpper();
            //定义一个Dictionary集合存放数据
            Dictionary<char, int> d = new Dictionary<char, int>();
            //遍历字符串
            for (int i = 0; i < strUpper.Length; i++)
            {
                //判断字符是否为字母
                if (char.IsLetter(strUpper[i]))
                {
                    //判断集合中是否有指定的键
                    if (d.ContainsKey(strUpper[i]))
                    {
                        d[strUpper[i]]++;
                    }
                    else
                    {
                        d[strUpper[i]] = 1;
                    }
                }
            }

            foreach (KeyValuePair<char,int> item in d)
            {
                Console.WriteLine("字母{0}出现了{1}次",item.Key,item.Value);

            }

            Console.ReadKey();

            #endregion
        }
    }
}
