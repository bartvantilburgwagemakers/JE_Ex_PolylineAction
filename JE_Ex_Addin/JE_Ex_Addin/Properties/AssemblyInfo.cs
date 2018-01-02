using JE_Ex_Addin.Properties;
using Joa.JewelEarth.Basics.Attributes;
using System.Reflection;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("JE_Ex_Addin")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Baker Hughes Reservoir Software, BV")]
[assembly: AssemblyProduct("JE_Ex_Addin")]
[assembly: AssemblyCopyright("Copyright 2017 Baker Hughes. All rights reserved. Company proprietary and confidential.")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("a5be9131-724a-4300-8c55-3dea46357c97")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("2017.4.238.0")]
[assembly: AssemblyFileVersion("2017.4.711.0")]
[assembly: PluginLayoutDefinition(@"JE_Ex_Addin.JE_Ex_Addin.pldf", typeof(Resources))]
[assembly: PluginDependency(@"JewelExplorer.AddIn")]
