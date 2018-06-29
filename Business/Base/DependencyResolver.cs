using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Core.DI;
using System.ComponentModel.Composition;
using Business.Contracts;
using Business.Implementations;
using Data.Contracts;
using Data.Implementations;
using Data.Base;

namespace Business.Base
{
    [Export(typeof(Core.DI.IComponent))]
    public class DependencyResolver : Core.DI.IComponent
    {
        public void SetUp(IRegisterComponent registerComponent)
        {
            registerComponent.RegisterType<IClientLogic, ClientLogic>();
            registerComponent.RegisterType<IPolicyLogic, PolicyLogic>();
            registerComponent.RegisterType<IUserLogic, UserLogic>();

            registerComponent.RegisterType<IClientRepository, ClientRepository>();
            registerComponent.RegisterType<IPolicyRepository, PolicyRepository>();
            registerComponent.RegisterType<IUserRepository, UserRepository>();

            registerComponent.RegisterType<IContext, Context>();

        }
    }
}
