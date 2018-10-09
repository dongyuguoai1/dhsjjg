using dhsjjg;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Code3_12_ceshi
{
    
    
    /// <summary>
    ///这是 Code3_5Test 的测试类，旨在
    ///包含所有 Code3_5Test 单元测试
    ///</summary>
    [TestClass()]
    public class Code3_5Test
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
        ///Code3_5 构造函数 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("dhsjjg.exe")]
        public void Code3_5ConstructorTest()
        {
            Code3_5_Accessor target = new Code3_5_Accessor();
            Assert.Inconclusive("TODO: 实现用来验证目标的代码");
        }

        /// <summary>
        ///GetElem 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("dhsjjg.exe")]
        public void GetElemTest()
        {
            Code3_5_Accessor.Sqlist L = null; // TODO: 初始化为适当的值
            int i = 0; // TODO: 初始化为适当的值
            int expected = 0; // TODO: 初始化为适当的值
            int actual;
            actual = Code3_5_Accessor.GetElem(L, i);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///ListDelete 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("dhsjjg.exe")]
        public void ListDeleteTest()
        {
            Code3_5_Accessor.Sqlist L = null; // TODO: 初始化为适当的值
            int i = 0; // TODO: 初始化为适当的值
            int expected = 0; // TODO: 初始化为适当的值
            int actual;
            actual = Code3_5_Accessor.ListDelete(L, i);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///ListInsert 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("dhsjjg.exe")]
        public void ListInsertTest()
        {
            Code3_5_Accessor.Sqlist L = null; // TODO: 初始化为适当的值
            int i = 0; // TODO: 初始化为适当的值
            int e = 0; // TODO: 初始化为适当的值
            int expected = 0; // TODO: 初始化为适当的值
            int actual;
            actual = Code3_5_Accessor.ListInsert(L, i, e);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }
    }
}
