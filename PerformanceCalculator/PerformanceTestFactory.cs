using PerformanceCalculator.Common;
using PerformanceCalculator.Containers.TestsAutofac;
using PerformanceCalculator.Containers.TestsDryIoc;
using PerformanceCalculator.Containers.TestsGrace;
using PerformanceCalculator.Containers.TestsLightInject;
using PerformanceCalculator.Containers.TestsNinject;
using PerformanceCalculator.Containers.TestsNiquIoCFull;
using PerformanceCalculator.Containers.TestsNiquIoCPartial;
using PerformanceCalculator.Containers.TestsSimpleInjector;
using PerformanceCalculator.Containers.TestsStructureMap;
using PerformanceCalculator.Containers.TestsUnity;
using PerformanceCalculator.Containers.TestsWindsor;
using PerformanceCalculator.Exceptions;
using PerformanceCalculator.Interfaces;

namespace PerformanceCalculator
{
    internal static class PerformanceTestFactory
    {
        internal static IPerformanceTest GetPerformance(string name)
        {
            switch (name)
            {
                case ContainerName.Autofac:
                    return new AutofacPerformanceTest();

                case ContainerName.DryIoc:
                    return new DryIocPerformanceTest();

                case ContainerName.Grace:
                    return new GracePerformanceTest();

                case ContainerName.LightInject:
                    return new LightInjectPerformanceTest();

                case ContainerName.Ninject:
                    return new NinjectPerformanceTest();

                case ContainerName.NiquIoCPartial:
                    return new NiquIoCPartialPerformanceTest();

                case ContainerName.NiquIoCFull:
                    return new NiquIoCFullPerformanceTest();

                case ContainerName.SimpleInjector:
                    return new SimpleInjectorPerformanceTest();

                case ContainerName.StructureMap:
                    return new StructureMapPerformanceTest();

                case ContainerName.Unity:
                    return new UnityPerformanceTest();

                case ContainerName.Windsor:
                    return new WindsorPerformanceTest();

                default:
                    throw new PerformanceTestNotFoundException(name);
            }
        }
    }
}