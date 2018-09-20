using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace dhsjjg
{
    class Code3_6_LL<T> : Code3_6_ISLL<T>
    {
        /*单链表的头指针（头引用）*/
        private Code3_6_Node<T> head;
        /*头引用的属性*/

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

            if (i == 1)
            {
                Code3_6_Node<T> q = new Code3_6_Node<T>(item);
                q.Next = head;
                head = q;
                return;
            }

            Code3_6_Node<T> p = head;
            Code3_6_Node<T> r = new Code3_6_Node<T>();
            int j = 1;
            while (p.Next != null && j < i)
            {
                r = p;
                p = p.Next;
                j++;
            }

            if (j == i)
            {
                Code3_6_Node<T> q = new Code3_6_Node<T>(item);
                Code3_6_Node<T> m = r.Next;
                r.Next = q;
                q.Next = m;

            }
        }

            /*在单链表的第i个位置的后面插入一个元素*/

            public void InsertPost(T item, int i)
            {
            if (isEmpty() || i<1)
            {
            Console.WriteLine("链表为空或者位置错误");
                return;

            }

                if (i == 1)
                {
                Code3_6_Node<T> q = new Code3_6_Node<T>(item);
                    q.Next = head.Next;
                    head.Next = q;
                return;
                }

                Code3_6_Node<T> p = head;
                Code3_6_Node<T> r = new Code3_6_Node<T>();
                int j = 1;
                while (p.Next != null && j<=i)
                {
                r = p;
                    p = p.Next;
                    j++;
                }

                if (j == i+1)
                {
                Code3_6_Node<T> q  = new Code3_6_Node<T>(item);
                    Code3_6_Node<T> m = r.Next;
                    r.Next = q;
                    q.Next = m;
                }

                else
                {
                Console.WriteLine("插入位置过大，error");

                }
            }


        public T delete(int i)
        {
        if (isEmpty() || i<1)

        {
            Console.WriteLine("链表为空，或者位置错误");
            return default(T);

        }

           Code3_6_Node<T> q = new Code3_6_Node<T>();
            if (i == 1)
            {
            q = head;
                head = head.Next;
                return q.Data;

            }

            Code3_6_Node<T> p = head;
            int j = 1;
            while( p.Next != null && j<i)
            {
            q = p;
                 p = p.Next;
                j++;
            }

            if (j == i)
            {
            q.Next = p.Next;
                return p.Data;
            }

            else
            {
                Console.WriteLine("位置不正确");
                return default(T);
            
            }
        }

        /*获取单链表的第i个元素*/
        public T getItem(int i )
        {
        if (isEmpty() || i<1)
        {
        Console.WriteLine("链表为空或者位置错误");
            return default(T);
        }
        

            Code3_6_Node<T> p = new Code3_6_Node<T>();
            p = head;
            int j = 1;
            while(p.Next!=null && j<i)
            {
            p = p.Next;
                j++;
            }
        

            if (j == i)
            {
            return p.Data;
            }
            else
            {
            Console.WriteLine("位置不正确");
            }

            return default(T);
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
            while(p.Next !=null && !p.Data.Equals(value))
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
