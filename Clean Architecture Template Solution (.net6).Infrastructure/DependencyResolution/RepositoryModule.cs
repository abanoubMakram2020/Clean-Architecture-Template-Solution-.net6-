using Autofac;
using Clean_Architecture_Template_Solution__.net6_.Domain.Interfases.Repositories.Dapper;
using Clean_Architecture_Template_Solution__.net6_.Domain.Interfases.Repositories.Entity;
using Clean_Architecture_Template_Solution__.net6_.Domain.Repositories.Dapper;
using Clean_Architecture_Template_Solution__.net6_.Domain.Repositories.Entity;
using System;
using System.Linq;

namespace Clean_Architecture_Template_Solution__.net6_.Infrastructure.DependencyResolution
{
    internal class RepositoryModule : Module
    {
        internal static void Initialize(ContainerBuilder container)
        {
            ResolveEntityRepositories(container);
            ResolveDapperRepositories(container);
        }

        private static void ResolveEntityRepositories(ContainerBuilder builder)
        {
            var repository = typeof(SampleRepository);
            var iRepository = typeof(ISampleRepository);
            Type[] repositories = System.Reflection.Assembly.Load(repository.Assembly.GetName()).GetTypes().Where(x => string.Equals(x.Namespace, repository.Namespace, StringComparison.Ordinal) /*&& x.IsSubclassOf(typeof(EntityBaseRepository<,>))*/).ToArray();
            Type[] iRepositories = System.Reflection.Assembly.Load(iRepository.Assembly.GetName()).GetTypes().Where(a => string.Equals(a.Namespace, iRepository.Namespace, StringComparison.Ordinal) && a.IsInterface).ToArray();
            Resolve(builder, repositories, iRepositories);
        }

        private static void ResolveDapperRepositories(ContainerBuilder builder)
        {
            var repository = typeof(DapperSampleRepository);
            var iRepository = typeof(IDapperSampleRepository);
            Type[] repositories = System.Reflection.Assembly.Load(repository.Assembly.GetName()).GetTypes().Where(x => string.Equals(x.Namespace, repository.Namespace, StringComparison.Ordinal) /*&& x.IsSubclassOf(typeof(Base.BaseUseCase))*/).ToArray();
            Type[] iRepositories = System.Reflection.Assembly.Load(iRepository.Assembly.GetName()).GetTypes().Where(a => string.Equals(a.Namespace, iRepository.Namespace, StringComparison.Ordinal) && a.IsInterface).ToArray();
            Resolve(builder, repositories, iRepositories);
        }

        private static void Resolve(ContainerBuilder builder, Type[] repository, Type[] irepository)
        {
            foreach (Type repo in irepository)
            {
                Type classType = repository.FirstOrDefault(x => repo.IsAssignableFrom(x));
                if (classType != null)
                {
                    builder.RegisterType(classType).As(repo).PropertiesAutowired().InstancePerLifetimeScope();
                }
            }
        }
    }
}