using Business.Contracts;
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
    public class PolicyController : ApiControllerBase
    {
        private readonly IPolicyLogic policyLogic;

        public PolicyController(IPolicyLogic policyLogic)
        {
            this.policyLogic = policyLogic;
        }

        [HttpGet]
        [Route("api/Policy/GetByClient/{name}")]
        [Authorize(Roles = "admin")]
        public IHttpActionResult GetByClient(string name)
        {
            return GetHttpResponse(() =>
            {
                var policies = policyLogic.GetByClientName(name);
                var policiesVm = ControllerProfile.Mapper.Map<List<Policy>, List<PolicyModel>>(policies);

                return Ok(policiesVm);
            });

        }

        [HttpGet]
        [Authorize(Roles = "admin,user")]
        [Route("api/Policy/GetAll")]
        public IHttpActionResult GetAll()
        {
            return GetHttpResponse(() =>
            {
                var policies = this.policyLogic.GetAll().ToList();
                var policiesVm = ControllerProfile.Mapper.Map<List<Policy>, List<PolicyModel>>(policies);

                return Ok(policiesVm);
            });
        }

    }
}