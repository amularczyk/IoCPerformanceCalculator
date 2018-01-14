using System;
using LightInject;

namespace PerformanceCalculator.Containers.TestsLightInject
{
    public class LightInjectRegistration : Registration
    {
        public override void RegisterSingleton<TFrom, TTo>(object container)
        {
            var c = (ServiceContainer)container;

            c.Register<TFrom, TTo>(new PerContainerLifetime());
        }

        public override void RegisterTransient<TFrom, TTo>(object container)
        {
            var c = (ServiceContainer)container;

            c.Register<TFrom, TTo>();
        }

        public override void RegisterPerThread<TFrom, TTo>(object container)
        {
            var c = (ServiceContainer)container;

            c.Register<TFrom, TTo>(new PerScopeLifetime());
        }

        public override void RegisterFactoryMethod<TFrom, TTo>(object container, Func<object, TTo> obj)
        {
            var c = (ServiceContainer)container;

            c.Register<TFrom>(obj);
        }
    }
}