using System;
using PerformanceCalculator.Common;
using SimpleInjector;
using SimpleInjector.Extensions.LifetimeScoping;

namespace PerformanceCalculator.Containers.TestsSimpleInjector
{
    public class SimpleInjectorRegistration : Registration
    {
        public override object BeforeRegisterCallback(object container, RegistrationKind registrationKind)
        {
            if (registrationKind == RegistrationKind.PerThread)
            {
                var c = (Container)container;

                c.Options.DefaultScopedLifestyle = new LifetimeScopeLifestyle();

                return c;
            }

            return base.BeforeRegisterCallback(container, registrationKind);
        }

        public override void RegisterSingleton<TFrom, TTo>(object container)
        {
            var c = (Container)container;

            c.Register<TFrom, TTo>(Lifestyle.Singleton);
        }

        public override void RegisterTransient<TFrom, TTo>(object container)
        {
            var c = (Container)container;

            c.Register<TFrom, TTo>();
        }

        public override void RegisterPerThread<TFrom, TTo>(object container)
        {
            var c = (Container)container;

            c.Register<TFrom, TTo>(Lifestyle.Scoped);
        }

        public override void RegisterFactoryMethod<TFrom, TTo>(object container, Func<object, TTo> obj)
        {
            var c = (Container)container;

            // This container does not support proper registration as FactoryMethod!!
            c.Register<TFrom>(() => obj(container));
        }
    }
}