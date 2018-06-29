using Business.Contracts;
using Data.Contracts;
using Data.Implementations;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Implementations
{
    public class UserLogic : BaseLogic<Client, ClientRepository>, IUserLogic
    {
        private readonly IUserRepository userRepository;

        public UserLogic(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public Client Login(string email)
        {
            return this.userRepository.Login(email);
        }
    }
}
