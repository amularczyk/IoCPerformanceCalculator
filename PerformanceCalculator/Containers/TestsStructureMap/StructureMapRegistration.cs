using System;
using StructureMap;
using StructureMap.Pipeline;

namespace PerformanceCalculator.Containers.TestsStructureMap
{
    public class StructureMapRegistration : Registration
    {
        public override void RegisterSingleton<TFrom, TTo>(object container)
        {
            var c = (Container)container;

            c.Configure(x => { x.For<TFrom>().Use<TTo>().Singleton(); });
        }

        public override void RegisterTransient<TFrom, TTo>(object container)
        {
            var c = (Container)container;

            c.Configure(x => { x.For<TFrom>().Use<TTo>().AlwaysUnique(); });
        }

        public override void RegisterPerThread<TFrom, TTo>(object container)
        {
            var c = (Container)container;

            c.Configure(x => { x.For<TFrom>(Lifecycles.ThreadLocal).Use<TTo>(); });
        }

        public override void RegisterFactoryMethod<TFrom, TTo>(object container, Func<object, TTo> obj)
        {
            var c = (Container)container;

            c.Configure(x => { x.For<TFrom>(Lifecycles.Unique).Use(context => obj(context)); });
        }
    }
}