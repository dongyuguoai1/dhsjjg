using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dhsjjg
{
    /*定义一个泛型类，里面的字段或属性的类型为泛型*/
    public class Code3_6_Node<T>
    {
        /*数据域T代表什么意思（已解决）*/
        /*<T>代表的是泛型，default(T)是对泛型进行一个初始化的操作*/
        /*data的类型灵活*/
        private T data;
        /*Next结点*/
        private Code3_6_Node<T> next;

        /*构造器*/
        public Code3_6_Node(T val, Code3_6_Node<T> p)
        {
            data = val;
            next = p;
        }

        /*构造器*/
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
        //（已解决）并不是上面猜测的样子，通过翻书，发现这是一个访问器
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

        /*引用域属性，？？？这里如何优雅的初始化这样一个链表*/
        //（已解决），头插法和尾插法创建链表

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
