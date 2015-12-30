using Castle.Core;
using Castle.MicroKernel.Facilities;

namespace AoPInterceptionAndFacility.Container
{
    public class InterceptorFacility : AbstractFacility
    {
        protected override void Init()
        {
            Kernel.ComponentRegistered += new Castle.MicroKernel.ComponentDataDelegate(Kernel_ComponentRegistered);
        }

        private void Kernel_ComponentRegistered(string key, Castle.MicroKernel.IHandler handler)
        {
            if (handler.ComponentModel.Name.EndsWith("CategoryService"))
            {
                handler.ComponentModel.Interceptors.Add(new InterceptorReference(typeof(LoggingInterceptor)));
            }
        }
    }
}
