using Autofac;
using MediatR;
using MediatR.Extensions.Autofac.DependencyInjection;

namespace Infrastructure.MediatR
{
    public class MediatrModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.AddMediatR(typeof(MediatrModule).Assembly);
            
            builder.RegisterGeneric(typeof(CommandValidatorBehavior<,>))
                .As(typeof(IPipelineBehavior<,>));
        }
    }
}