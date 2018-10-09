using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dhsjjg
{
    class Code3_12_Link<T>
    {
        private T data;
        private int cur;

        //提示不包含没有参数的构造函数，言外之意是，要想只有一个参数的构造器，要有不含参数的构造器
        //这样它才能知道，另外的参数应该怎样初始化吧。
        public Code3_12_Link(T val)
        {
            data = val;
        }

        public Code3_12_Link()
        {
            data = default(T);
            cur = 0;
        }

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

        public int Cur
        {
            get
            {
                return cur;
            }
            set
            {
                cur = value;
            }
        }
    }
}
