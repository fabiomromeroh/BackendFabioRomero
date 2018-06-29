using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Contracts
{
    public interface IClientLogic : IBaseLogic<Client>
    {
        Client GetById(string clientId);
        Client GetByName(string name);
    }
}
