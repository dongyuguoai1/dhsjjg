using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace dhsjjg
{
    class Code3_6_LL<T> : Code3_6_ISLL<T>
    {
        /*单链表的第一个结点*/
        //！！！后续可以设计一个具有头结点的单链表
        private Code3_6_Node<T> head;
        /*第一个结点属性*/
        public Code3_6_Node<T> Head
        {
            get
            {
                return head;
            }
            set
            {
                head = value;
            }
        }

        /*构造器*/
        public Code3_6_LL()
        {
            head = null;
        }

        /*获取单链表长度*/
        public int getLength()
        {
            Code3_6_Node<T> p = head;
            int len = 0;
            while (p != null)
            {
                p = p.Next;
                len++;
            }
            return len;
        }

        /*清空单链表*/
        //在清空表的时候，dhsjjg中循环遍历节点并将其释放掉
        //！！！后续通过循环遍历手动释放结点
        public void clear()
        {
            head = null;
        }

        /*判断是否为空*/

        public bool isEmpty()
        {
            return head == null;
        }

        /*在单链表的末尾添加新的元素*/
        /*思路是从头遍历到尾，然后将元素添到最后*/
        public void append(T item)
        {
            Code3_6_Node<T> q = new Code3_6_Node<T>(item);
            Code3_6_Node<T> p = new Code3_6_Node<T>();
            if (head == null)
            {
                head = q;
                return;
            }
            p = head;
            while (p.Next != null)
            {
                p = p.Next;
            }
            p.Next = q;
        }

        /*在第i个位置前面插入一个元素节点，即数据域为item的节点*/
        public void insert(T item, int i)
        {
            if (isEmpty() || i < 1)
            {
                Console.WriteLine("链表为空或者位置错误");
                return;
            }
            Code3_6_Node<T> q = new Code3_6_Node<T>(item);
            if (i == 1)
            {
                q.Next = head;
                head = q;
                return;
            }
            int j = 1;
            Code3_6_Node<T> p = head;
            //遍历寻找第i-1个节点，判断条件中，最后一次判断条件成立时，p.Next最多是第i-2个节点。循环体重，最后一次判断条件成立时，p最多是
            //第i-1个节点
            while (p.Next != null && j < i - 1)
            {
                p = p.Next;
                ++j;
            }
            //？？？这个j>=i的判断有没有意义
            //判断条件中，p.Next最多是第i个节点
            if (p.Next == null || j > i)
            {
                System.Console.WriteLine("第{0}个节点不存在", i);
                return;
            }
            q.Next = p.Next;
            p.Next = q;
            return;
        }

        /*在单链表的第i个位置的后面插入一个元素*/
        public void insertPost(T item, int i)
        {
            if (isEmpty() || i < 1)
            {
                Console.WriteLine("链表为空或者位置错误");
                return;
            }
            int j = 1;
            Code3_6_Node<T> p = head;
            //遍历寻找第i个节点，判断条件中，p最多是第i-1个节点。循环体中，p最多是第i个节点
            while (p != null && j < i)
            {
                p = p.Next;
                ++j;
            }
            //？？？这里的j>i判断有没有意义
            //判断条件中，p最多是第i个节点
            if (p == null || j > i)
            {
                System.Console.WriteLine("第{0}个节点不存在", i);
                return;
            }
            Code3_6_Node<T> q = new Code3_6_Node<T>(item);
            q.Next = p.Next;
            p.Next = q;
            return;
        }

        public T delete(int i)
        {
            if (isEmpty() || i < 1)
            {
                Console.WriteLine("链表为空，或者位置错误");
                return default(T);
            }
            int j = 1;
            Code3_6_Node<T> p = head;
            //遍历寻找第i-1个节点，判断条件中，最后一次判断条件成立时，p.Next最多是第i-2个节点。循环体，最后一次判断条件成立时，p最多是
            //第i-1个节点
            while (p.Next != null && j < i - 1)
            {
                p = p.Next;
                ++j;
            }
            //？？？这个j>=i的判断有没有意义
            //判断条件中，p.Next最多是第i个节点
            if (p.Next == null || j > i)
            {
                System.Console.WriteLine("第{0}个节点不存在", i);
                return default(T);
            }
            Code3_6_Node<T> q = new Code3_6_Node<T>();
            //？？？这里本应该释放掉q（第i个结点）的，但现在没有释放，现在第i+1个结点有两个结点指向它，一个是原来的第i-1个节点，一个是要被删掉的第i个节点
            //第i个结点没有人指向它了。不知道系统会不会回收原来的第i个结点
            q = p.Next;
            p.Next = q.Next;
            return q.Data;
        }

        /*获取单链表的第i个元素*/
        public T getItem(int i)
        {
            if (isEmpty() || i < 1)
            {
                Console.WriteLine("链表为空或者位置错误");
                return default(T);
            }
            Code3_6_Node<T> p = new Code3_6_Node<T>();
            p = head;
            int j = 1;
            while (p != null && j < i)
            {
                p = p.Next;
                ++j;
            }
            if (p == null || j > i)
            {
                System.Console.WriteLine("第{0}个节点不存在", i);
                return default(T);
            }
            return p.Data;
        }

        /*在单链表中查找值为value的元素的节点（的位置）*/
        public int locate(T value)
        {
            if (isEmpty())
            {
                Console.WriteLine("链表为空或者位置错误");
                return -1;
            }
            Code3_6_Node<T> p = new Code3_6_Node<T>();
            p = head;
            int i = 1;
            //这里发现问题，原代码条件中是p.Next!=null,出现的问题是，认为不存在的结点位于最后一个位置（逻辑错误）
            //(解决方案)，条件中应为p!=null
            while (p != null && !p.Data.Equals(value))
            {
                p = p.Next;
                i++;
            }
            if (p == null)
            {
                Console.WriteLine("不存在这样的节点");
                return -1;
            }
            else
            {
                return i;
            }
        }
    }
}
