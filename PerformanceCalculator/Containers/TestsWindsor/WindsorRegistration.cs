using System;
using Castle.MicroKernel.Registration;
using Castle.Windsor;

namespace PerformanceCalculator.Containers.TestsWindsor
{
    public class WindsorRegistration : Registration
    {
        public override void RegisterSingleton<TFrom, TTo>(object container)
        {
            var c = (WindsorContainer)container;

            c.Register(Component.For<TFrom>().ImplementedBy<TTo>().LifeStyle.Singleton);
        }

        public override void RegisterTransient<TFrom, TTo>(object container)
        {
            var c = (WindsorContainer)container;

            c.Register(Component.For<TFrom>().ImplementedBy<TTo>().LifeStyle.Transient);
        }

        public override void RegisterPerThread<TFrom, TTo>(object container)
        {
            var c = (WindsorContainer)container;

            c.Register(Component.For<TFrom>().ImplementedBy<TTo>().LifeStyle.PerThread);
        }

        public override void RegisterFactoryMethod<TFrom, TTo>(object container, Func<object, TTo> obj)
        {
            var c = (WindsorContainer)container;

            c.Register(Component.For<TFrom>().UsingFactoryMethod(kernel => obj(kernel)).LifeStyle.Transient);
        }
    }
}