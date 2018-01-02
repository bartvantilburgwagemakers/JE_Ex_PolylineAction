using Joa.JewelEarth.Infrastructure.Startup.Abstractions;
using Joa.JewelEarth.Basics;
using JE_Ex_Addin.Commands;

namespace JE_Ex_Addin
{
    public sealed class JE_Ex_AddinPlugin : PluginBase, IAppModule
    {
        public void Configuration(IAppBuilder builder)
        {
            builder.UseServiceRegistration(
                x => x.Register<ICreatePolylineSetExerciseCommand, CreatePolylineSetExerciseCommand>()
                );
        }
    }
}
