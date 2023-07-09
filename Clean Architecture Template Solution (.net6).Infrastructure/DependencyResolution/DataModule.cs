using Autofac;
using Clean_Architecture_Template_Solution__.net6_.Infrastructure.SQLContext;
using Microsoft.EntityFrameworkCore;
using SharedKernal.DataRepositories;
using SharedKernal.EntityFramework;

namespace Clean_Architecture_Template_Solution__.net6_.Infrastructure.DependencyResolution
{
    internal class DataModule : Module
    {
        internal static void Initialize(ContainerBuilder container)
        {
            container.RegisterType<ApplicationDbContext>().As<DbContext>().InstancePerLifetimeScope();
            container.RegisterType<UnitOfWork>().As<IUnitOfWork>().PropertiesAutowired();
        }
    }
}