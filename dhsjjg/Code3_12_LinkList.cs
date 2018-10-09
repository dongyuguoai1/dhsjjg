using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dhsjjg
{
    class Code3_12_LinkList<T>:Code3_12_ISLL<T>
    {
        private int length;
        public int Length
        {
            get 
            {
                return length;
            }
            set
            {
                length = value;
            }
        }

        static int maxsize;
        //实际中，这个MAXSIZE设置为static比较合适，默认上限
        public static int MAXSIZE
        {
            get 
            { 
            return maxsize;
            }
            set
        {
        maxsize = value;
        }
        }

        //字段初始值无法引用非静态的字段、属性或方法，所以需要将maxsize设置为静态的
        Code3_12_Link<T>[] array;
        //前面提示字段被当做类型来使用的原因：我构造函数的名字写成了Code3_12_LinkList<T>()，实际<T>不用写。
        public Code3_12_LinkList()
    {
        array = new Code3_12_Link<T>[maxsize];
        init();
    }

        void init()
        {
                        for (int i = 0; i < maxsize-1; i++)
            {
                array[i] = new Code3_12_Link<T>();
                array[i].Cur = i + 1;
            }
            //这里的maxsize字段可以写成MAXSIZE属性，有什么不同吗？？？
            //目前静态链表为空，所以最后一个元素的cur为0
            array[maxsize - 1].Cur = 0;
        }

        //返回备用空间的第一个可用结点的下标
        int malloc()
        {
            //array[0].Cur存的就是备用空间第一个可用结点的下标
            //当链表为空的时候，array[0].Cur为1
            int i = array[0].Cur;
            //array[0].Cur在什么情况下为0？？？
            //array[0].Cur在任何情况下都不为0，且在链表满的时候，array[0].Cur指向maxsize-1
            if (i < maxsize - 1)
            {
                //更新备用空间第一个可用结点下标
                array[0].Cur = array[i].Cur;
            }
            else
            {
                System.Console.WriteLine("空间已满，无法继续分配备用空间");
                return -1;
            }
            return i;
        }

        public bool isEmpty()
        {
            return array[maxsize - 1].Cur == 0;
        }

        //在指定的位置前插入数据
        public void insert(T item, int i)
        {
            int k, j, l;
            k = maxsize - 1;
            //注意测试第length个元素，及其两边位置的元素插入情况
            if (i < 1 || i > length + 1 || isEmpty())
            {
                System.Console.WriteLine("位置错误或链表为空");
                return;
            }

            //获得空闲分量的下标
            j = malloc();
            //感觉这个判断不是很有必要
            if (j > 0)
            {
                //数据赋值给空闲分量
                array[j].Data = item;
                //找到第i个元素之前的位置，在条件中，l最多取到i-1
                //循环体中，k在迭代，k最开始是maxsize，然后取链表第一个元素，继而第二个，第三个...
                //k最多取到第i-1个元素所在的位置
                for (l = 1; l <= i - 1; l++)
                {
                    k = array[k].Cur;
                }

                //把第i-1个元素的Cur赋值给新元素的Cur
                array[j].Cur = array[k].Cur;
                //把新元素的下标值赋值给第i-1个元素的Cur
                array[i].Cur = j;
                return;
            }
        }

        //把下标为k的结点收到备用空间
        void freeLink(int k)
        {
            //先把原先第1个备用结点的下标赋值给第k个结点的Cur
            array[k].Cur = array[0].Cur;
            //然后将k作为第1个备用结点
            array[0].Cur = k;
        }

        //删除第i个结点
        //!!!这里可以在delete成功的时候，将length+1，如果能够将length单独存储起来的话
        public T delete(int i)
        {
            int j, k;
            if (i < 1 || i > length || isEmpty())
            {
                System.Console.WriteLine("删除位置错误或者链表为空");
                return default(T);
            }

            k = maxsize - 1;
            //j在条件中最多取到i-1
            //k在循环体重最多取到第i-1个结点的下标
            for (j = 1; j <= i - 1; j++)
                k = array[k].Cur;
            //j取到第i个结点的下标
            j = array[k].Cur;
            //先将第i+1个结点的下标赋值给第i-1个结点的Cur
            array[k].Cur = array[j].Cur;
            //然后将第i个结点作为备用空间的第一个可用结点
            freeLink(j);
            return array[j].Data;
        }

        public int getLength()
        {
            int j = 0;
            int i = array[maxsize - 1].Cur;
            //若为空链表，那么不进入循环体，j为0
            //若链表长度为1，那么进入循环体一次，j为1
            while (i!=0)
            {
                i = array[i].Cur;
                j++;
            }
            return j;
        }

        public void append(T item)
        {
            //此时i为第1个链表元素
            int i = array[maxsize - 1].Cur;

            if (i == 0)
            {
                //此时k为1，注意在调用malloc()函数的时候，已经更新过第一个备用元素的下标了
                int k = malloc();
                //然后初始化第一个结点元素
                array[k].Data = item;
                array[k].Cur = 0;
                array[maxsize - 1].Cur = k;
                return;
            }

            //条件中，i最多取到最后一个结点下标
            //循环体中，i最多取到最后一个结点下标
            while (array[i].Cur != 0)
            {
                i = array[i].Cur;
            }
            //取第一个备用元素的下标
            int j = malloc();
            array[j].Data = item;
            //先把最后一个结点元素的Cur赋值（即0）给新元素的Cur
            array[j].Cur = array[i].Cur;
            //把新元素的下标值赋值给原来最后一个结点元素的Cur
            array[i].Cur = j;
            return;
        }

    }
}
