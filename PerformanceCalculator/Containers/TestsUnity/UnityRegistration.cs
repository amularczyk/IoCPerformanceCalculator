using System;
using Microsoft.Practices.Unity;

namespace PerformanceCalculator.Containers.TestsUnity
{
    public class UnityRegistration : Registration
    {
        public override void RegisterSingleton<TFrom, TTo>(object container)
        {
            var c = (UnityContainer)container;

            c.RegisterType<TFrom, TTo>(new ContainerControlledLifetimeManager());
        }

        public override void RegisterTransient<TFrom, TTo>(object container)
        {
            var c = (UnityContainer)container;

            c.RegisterType<TFrom, TTo>();
        }

        public override void RegisterPerThread<TFrom, TTo>(object container)
        {
            var c = (UnityContainer)container;

            c.RegisterType<TFrom, TTo>(new PerThreadLifetimeManager());
        }

        public override void RegisterFactoryMethod<TFrom, TTo>(object container, Func<object, TTo> obj)
        {
            var c = (UnityContainer)container;

            c.RegisterType<TFrom>(new InjectionFactory(obj));
        }
    }
}