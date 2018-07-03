using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data.Contracts;
using Moq;
using Entities;
using Business.Implementations;
using Data.Base;
using Entities.Dto;

namespace Business.Tests
{
    /// <summary>
    /// Summary description for ClientLogicTest
    /// </summary>
    [TestClass]
    public class ClientLogicTest
    {
        private ClientLogic Target { get; set; }

        private IClientRepository clientRepository;
        [TestInitialize]
        public void OnInit()
        {

            this.clientRepository = Mock.Of<IClientRepository>();

            this.Target = new ClientLogic(this.clientRepository);
        }

        [TestMethod]
        public void Solicita_Al_ClientRepository_que_ejecute_GetById()
        {
            //Arrange

            //Act
            this.Target.GetById(It.IsAny<string>());

            //Assert
            Mock.Get(this.clientRepository).Verify(x => x.GetById(It.IsAny<string>()), Times.Once());
        }


    }
}
