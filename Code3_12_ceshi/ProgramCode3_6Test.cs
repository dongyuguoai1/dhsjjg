using dhsjjg;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Code3_12_ceshi
{
    
    
    /// <summary>
    ///这是 ProgramCode3_6Test 的测试类，旨在
    ///包含所有 ProgramCode3_6Test 单元测试
    ///</summary>
    [TestClass()]
    public class ProgramCode3_6Test
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
        ///ProgramCode3_6 构造函数 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("dhsjjg.exe")]
        public void ProgramCode3_6ConstructorTest()
        {
            ProgramCode3_6_Accessor target = new ProgramCode3_6_Accessor();
            Assert.Inconclusive("TODO: 实现用来验证目标的代码");
        }

        /// <summary>
        ///Main 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("dhsjjg.exe")]
        public void MainTest()
        {
            string[] args = null; // TODO: 初始化为适当的值
            ProgramCode3_6_Accessor.Main(args);
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///bll 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("dhsjjg.exe")]
        public void bllTest()
        {
            ProgramCode3_6_Accessor target = new ProgramCode3_6_Accessor(); // TODO: 初始化为适当的值
            Code3_6_LL_Accessor<int> ll = null; // TODO: 初始化为适当的值
            target.bll(ll);
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///cLH 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("dhsjjg.exe")]
        public void cLHTest()
        {
            ProgramCode3_6_Accessor target = new ProgramCode3_6_Accessor(); // TODO: 初始化为适当的值
            Code3_6_LL_Accessor<int> ll = null; // TODO: 初始化为适当的值
            int n = 0; // TODO: 初始化为适当的值
            target.cLH(ll, n);
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///cLT 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("dhsjjg.exe")]
        public void cLTTest()
        {
            ProgramCode3_6_Accessor target = new ProgramCode3_6_Accessor(); // TODO: 初始化为适当的值
            Code3_6_LL_Accessor<int> ll = null; // TODO: 初始化为适当的值
            int n = 0; // TODO: 初始化为适当的值
            target.cLT(ll, n);
            Assert.Inconclusive("无法验证不返回值的方法。");
        }
    }
}
