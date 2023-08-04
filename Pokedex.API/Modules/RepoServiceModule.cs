using Autofac;
using Pokedex.Core.Repositories;
using Pokedex.Core.Services;
using Pokedex.Core.UnitOfWorks;
using Pokedex.Repository;
using Pokedex.Repository.Repositories;
using Pokedex.Repository.UnitOfWorks;
using Pokedex.Service.Mapping;
using Pokedex.Service.Services;
using System.Reflection;
using Module = Autofac.Module;



namespace Pokedex.API.Modules
{
    public class RepoServiceModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>));
            builder.RegisterGeneric(typeof(Service<>)).As(typeof(IService<>));

            builder.RegisterType(typeof(UnitOfWork)).As(typeof(IUnitOfWork));

            var apiAssembly = Assembly.GetExecutingAssembly();
            var repoAssembly = Assembly.GetAssembly(typeof(AppDbContext));
            var serviceAssembly= Assembly.GetAssembly(typeof(MapProfile));

            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssembly).Where(x => x.Name.EndsWith("Repository"))
                .AsImplementedInterfaces().InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly,serviceAssembly).Where(x=>x.Name.EndsWith("Service"))
                .AsImplementedInterfaces().InstancePerLifetimeScope();
        
        
        }
    }
}
