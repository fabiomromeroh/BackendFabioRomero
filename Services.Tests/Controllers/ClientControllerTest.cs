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
        private ClientController Target { get; set; }

        private IClientLogic clientLogic { get; set; }
        private IPolicyLogic policyLogic { get; set; }

        [TestInitialize]
        public void OnInit()
        {

            //this.clientLogic = Mock.Of<IClientLogic>();
            //this.policyLogic = Mock.Of<IPolicyLogic>();


            //this.Target = new ClientController(this.clientLogic, this.policyLogic);
        }


        [TestMethod]
        public void Solicita_al_clientLogic_la_ejecucion_de_GetById()
        {
            //Arrange

            //Act
            //this.Target.GetById(It.IsAny<string>());

            ////Assert
            //Mock.Get(this.clientLogic).Verify(x => x.GetById(It.IsAny<string>()), Times.Once());
        }

        [TestMethod]
        public void Solicita_al_clientLogic_la_ejecucion_de_GetByName()
        {
            //Arrange

            //Act
            //this.Target.GetByName(It.IsAny<string>());

            ////Assert
            //Mock.Get(this.clientLogic).Verify(x => x.GetByName(It.IsAny<string>()), Times.Once());
        }
    }
}
