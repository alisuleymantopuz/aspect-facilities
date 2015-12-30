using AoPInterceptionAndFacility.Implementation;
using AoPInterceptionAndFacility.Service;
using Castle.MicroKernel.Registration;

namespace AoPInterceptionAndFacility.Container
{
    public class ServicesInstaller : IWindsorInstaller
    {
        public void Install(Castle.Windsor.IWindsorContainer container, Castle.MicroKernel.SubSystems.Configuration.IConfigurationStore store)
        {
            container.Register(Component.For<ICategoryService>().ImplementedBy<CategoryService>().LifestyleTransient());
        }
    }
}
