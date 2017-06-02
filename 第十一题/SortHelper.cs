using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第十一题
{

    /// <summary>
    /// 一个进行冒泡排序的类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class SortHelper<T> where T : IComparable
    {

        /// <summary>
        /// 对数组中的元素进行排序
        /// </summary>
        /// <param name="array">泛型数组，用于存储数据</param>
        public void BubbleSort(T[] array)
        {
        

            //循环比较多少轮
            for (int i = 0; i <array.Length - 1; i++)
            {
                //循环每轮比较多少次
                for (int j = array.Length - 1; j >= 1; j--)
                {
                    //对两个元素进行交换  
                    if (array[j].CompareTo(array[j - 1]) < 0)
                    {
                        T temp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temp;
                    }
                }
            }
        }
    }
}
