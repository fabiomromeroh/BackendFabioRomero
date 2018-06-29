using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services.Controllers;
using Moq;
using Entities;
using Business.Contracts;

namespace Services.Tests.Controllers
{
    /// <summary>
    /// Summary description for ClientTest
    /// </summary>
    [TestClass]
    public class ClientControllerTest
    {
        public ClientControllerTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }


        [TestMethod]
        public void GetClientById()
        {
            //Arrange
            var clientLogic = new Mock<IClientLogic>();
            var policyLogic = new Mock<IPolicyLogic>();

            clientLogic.Setup(x => x.GetById(It.IsAny<string>()))
                .Returns(() => new Client());

            var controller = new ClientController(clientLogic.Object, policyLogic.Object);
            //Act
            controller.GetById("a0ece5db-cd14-4f21-812f-966633e7be");
            //Assert
            clientLogic.Verify(x=>x.GetById("a0ece5db-cd14-4f21-812f-966633e7be"));
        }
    }
}
