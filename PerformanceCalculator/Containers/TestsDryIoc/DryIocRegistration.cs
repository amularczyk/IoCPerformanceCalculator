using System;
using DryIoc;

namespace PerformanceCalculator.Containers.TestsDryIoc
{
    public class DryIocRegistration : Registration
    {
        public override void RegisterSingleton<TFrom, TTo>(object container)
        {
            var c = (Container)container;

            c.Register<TFrom, TTo>(Reuse.Singleton);
        }

        public override void RegisterTransient<TFrom, TTo>(object container)
        {
            var c = (Container)container;

            c.Register<TFrom, TTo>();
        }

        public override void RegisterPerThread<TFrom, TTo>(object container)
        {
            var c = (Container)container;

            c.Register<TFrom, TTo>(Reuse.InThread);
        }

        public override void RegisterFactoryMethod<TFrom, TTo>(object container, Func<object, TTo> obj)
        {
            var c = (Container)container;

            c.RegisterDelegate<TFrom>(obj);
        }
    }
}