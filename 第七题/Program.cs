using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第七题
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 7.	把123456789转换为壹贰叁… 使用Dictionary<char,char>。数字要求从键盘输入。(提示: string str = "1壹 2贰 3参 4肆 5伍 6陆 7柒 8捌 9纠";)


            Console.WriteLine("输入一个字符串：");
            string s = Console.ReadLine();
            //把字符串转换为字符数组
            char[] ch = s.ToCharArray();
            //遍历数组中的元素
            for (int i = 0; i < s.Length; i++)
            {

               //switch语句进行判断每个数组中元素
                switch (ch[i])
                {
        
                    case '1':
                        ch[i] = '壹';
                        break;
                    case '2':
                        ch[i] = '贰';
                        break;
                    case '3':
                        ch[i] = '参';
                        break;
                    case '4':
                        ch[i] = '肆';
                        break;
                    case '5':
                        ch[i] = '伍';
                        break;
                    case '6':
                        ch[i] = '陆';
                        break;
                    case '7':
                        ch[i] = '柒';
                        break;
                    case '8':
                        ch[i] = '捌';
                        break;
                    case '9':
                        ch[i] = '玖';
                        break;
                }
                //把字符数组转换为字符串
                string str = ch[i].ToString();
                Console.Write(str);
            }

           
            Console.ReadKey();


            #endregion
        }
    }
}
