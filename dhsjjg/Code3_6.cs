using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dhsjjg
{
    class Code3_6
    {
        /*轻量级的类可以用struct*/
        public struct Node
        {
            int data=0;

            /*注意struct的初始化方法*/
            Node next = new Node();

        }

    }
}
