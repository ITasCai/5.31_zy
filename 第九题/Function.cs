using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace 第九题
{
    /// <summary>
    /// 电话本的功能类
    /// </summary>
    class Function
    {
        public static Dictionary<string,string> ht = new Dictionary<string,string>();

        /// <summary>
        /// 添加
        /// </summary>
        public static void Add()
        {
            Console.WriteLine("请输入您的姓名");
            string name = Console.ReadLine();
            Console.WriteLine("请输入您的电话号码");
            string phone = Console.ReadLine();
            //往集合中添加数据
            ht.Add(name, phone);
            Console.WriteLine("添加成功!");
        }

        /// <summary>
        /// 
        /// 删除
        /// </summary>
        public static void Remove()
        {
            Console.WriteLine("请输入你要删除的姓名");
            string name = Console.ReadLine();
            //判断集合中是否有指定的键       
            if (ht.ContainsKey(name))
            {
                //死循环循环提示信息
                while (true)
                {

                    Console.WriteLine("Y/y:删除    N/n:取消");
                    string xz = Console.ReadLine();
                    if ("Y".Equals(xz) || "y".Equals(xz))
                    {
                        //删除集合中的元素 
                        ht.Remove(name);
                        Console.WriteLine("删除成功！");
                        break;
                    }

                    else if ("N".Equals(xz) || "n".Equals(xz))
                    {
                        Console.WriteLine("删除失败！");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("信息输入有误");
                    }
                }
            }
            else
            {
                Console.WriteLine("没有此联系人");
            }

        }


        //查询
        public static void Query()
        {
            //遍历集合
            foreach (KeyValuePair<string, string> item in ht)
            {
                Console.WriteLine("姓名：" + item.Key+ "\t" + "电话号码：" + item.Value);
            }
        }

        //修改
        public static void Modification()
        {
            Console.WriteLine("请输入你要修改的姓名");
            string name = Console.ReadLine();
            //判断集合中是否有指定的键    
            if (ht.ContainsKey(name))
            {
                Console.WriteLine("请输入您的姓名");
                string newName = Console.ReadLine();
                Console.WriteLine("请输入您的电话号码");
                string newPhone = Console.ReadLine();
                //删除集合元素
                ht.Remove(name);
                //重新添加一个新的元素
                ht.Add(newName, newPhone);
                Console.WriteLine("修改成功!");
            }
            else
            {
                Console.WriteLine("没有此联系人");
            }
        }
    }
}
