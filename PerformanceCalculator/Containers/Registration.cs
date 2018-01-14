using System;
using PerformanceCalculator.Common;
using PerformanceCalculator.Interfaces;

namespace PerformanceCalculator.Containers
{
    public abstract class Registration : IRegistration
    {
        public virtual object BeforeRegisterCallback(object container, RegistrationKind registrationKind)
        {
            return container;
        }

        public abstract void RegisterSingleton<TFrom, TTo>(object container)
            where TFrom : class
            where TTo : class, TFrom;

        public abstract void RegisterTransient<TFrom, TTo>(object container)
            where TFrom : class
            where TTo : class, TFrom;

        public abstract void RegisterPerThread<TFrom, TTo>(object container)
            where TFrom : class
            where TTo : class, TFrom;

        public abstract void RegisterFactoryMethod<TFrom, TTo>(object container, Func<object, TTo> obj)
            where TFrom : class
            where TTo : class, TFrom;

        public virtual object AfterRegisterCallback(object container, RegistrationKind registrationKind)
        {
            return container;
        }
    }
}