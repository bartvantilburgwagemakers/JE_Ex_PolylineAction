# JE_Ex_PolylineAction Exercise Instructions

0. make sure the Targets.targets, section paths_to_change are updated to point to the correct paths.

1. Add an Action named AddPolylineAction to the strip
	1. select new item from JE_Ex_Addin -> 
	
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Add -> 

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; New Item -> 

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Installed -> 

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Visual C# Items -> 

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; JewelEarth SDK -> 

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Jewel Strip Action ->

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Name : "AddPolylineAction" -> 

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Next -> 

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Strip configuration : "Exercises\Polyline\Create" ->

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Image : check -> 

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ... -> folder: SDK Strip icons 28x28 -> file: CreatePolyline_28.png

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Next -> 

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Finish

1. Run Addin and Observe Button in strip
	1. F5
	1. New -> Sandbox Mode -> Use Sandbox mode
	1. Addins -> Exercise -> Polyline -> Create 
	1. It crashes! WHY ...
1. Update CreatePolylineSetExerciseCommand with Name, Color, Unit, and nodes
	1. JE_Ex_Addin -> Commands -> CreatePolylineSetExerciseCommand -> Execute
	1. After `var command = FactoryService.Create<IPolylineSetCreateCommand>();` insert the following
	```c#
	command.Name = @"myLines";
	command.Color = Color.Red.ToIColor();
	command.SetUnitSystem(UnitSystemDefinitionData.SI);

	command.AddPolylineNode(0, 0, new Point3D(10, 10, 10));
	command.AddPolylineNode(0, 1, new Point3D(20, 20, 20));
	command.AddPolylineNode(0, 2, new Point3D(30, 30, 30));
	command.AddPolylineNode(0, 3, new Point3D(40, 40, 40));
	command.AddPolylineNode(1, 4, new Point3D(100, 10, 10));
	command.AddPolylineNode(1, 5, new Point3D(110, 20, 15));
	command.AddPolylineNode(1, 6, new Point3D(120, 30, 20));
	command.AddPolylineNode(1, 7, new Point3D(130, 40, 30));
	```
	1. Update the usings
1. Inject the needed services into the `CreatePolylineSetAction` constructor:
	1. add some class level variables to `CreatePolylineSetAction`:
	```c#
	private IFactoryService m_factoryService;
	private readonly ICommandRunner m_commandRunner;
	private readonly IUiService m_uiService;
	```
	1. in the parameters of the constructor add
	```c#
	IFactoryService factoryService,
	ICommandRunner commandRunner,
	IUiService uiService
	```
	1. set the variables to the parameters in the constructor
	```c#
	m_factoryService = factoryService;
	m_commandRunner = commandRunner;
	m_uiService = uiService;
	```
	1. Update the usings
1. in the OnExecute of the CreatePolylineSetAction call the command CreatePolylineSetExerciseCommand 
	1. 
	```c#
	var command = m_factoryService.Create<ICreatePolylineSetExerciseCommand>();
	m_commandRunner.ExecuteAsync(command);
	m_uiService.RaiseUiUpdate(UiUpdateEventArgs.Empty);	
	```
	1. Update the usings
1. Run Addin, press button and observe polylines
	1. F5
	1. New -> Sandbox Mode -> Use Sandbox mode
	1. Addins -> Exercise -> Polyline -> Create 
	1. observe the polylineset