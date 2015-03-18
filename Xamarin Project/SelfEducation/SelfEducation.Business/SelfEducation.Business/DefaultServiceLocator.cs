﻿using System;
using System.Collections.Generic;
using Autofac;
using Microsoft.Practices.ServiceLocation;
using SelfEducation.Business.Private;
using SelfEducation.Business.Service;

namespace SelfEducation.Business
{
    public class DefaultServiceLocator : ServiceLocatorImplBase
    {
        private readonly IContainer _container;

        public DefaultServiceLocator(params Module[] platformModule)
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule(new DefaultModule());
            foreach (var s in platformModule)
            {
                builder.RegisterModule(s);
            }

            _container = builder.Build();
        }

        protected override object DoGetInstance(Type serviceType, string key)
        {
            return _container.Resolve(serviceType);
        }

        protected override IEnumerable<object> DoGetAllInstances(Type serviceType)
        {
            throw new NotImplementedException();
        }
    }

    public class DefaultModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<LogInService>().As<ILogInService>();
        }
    }
}