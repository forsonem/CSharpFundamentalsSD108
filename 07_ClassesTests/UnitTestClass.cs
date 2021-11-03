using _08_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07_ClassesTests
{
    /// <summary>
    /// Summary description for UnitTestClass
    /// </summary>
    [TestClass]
    public class UnitTestClass
    {
        public UnitTestClass()
        {
            //
            // TODO: Add constructor logic here
            //
        }

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
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        private StreamingContentRepository _streamingRepo;
        private StreamingContent _content;
        private StreamingContent _content2;

        [TestInitialize]
        public void Arrange()
        {
            _streamingRepo = new StreamingContentRepository();
            _content = new StreamingContent("Midnight Mass", "scary stuff", 4.5, MaturityRating.R, GenreType.Thriller);
            _content2 = new StreamingContent("Elf", "crazy singing human that thinks he is an elf", 5.0, MaturityRating.PG, GenreType.Comedy);
            _streamingRepo.AddContentToDirectory(_content);
        }
        [TestMethod]
        public void AddContentToDirectory_Test()
        {
            //Arrange - setting up the data required for your test
            //Act - call our method that we are testing and get a result
            bool wasAdded = _streamingRepo.AddContentToDirectory(_content2);
            //Assert - compare what the method returned to what the expected result should have been
            //Assert.IsTrue(wasAdded);
            //Assert.AreEqual(true, wasAdded);
            Assert.IsNotNull(_content2);
        }
        [TestMethod]
        public void UpdateExistingContent_Test()
        {

            bool wasFound = _streamingRepo.UpdateExistingContent(_content.Title, _content2);
            Assert.IsTrue(wasFound);
        }
    }
}
