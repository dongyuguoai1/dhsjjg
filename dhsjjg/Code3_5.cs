
/*??#define OK 1;*/

using System;
/*??*/
using System.Collections.Generic;
/*??*/
using System.Linq;
/*??*/
using System.Text;




namespace dhsjjg
{
    class Code3_5
    {
        public const int ERROR = 65535;
        public const int TRUE = 1;
        public const int FALSE = 1;
        public const int MAXSIZE = 20;

        /*定义顺序表，这里曾尝试使用struct Sqlist，但是struct里面如何初始化data*/
        public class Sqlist
        {
            /*构造函数中初始化类属性成员*/
            public Sqlist()
            {
                int i;
                for (i = 0; i < MAXSIZE; i++)
                {
                    data[i] = 0;
                }
            }
            public int[] data = new int[MAXSIZE];


            public int length;
        }
        /*i从1开始*/
        public static int GetElem(Sqlist L, int i)
        {

            if (L.length == 0 || i < 1 || i > L.length)
                return ERROR;
            int e = L.data[i - 1];
            return e;
        }
        public static int ListInsert(Sqlist L, int i, int e)
        {
            int k;
            /*线性表已满*/
            if (L.length == MAXSIZE)
                return ERROR;
            /*i不在范围内*/
            if (i < 1 || i > L.length + 1)
                return ERROR;
            /*如果插入数据位置不在表尾*/
            if (i <= L.length)
            {
                /*将要出入位置后数据元素向后移动一位*/
                for (k = L.length - 1; k >= i - 1; k--)
                    L.data[k + 1] = L.data[k];
            }
            /*将新元素插入*/
            L.data[i - 1] = e;
            L.length++;
            return e;
        }

        public static int ListDelete(Sqlist L, int i)
        {
            int k;
            /*线性表为空,个人认为这里应该抛出一个自定义异常，而非int类型的ERROR，因为返回删掉的值会更加合理*/
            if (L.length == 0)
                return ERROR;
            /*删除位置不正确*/
            if (i < 1 || i > L.length)
                return ERROR;
            int e = L.data[i - 1];
            /*如果删除的不是最后位置*/
            if (i < L.length)
            {
                /*将删除位置后继元素前移*/
                for (k = i; k < L.length; k++)
                {
                    L.data[k - 1] = L.data[k];
                }
            }
            L.length--;
            return e;
        }


        static void Main(string[] args)
        {
            /*新建一个顺序表*/
            var sq = new Sqlist();
            /*设置顺序表的长度*/
            sq.length = 10;
            /*sq.data = {1,2};*/
            /*对顺序表进行赋值操作*/
            int i;
            for (i = 0; i < sq.length; i++)
            {
                sq.data[i] = i;
                System.Console.WriteLine("顺序表的第{0}个数据是{1}。", i + 1, sq.data[i]);
            }
            ListInsert(sq, 4, 100);

            for (i = 0; i < sq.length; i++)
            {
                System.Console.WriteLine("在第4个位置插入100后，顺序表的第{0}个数据是{1}，顺序表长度为{2}。", i + 1, sq.data[i], sq.length);
            }

            int deletedV = 0;

            deletedV = ListDelete(sq, 8);

            for (i = 0; i < sq.length; i++)
            {
                System.Console.WriteLine("在第8个位置删除元素后，顺序表的第{0}个数据是{1}，顺序表长度为{2}，删掉的元素为{3}。", i + 1, sq.data[i], sq.length, deletedV);
            }

            int getItem = 0;
            getItem = GetElem(sq, 9);
            System.Console.WriteLine("查询得到第9个元素为{0}", getItem);
        }
    }
}

