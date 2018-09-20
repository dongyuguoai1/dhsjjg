using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace dhsjjg
{
    /*定义一个泛型*/
    public class Code3_6_Node<T>
    {
        /*数据域？？？？T代表什么意思*/
        /*--------------><T>代表的是泛型，default(T)是对泛型进行一个初始化的操作*/
        /*data的类型灵活*/
        private T data;
        /*引用域，为泛型实例*/
        private Code3_6_Node<T> next;

        /*构造器*/
        public Code3_6_Node(T val, Code3_6_Node<T> p)
        {
            data = val;
            next = p;
        }

        /*构造器__感觉是一个头指针*/
        public Code3_6_Node(Code3_6_Node<T> p)
        {
            next = p;
        }

        /*构造器*/
        public Code3_6_Node(T val)
        {
            data = val;
        }

        public Code3_6_Node()
        {
            data = default(T);
            next = null;

        }

        /*应该是对泛型的一个定义，自定义一个泛型，好像是类的样子，注意语法，以及补课泛型的学习*/
        public T Data 
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }

        }

        /*引用域属性，这里？？？？？？？如何优雅的初始化这样一个链表*/

        public Code3_6_Node<T> Next
        {
            get
            {
                return next;
            }
            set
            {
                next = value;
            }

        }

    }
}
