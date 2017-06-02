using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第十一题
{
    class Book : IComparable
    {
        private int Price;
        private string Title;

        /// <summary>
        /// 定义一个有参数的构造方法
        /// </summary>
        /// <param name="Price">价格</param>
        /// <param name="Title">书名</param>
        public Book(int Price,string Title) {
            this.Price = Price;
            this.Title = Title;
        }

       /// <summary>
       /// 价格
       /// </summary>
        public int Price1
        {
            get
            {
                return Price;
            }

            set
            {
                Price = value;
            }
        }

        /// <summary>
        /// 书名
        /// </summary>
        public string Title1
        {
            get
            {
                return Title;
            }

            set
            {
                Title = value;
            }
        }

        public int CompareTo(object obj)
        {
            Book book = (Book)obj;
            return this.Price.CompareTo(book.Price);
        }
    }
}
