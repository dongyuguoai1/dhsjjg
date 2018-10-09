using dhsjjg;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Code3_12_ceshi
{
    
    
    /// <summary>
    ///这是 Code____NodeTest 的测试类，旨在
    ///包含所有 Code____NodeTest 单元测试
    ///</summary>
    [TestClass()]
    public class Code____NodeTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///获取或设置测试上下文，上下文提供
        ///有关当前测试运行及其功能的信息。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region 附加测试特性
        // 
        //编写测试时，还可使用以下特性:
        //
        //使用 ClassInitialize 在运行类中的第一个测试前先运行代码
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //使用 ClassCleanup 在运行完类中的所有测试后再运行代码
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //使用 TestInitialize 在运行每个测试前先运行代码
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //使用 TestCleanup 在运行完每个测试后运行代码
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///Code3_6_Node`1 构造函数 的测试
        ///</summary>
        public void Code____NodeConstructorTestHelper<T>()
        {
            T val = default(T); // TODO: 初始化为适当的值
            Code3_6_Node<T> target = new Code3_6_Node<T>(val);
            Assert.Inconclusive("TODO: 实现用来验证目标的代码");
        }

        [TestMethod()]
        public void Code____NodeConstructorTest()
        {
            Code____NodeConstructorTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///Code3_6_Node`1 构造函数 的测试
        ///</summary>
        public void Code____NodeConstructorTest1Helper<T>()
        {
            Code3_6_Node<T> target = new Code3_6_Node<T>();
            Assert.Inconclusive("TODO: 实现用来验证目标的代码");
        }

        [TestMethod()]
        public void Code____NodeConstructorTest1()
        {
            Code____NodeConstructorTest1Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///Code3_6_Node`1 构造函数 的测试
        ///</summary>
        public void Code____NodeConstructorTest2Helper<T>()
        {
            T val = default(T); // TODO: 初始化为适当的值
            Code3_6_Node<T> p = null; // TODO: 初始化为适当的值
            Code3_6_Node<T> target = new Code3_6_Node<T>(val, p);
            Assert.Inconclusive("TODO: 实现用来验证目标的代码");
        }

        [TestMethod()]
        public void Code____NodeConstructorTest2()
        {
            Code____NodeConstructorTest2Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///Code3_6_Node`1 构造函数 的测试
        ///</summary>
        public void Code____NodeConstructorTest3Helper<T>()
        {
            Code3_6_Node<T> p = null; // TODO: 初始化为适当的值
            Code3_6_Node<T> target = new Code3_6_Node<T>(p);
            Assert.Inconclusive("TODO: 实现用来验证目标的代码");
        }

        [TestMethod()]
        public void Code____NodeConstructorTest3()
        {
            Code____NodeConstructorTest3Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///Data 的测试
        ///</summary>
        public void DataTestHelper<T>()
        {
            Code3_6_Node<T> target = new Code3_6_Node<T>(); // TODO: 初始化为适当的值
            T expected = default(T); // TODO: 初始化为适当的值
            T actual;
            target.Data = expected;
            actual = target.Data;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        [TestMethod()]
        public void DataTest()
        {
            DataTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///Next 的测试
        ///</summary>
        public void NextTestHelper<T>()
        {
            Code3_6_Node<T> target = new Code3_6_Node<T>(); // TODO: 初始化为适当的值
            Code3_6_Node<T> expected = null; // TODO: 初始化为适当的值
            Code3_6_Node<T> actual;
            target.Next = expected;
            actual = target.Next;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        [TestMethod()]
        public void NextTest()
        {
            NextTestHelper<GenericParameterHelper>();
        }
    }
}
