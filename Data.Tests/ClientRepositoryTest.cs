using System;
using System.Collections.Generic;
using Data.Base;
using Data.Implementations;
using Entities;
using Entities.Dto;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Data.Tests
{
    [TestClass]
    public class ClientRepositoryTest
    {
        private ClientRepository Target { get; set; }
        private IContext context;
        [TestInitialize]
        public void OnInit()
        {
            var clients = new List<Client>
            {
                Mock.Of<Client>(c => c.id == "1" && c.name == "Fabio")
            };
            this.context = Mock.Of<IContext>(c => c.ClientResult == Mock.Of<ClientResultDto>(cr => cr.clients == clients));
            this.Target = new ClientRepository(this.context);
        }

        [TestMethod]
        public void GetClientByID_ReturnNull()
        {
            //Arrange

            //Act
            var client = this.Target.GetById("2");

            //Assert
            Assert.AreEqual(null, client);
        }

        [TestMethod]
        public void GetClientByID_ReturnClient()
        {
            //Arrange

            //Act
            var client = this.Target.GetById("1");

            //Assert
            Assert.AreEqual("1", client.id);
        }
    }
}
