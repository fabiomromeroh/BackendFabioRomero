using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data.Contracts;
using Moq;
using Entities;
using Business.Implementations;

namespace Business.Tests
{
    /// <summary>
    /// Summary description for ClientLogicTest
    /// </summary>
    [TestClass]
    public class ClientLogicTest
    {
        public ClientLogicTest()
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

        [TestMethod]
        public void GetClientById_WithAValidId_ReturnClient()
        {
            //Arrange
            var clientRepository = new Mock<IClientRepository>();

            //Act
            clientRepository.Setup(x => x.GetById(It.IsAny<string>()))
                .Returns(() => new Client());
            var clientLogic = new ClientLogic(clientRepository.Object);
            clientLogic.GetById(It.IsAny<string>());


            //Assert
            clientRepository.Verify(x => x.GetById(It.IsAny<string>()));
        }

        [TestMethod]
        public void GetClientById_ReturnNull()
        {
            //Arrange
            var clientRepository = new Mock<IClientRepository>();

            //Act
            clientRepository.Setup(x => x.GetById(It.IsAny<string>()))
                .Returns(() => null);
            var clientLogic = new ClientLogic(clientRepository.Object);
            clientLogic.GetById("a0ece5db-cd14-4f21-812f-966633e7be86");


            //Assert
            clientRepository.Verify(x => x.GetById(It.IsAny<string>()));
        }
    }
}
