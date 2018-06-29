using System;
using Data.Implementations;
using Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Data.Tests
{
    [TestClass]
    public class ClientRepositoryTest
    {
        [TestMethod]
        public void GetClientByID_ReturnNull()
        {
            //Arrange
            var clientRepository = new Implementations.ClientRepository();

            //Act
            var client = clientRepository.GetById(It.IsAny<string>());

            Assert.AreEqual(null, client);
        }

        [TestMethod]
        public void GetClientByID_ReturnClient()
        {
            //Arrange
            var clientRepository = new Implementations.ClientRepository();

            //Act
            var client = clientRepository.GetById("a0ece5db-cd14-4f21-812f-966633e7be86");

            Assert.AreEqual("a0ece5db-cd14-4f21-812f-966633e7be86", client.id);
        }
    }
}
