using System;
using Autofac;
using PerformanceCalculator.Common;

namespace PerformanceCalculator.Containers.TestsAutofac
{
    public class AutofacRegistration : Registration
    {
        public override void RegisterSingleton<TFrom, TTo>(object container)
        {
            var cb = (ContainerBuilder)container;

            cb.RegisterType<TTo>().As<TFrom>().SingleInstance();
        }

        public override void RegisterTransient<TFrom, TTo>(object container)
        {
            var cb = (ContainerBuilder)container;

            cb.RegisterType<TTo>().As<TFrom>();
        }

        public override void RegisterPerThread<TFrom, TTo>(object container)
        {
            var cb = (ContainerBuilder)container;

            cb.RegisterType<TTo>().As<TFrom>().InstancePerLifetimeScope();
        }

        public override object AfterRegisterCallback(object container, RegistrationKind registrationKind)
        {
            return ((ContainerBuilder)container).Build();
        }

        public override void RegisterFactoryMethod<TFrom, TTo>(object container, Func<object, TTo> obj)
        {
            var cb = (ContainerBuilder)container;

            cb.Register<TFrom>(obj);
        }
    }
}