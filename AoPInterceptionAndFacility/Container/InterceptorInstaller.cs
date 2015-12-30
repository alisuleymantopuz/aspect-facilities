using Castle.MicroKernel.Registration;
using Castle.Windsor;

namespace AoPInterceptionAndFacility.Container
{
    public class InterceptorInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, Castle.MicroKernel.SubSystems.Configuration.IConfigurationStore store)
        {
            container.Register(Component.For<LoggingInterceptor>().LifestyleTransient());
        }
    }
}
