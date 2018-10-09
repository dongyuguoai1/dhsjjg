using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace dhsjjg
{
    class ProgramCode3_6
    {
        /// <summary>
        /// ……这里解决了一个问题，未能找到类型或命名空间T，是否缺少using指令或程序集引用……在定义的方法名cLH后面也加上<T>即可
        /// 因为最开始没有加所以报错cLH(Code3_6_LL<T> ll, int n)是不对的，应该为cLH><T>(Code3_6_LL<T> ll, int n)
        /// create list by head 头插法创建一个链表
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ll"></param>
        /// <param name="n"></param>
        void cLH(Code3_6_LL<int> ll, int n)
        { 
            Random rd = new Random();
            ll.Head=new Code3_6_Node<int>( rd.Next(0,100));
            int i;
            for (i = 0; i < n-1; i++)
            { 
            //Code3_6_Node<int> p = new Code3_6_Node<int>(rd.Next(0,100));
            //p.Next = ll.Head.Next;
            //ll.Head.Next = p;
            ll.insert(rd.Next(0, 100), 1);
            }
        }

        /// <summary>
        /// create List by Tail，尾插法创建一个链表
        /// </summary>
        /// <param name="ll"></param>
        /// <param name="n"></param>
        void cLT(Code3_6_LL<int> ll, int n)
        {
            Random rd = new Random();
            ll.Head = new Code3_6_Node<int>(rd.Next(0, 100));
            Code3_6_Node<int> p = ll.Head;

            int i;
            for (i = 0; i < n-1; i++)
            {
                Code3_6_Node<int> q = new Code3_6_Node<int>(rd.Next(0, 100));
                q.Next = p.Next;
                p.Next = q;
                p = q;
            }

        }

        void bll(Code3_6_LL<int> ll)
        {
            //遍历链表
            Code3_6_Node<int> p = ll.Head;
            int i = 1;
            while (p != null)
            {
                System.Console.WriteLine("链表第{0}个结点为：{1}", i, p.Data);
                p = p.Next;
                i++;
            }
        }

        //public static void Main(string[] args)
        //{
        //    Code3_6_LL<int> myll = new Code3_6_LL<int>();

        //    //这里发现一个问题，myll的Head为null，此时为了初始化Head，我采用myll.Head.Data = 1语句，该语句相当于null.Data = 1；自然
        //    //报错：System.NullReferenceException:未将对象引用设置到对象的实例
        //    //（解决方案）定义一个Node结点，将结点赋值给myll.Head

        //    //……解决问题：非静态的字段、方法或属性要求对象引用……，假如下面的语句不构造PC类的实例，而直接调用cLH方法，就会出现
        //    //上述问题。解决方法如下所示，通过构造实例，再调用即可
        //    ProgramCode3_6 myPc = new ProgramCode3_6();
        //    myPc.cLH(myll,10);
        //    myPc.bll(myll);

        //    //要测试前插、后插、定位、删除、获取、append、获取长度这些方法
        //    System.Console.WriteLine("此时10个结点，在第6个结点前面插入56");
        //    myll.insert(56, 6);
        //    myPc.bll(myll);
        //    System.Console.WriteLine("此时11个结点，在第13个结点前插入57");
        //    myll.insert(57, 13);
        //    myPc.bll(myll);
        //    System.Console.WriteLine("此时11个结点，在第11个结点前插入57");
        //    myll.insert(57, 11);
        //    myPc.bll(myll);
            
        //    System.Console.WriteLine("此时12个结点，在第13个结点前插入58");
        //    myll.insert(58, 13);
        //    myPc.bll(myll);
            
        //    System.Console.WriteLine("此时12个结点，在第12个结点后插入58");
        //    myll.InsertPost(58, 12);
        //    myPc.bll(myll);
            
        //    System.Console.WriteLine("此时13个结点，在第14个结点后插入58");
        //    myll.InsertPost(59, 14);
        //    myPc.bll(myll);
            
        //    System.Console.WriteLine("此时13个结点,在第1个结点后插入60");
        //    myll.InsertPost(60, 1);
        //    myPc.bll(myll);
            
        //    System.Console.WriteLine("此时14个结点");

        //    System.Console.WriteLine("判断是否存在值为56的结点");
        //    int pos = myll.Locate(56);
        //    System.Console.WriteLine("值为56的结点位置为{0}，-1表示不存在", pos);

        //    System.Console.WriteLine("判断是否存在值为101的结点");
        //    pos = myll.Locate(101);
        //    System.Console.WriteLine("值为101的结点位置为{0}，-1表示不存在", pos);

        //    System.Console.WriteLine("删掉第14个结点");
        //    int d14 = myll.delete(14);
        //    System.Console.WriteLine("此时13个结点，删掉的结点为{0}", d14);
        //    myPc.bll(myll);

        //    System.Console.WriteLine("删掉第10个结点");
        //    int d10 = myll.delete(10);
        //    System.Console.WriteLine("此时12个结点，删掉的结点为{0}", d10);
        //    myPc.bll(myll);

        //    System.Console.WriteLine("删掉第100个结点");
        //    int d100 = myll.delete(100);
        //    System.Console.WriteLine("此时12个结点，删掉的结点为{0},0可能是删掉的结点，也可能是不存在要删掉的结点，具体看提示", d100);
        //    myPc.bll(myll);

        //    System.Console.WriteLine("此时12个结点，获取第10个结点");
        //    int jd10 = myll.getItem(10);
        //    System.Console.WriteLine("第10个结点为：{0}", jd10);

        //    System.Console.WriteLine("在末尾添加一个结点，值为100");
        //    myll.append(100);
        //    System.Console.WriteLine("此时13个结点");
        //    myPc.bll(myll);

        //    System.Console.WriteLine("此时共有{0}个结点", myll.GetLength());

        //}

    }
}
