using System;
using NiquIoC;

namespace PerformanceCalculator.Containers.TestsNiquIoCFull
{
    public class NiquIoCFullRegistration : Registration
    {
        public override void RegisterSingleton<TFrom, TTo>(object container)
        {
            var c = (Container)container;

            c.RegisterType<TFrom, TTo>().AsSingleton();
        }

        public override void RegisterTransient<TFrom, TTo>(object container)
        {
            var c = (Container)container;

            c.RegisterType<TFrom, TTo>();
        }

        public override void RegisterPerThread<TFrom, TTo>(object container)
        {
            var c = (Container)container;

            c.RegisterType<TFrom, TTo>().AsPerThread();
        }

        public override void RegisterFactoryMethod<TFrom, TTo>(object container, Func<object, TTo> obj)
        {
            var c = (Container)container;

            c.RegisterType<TFrom>(obj);
        }
    }
}