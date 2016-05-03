using Ninject;
using Ninject.Activation;
using Ninject.Activation.Blocks;
using Ninject.Components;
using Ninject.Modules;
using Ninject.Parameters;
using Ninject.Planning.Bindings;
using Ninject.Syntax;
using Patterns_Lab_1.FileProcess;
using Patterns_Lab_1.FileProcess.Interfaces;
using Patterns_Lab_1.Serialization;
using Patterns_Lab_1.Serialization.Csv;
using Patterns_Lab_1.Serialization.Interfaces;
using Patterns_Lab_1.Serialization.Xml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Lab_1_UI
{
    public class Resolver : IKernel
    {
        private static Resolver instance;

        public static Resolver Instance
        {
            get
            {
                if (instance == null)
                    instance = new Resolver();
                return instance;
            }
        }

        private IKernel kernel;

        private Resolver() 
        {
            this.kernel = new StandardKernel();
            ConfigurateResolver();
        }

        private void ConfigurateResolver()
        {
            this.Bind<SerializationFactoryContainer>().ToMethod<SerializationFactoryContainer>(contex => new SerializationFactoryContainer
                (
                    new List<ISerializationFactory>(2)
                    {
                        new CsvFactory(), new XmlFactory()
                    }
                )).InSingletonScope();
            //this.Bind<SerializationFactoryContainer>().ToConstructor<SerializationFactoryContainer>(args =>
            //    new SerializationFactoryContainer
            //    (
            //        new List<ISerializationFactory>(2)
            //        {
            //            new CsvFactory(), new XmlFactory()
            //        }
            //    )
            //).InSingletonScope();

            this.Bind<ITimetableFileReader>().To<TimetableFileReader>();
            this.Bind<ITimetableFileWriter>().To<TimetableFileWriter>();
        }

        #region Wrap Implementation
        public IActivationBlock BeginBlock()
        {
            return kernel.BeginBlock();
        }
        
        public IComponentContainer Components
        {
            get { return kernel.Components; }
        }

        public IEnumerable<IBinding> GetBindings(Type service)
        {
            return kernel.GetBindings(service);
        }

        public IEnumerable<INinjectModule> GetModules()
        {
            return kernel.GetModules();
        }

        public bool HasModule(string name)
        {
            return kernel.HasModule(name);
        }

        public void Inject(object instance, params IParameter[] parameters)
        {
            kernel.Inject(instance, parameters);
        }

        public void Load(IEnumerable<Assembly> assemblies)
        {
            kernel.Load(assemblies);
        }

        public void Load(IEnumerable<string> filePatterns)
        {
            kernel.Load(filePatterns);
        }

        public void Load(IEnumerable<INinjectModule> m)
        {
            kernel.Load(m);
        }

        public INinjectSettings Settings
        {
            get { return kernel.Settings; }
        }

        public void Unload(string name)
        {
            kernel.Unload(name);
        }

        public void AddBinding(IBinding binding)
        {
            kernel.AddBinding(binding);
        }

        public IBindingToSyntax<object> Bind(params Type[] services)
        {
            return kernel.Bind(services);
        }

        public IBindingToSyntax<T1, T2, T3, T4> Bind<T1, T2, T3, T4>()
        {
            return kernel.Bind<T1, T2, T3, T4>();
        }

        public IBindingToSyntax<T1, T2, T3> Bind<T1, T2, T3>()
        {
            return kernel.Bind<T1, T2, T3>();
        }

        public IBindingToSyntax<T1, T2> Bind<T1, T2>()
        {
            return kernel.Bind<T1, T2>();
        }

        public IBindingToSyntax<T> Bind<T>()
        {
            return kernel.Bind<T>();
        }

        public IBindingToSyntax<object> Rebind(params Type[] services)
        {
            return kernel.Rebind(services);
        }

        public IBindingToSyntax<T1, T2, T3, T4> Rebind<T1, T2, T3, T4>()
        {
            return kernel.Rebind<T1, T2, T3, T4>();
        }

        public IBindingToSyntax<T1, T2, T3> Rebind<T1, T2, T3>()
        {
            return kernel.Rebind<T1, T2, T3>();
        }

        public IBindingToSyntax<T1, T2> Rebind<T1, T2>()
        {
            return kernel.Rebind<T1, T2>();
        }

        public IBindingToSyntax<T1> Rebind<T1>()
        {
            return kernel.Rebind<T1>();
        }

        public void RemoveBinding(IBinding binding)
        {
            kernel.RemoveBinding(binding);
        }

        public void Unbind(Type service)
        {
            kernel.Unbind(service);
        }

        public void Unbind<T>()
        {
            kernel.Unbind<T>();
        }

        public bool CanResolve(IRequest request, bool ignoreImplicitBindings)
        {
            return kernel.CanResolve(request, ignoreImplicitBindings);
        }

        public bool CanResolve(IRequest request)
        {
            return kernel.CanResolve(request);
        }

        public IRequest CreateRequest(Type service, Func<IBindingMetadata, bool> constraint, IEnumerable<IParameter> parameters, bool isOptional, bool isUnique)
        {
            return kernel.CreateRequest(service, constraint, parameters, isOptional, isUnique);
        }

        public bool Release(object instance)
        {
            return kernel.Release(instance);
        }

        public IEnumerable<object> Resolve(IRequest request)
        {
            return kernel.Resolve(request);
        }

        public object GetService(Type serviceType)
        {
            return kernel.GetService(serviceType);
        }

        public bool IsDisposed
        {
            get { return kernel.IsDisposed; }
        }

        public void Dispose()
        {
            kernel.Dispose();
        }
        #endregion
    }
}
