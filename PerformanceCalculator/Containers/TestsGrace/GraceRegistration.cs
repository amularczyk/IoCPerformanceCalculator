using System;
using Grace.DependencyInjection;

namespace PerformanceCalculator.Containers.TestsGrace
{
    public class GraceRegistration : Registration
    {
        public override void RegisterSingleton<TFrom, TTo>(object container)
        {
            var c = (DependencyInjectionContainer)container;

            c.Configure(x => { x.Export<TTo>().As<TFrom>().Lifestyle.Singleton(); });
        }

        public override void RegisterTransient<TFrom, TTo>(object container)
        {
            var c = (DependencyInjectionContainer)container;

            c.Configure(x => { x.Export<TTo>().As<TFrom>(); });
        }

        public override void RegisterPerThread<TFrom, TTo>(object container)
        {
            var c = (DependencyInjectionContainer)container;

            c.Configure(x => { x.Export<TTo>().As<TFrom>().Lifestyle.SingletonPerScope(); });
        }

        public override void RegisterFactoryMethod<TFrom, TTo>(object container, Func<object, TTo> obj)
        {
            var c = (DependencyInjectionContainer)container;

            c.Configure(x => { x.ExportFactory<TFrom>(() => obj(c)); });
        }
    }
}