using System.ComponentModel.Composition;
using Joa.JewelEarth.Basics.Attributes;
using Joa.JewelEarth.Basics.Commands;
using JE_Ex_Addin.Properties;
using Joa.JewelEarth.Services;
using Joa.JewelEarth.Surfaces.Commands;

namespace JE_Ex_Addin.Commands
{
    [Command(ResourceAssemblyType = typeof(Resources), MapKey = @"CreatePolylineSet")]
    public class CreatePolylineSetExerciseCommand : CommandBase, ICreatePolylineSetExerciseCommand
    {
        [Import]
        public IFactoryService FactoryService { get; set; }
        
        public override bool Execute()
        {
            var command = FactoryService.Create<IPolylineSetCreateCommand>();
            
            return command.Execute();
        }
        
        public override void CreateDescription()
        {
            Description = Resources.CreatedAPolylineSet;
        }
    }
}
