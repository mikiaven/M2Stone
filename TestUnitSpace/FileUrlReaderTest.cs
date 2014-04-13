using spaceNegocio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestUnitSpace
{
    
    
    /// <summary>
    ///This is a test class for FileUrlReaderTest and is intended
    ///to contain all FileUrlReaderTest Unit Tests
    ///</summary>
    [TestClass()]
    public class FileUrlReaderTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
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

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for ReadUrlFile
        ///</summary>
        [TestMethod()]
        public void ReadUrlFileTest()
        {
            FileUrlReader target = new FileUrlReader(); // TODO: Initialize to an appropriate value
            target.ReadUrlFile();
            //Assert.Inconclusive("A method that does not return a value cannot be verified.");
            Assert.AreEqual(null, target);
        }
    }
}
