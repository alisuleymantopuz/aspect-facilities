using Castle.Windsor;

namespace AoPInterceptionAndFacility.Container
{
    public class Bootstrapper
    {
        public static IWindsorContainer Container { get; set; }

        public static void Initialize()
        {

            Container = new WindsorContainer();

            Container.AddFacility<InterceptorFacility>()
                .Install(new InterceptorInstaller())
                .Install(new ServicesInstaller());



        }
    }
}
