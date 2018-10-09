using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dhsjjg
{
    //静态链表 static link list
    interface Code3_12_ISLL<T>
    {
        /*求长度*/
        int getLength();
        /*清空链表*/
        //void clear();
        /*判断链表是否为空*/
        bool isEmpty();
        /*添加操作？？？？这里的添加和后面的插入是否有画蛇添足之嫌*/
        void append(T item);
        /*插入操作*/
        void insert(T item, int i);
        /*删除操作*/
        T delete(int i);
        /*获取操作*/
        //T getItem(int i);
        /*按值查找*/
        //int locate(T value);
    }
}
