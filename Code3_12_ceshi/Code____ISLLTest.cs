using dhsjjg;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Code3_12_ceshi
{
    
    
    /// <summary>
    ///这是 Code____ISLLTest 的测试类，旨在
    ///包含所有 Code____ISLLTest 单元测试
    ///</summary>
    [TestClass()]
    public class Code____ISLLTest
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
        ///GetLength 的测试
        ///</summary>
        public void GetLengthTestHelper<T>()
        {
            Code3_6_ISLL<T> target = CreateCode____ISLL<T>(); // TODO: 初始化为适当的值
            int expected = 0; // TODO: 初始化为适当的值
            int actual;
            actual = target.GetLength();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        internal virtual Code3_6_ISLL<T> CreateCode____ISLL<T>()
        {
            // TODO: 实例化相应的具体类。
            Code3_6_ISLL<T> target = null;
            return target;
        }

        [TestMethod()]
        public void GetLengthTest()
        {
            GetLengthTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///Locate 的测试
        ///</summary>
        public void LocateTestHelper<T>()
        {
            Code3_6_ISLL<T> target = CreateCode____ISLL<T>(); // TODO: 初始化为适当的值
            T value = default(T); // TODO: 初始化为适当的值
            int expected = 0; // TODO: 初始化为适当的值
            int actual;
            actual = target.Locate(value);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        [TestMethod()]
        public void LocateTest()
        {
            LocateTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///append 的测试
        ///</summary>
        public void appendTestHelper<T>()
        {
            Code3_6_ISLL<T> target = CreateCode____ISLL<T>(); // TODO: 初始化为适当的值
            T item = default(T); // TODO: 初始化为适当的值
            target.append(item);
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        [TestMethod()]
        public void appendTest()
        {
            appendTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///clear 的测试
        ///</summary>
        public void clearTestHelper<T>()
        {
            Code3_6_ISLL<T> target = CreateCode____ISLL<T>(); // TODO: 初始化为适当的值
            target.clear();
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        [TestMethod()]
        public void clearTest()
        {
            clearTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///delete 的测试
        ///</summary>
        public void deleteTestHelper<T>()
        {
            Code3_6_ISLL<T> target = CreateCode____ISLL<T>(); // TODO: 初始化为适当的值
            int i = 0; // TODO: 初始化为适当的值
            T expected = default(T); // TODO: 初始化为适当的值
            T actual;
            actual = target.delete(i);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        [TestMethod()]
        public void deleteTest()
        {
            deleteTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///getItem 的测试
        ///</summary>
        public void getItemTestHelper<T>()
        {
            Code3_6_ISLL<T> target = CreateCode____ISLL<T>(); // TODO: 初始化为适当的值
            int i = 0; // TODO: 初始化为适当的值
            T expected = default(T); // TODO: 初始化为适当的值
            T actual;
            actual = target.getItem(i);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        [TestMethod()]
        public void getItemTest()
        {
            getItemTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///insert 的测试
        ///</summary>
        public void insertTestHelper<T>()
        {
            Code3_6_ISLL<T> target = CreateCode____ISLL<T>(); // TODO: 初始化为适当的值
            T item = default(T); // TODO: 初始化为适当的值
            int i = 0; // TODO: 初始化为适当的值
            target.insert(item, i);
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        [TestMethod()]
        public void insertTest()
        {
            insertTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///isEmpty 的测试
        ///</summary>
        public void isEmptyTestHelper<T>()
        {
            Code3_6_ISLL<T> target = CreateCode____ISLL<T>(); // TODO: 初始化为适当的值
            bool expected = false; // TODO: 初始化为适当的值
            bool actual;
            actual = target.isEmpty();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        [TestMethod()]
        public void isEmptyTest()
        {
            isEmptyTestHelper<GenericParameterHelper>();
        }
    }
}
