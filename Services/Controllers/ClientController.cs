﻿using Business.Contracts;
using Entities;
using Services.Core;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Services.Controllers
{
  
    public class ClientController : ApiControllerBase
    {
        private readonly IClientLogic clientLogic;
        private readonly IPolicyLogic policyLogic;

        public ClientController(IClientLogic clientLogic, IPolicyLogic policyLogic)
        {
            this.clientLogic = clientLogic;
            this.policyLogic = policyLogic;
        }

        [HttpGet]
        [Authorize(Roles = "admin,user")]
        [Route("api/clients/{id}")]
        public IHttpActionResult GetById(string id)
        {
            return GetHttpResponse(() =>
            {
                var client = this.clientLogic.GetById(id);
                var clientVm = ControllerProfile.Mapper.Map<Client, ClientModel>(client);

                return Ok(client);
            });
        }

        [HttpGet]
        [Authorize(Roles = "admin,user")]
        [Route("api/clients")]
        public IHttpActionResult GetAll()
        {
            return GetHttpResponse(() =>
            {
                var clients = this.clientLogic.GetAll().ToList();
                var clientsVm = ControllerProfile.Mapper.Map<List<Client>, List<ClientModel>>(clients);

                return Ok(clientsVm);
            });
        }

        [HttpGet]
        [Route("api/clients/byname/{name}")]
        [Authorize(Roles ="admin,user")]
        public IHttpActionResult GetByName(string name)
        {
            return GetHttpResponse(() =>
            {
                var client = this.clientLogic.GetByName(name);
                var clientVm = ControllerProfile.Mapper.Map<List<Client>, List<ClientModel>>(client);

                return Ok(clientVm);
            });
        }

        [HttpGet]
        [Route("api/clients/bypolicy/{id}")]
        [Authorize(Roles = "admin")]
        public IHttpActionResult GetByPolicy(string id)
        {
            return GetHttpResponse(() =>
            {
                var client = this.policyLogic.GetClientByPolicy(id);

                var clientVm = ControllerProfile.Mapper.Map<Client, ClientModel>(client);

                return Ok(clientVm);
            });
        }
    }
}