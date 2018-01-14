using System;
using PerformanceCalculator.Common;

namespace PerformanceCalculator.Interfaces
{
    public interface IRegistration
    {
        object BeforeRegisterCallback(object container, RegistrationKind registrationKind);

        void RegisterSingleton<TFrom, TTo>(object container)
            where TFrom : class
            where TTo : class, TFrom;

        void RegisterTransient<TFrom, TTo>(object container)
            where TFrom : class
            where TTo : class, TFrom;

        void RegisterPerThread<TFrom, TTo>(object container)
            where TFrom : class
            where TTo : class, TFrom;

        void RegisterFactoryMethod<TFrom, TTo>(object container, Func<object, TTo> obj)
            where TFrom : class
            where TTo : class, TFrom;

        object AfterRegisterCallback(object container, RegistrationKind registrationKind);
    }
}