using Autofac;
using Database.SQL.Repository;
using Microsoft.Extensions.Configuration;

namespace Database.SQL
{
    public class DatabaseSqlModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder
                .Register(context => new BodyMassIndexContextFactory(
                    context.Resolve<IConfiguration>().GetValue<string>("ConnectionString")))
                .AsImplementedInterfaces();

            builder
                .RegisterGeneric(typeof(Repository<>))
                .As(typeof(Repository<>))
                .InstancePerLifetimeScope();
        }
    }
}