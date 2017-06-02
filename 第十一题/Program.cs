using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第十一题
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 11.	已知一个Book类，它包含两个字段：一个是int类型的Price代表书的价格；一个是string类型的Title，代表书的标题。现在创建一个Book类型的数组，定义泛型类来实现冒泡排序。(按图书价格排序)。
            //定义Book数组类的大小
            Book[] bookArray = new Book[3];
            //创建对象，赋值
            Book book1 = new Book(60, "java");
            Book book2 = new Book(20, "C#基础");
            Book book3 = new Book(40, "mysql基础");

            //把对象的内容存储到数组中
            bookArray[0] = book1;
            bookArray[1] = book2;
            bookArray[2] = book3;

            //给冒泡排序的泛型类进实例化
            SortHelper<Book> sorterGeneric = new SortHelper<Book>();
            //调用冒泡排序的方法
            sorterGeneric.BubbleSort(bookArray);


            //遍历数组中的内容
            foreach (Book b in bookArray)
            {
                Console.WriteLine("价格:{0}", b.Price1);



            }

            Console.ReadKey();

            #endregion
        }
    }
          
 }

