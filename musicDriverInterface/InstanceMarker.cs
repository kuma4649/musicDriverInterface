using System;
using System.Reflection;

namespace musicDriverInterface
{
    public class InstanceMarker
    {
        private Assembly asmCompiler = null;
        private Assembly asmDriver = null;
        private Assembly asmPreprocessor = null;

        public void LoadCompilerDll(string compilerDllFullPath)
        {
            asmCompiler = Assembly.LoadFrom(compilerDllFullPath);
            //asmCompiler = LoaddAssembly(compilerDllFullPath);
        }

        public iCompiler GetCompiler(string compilerFullNameSpaceInstance)
        {
            if (asmCompiler == null) return null;
            var info = asmCompiler.GetType(compilerFullNameSpaceInstance);
            return Activator.CreateInstance(info, new object[] { null }) as iCompiler;
        }

        public void LoadDriverDll(string driverDllFullPath)
        {
            asmDriver = Assembly.LoadFrom(driverDllFullPath);
            //asmDriver = LoaddAssembly(driverDllFullPath);
            //asmDriver = Assembly.UnsafeLoadFrom(driverDllFullPath);
        }

        public iDriver GetDriver(string driverFullNameSpaceInstance)
        {
            if (asmDriver == null) return null;
            var info = asmDriver.GetType(driverFullNameSpaceInstance);
            return Activator.CreateInstance(info, new object[] { null }) as iDriver;
        }

        public void LoadPreprocessorDll(string preprocessorDllFullPath)
        {
            asmPreprocessor = Assembly.LoadFrom(preprocessorDllFullPath);
        }

        public iPreprocessor GetPreprocessor(string preprocessorFullNameSpaceInstance)
        {
            if (asmPreprocessor == null) return null;
            var info = asmPreprocessor.GetType(preprocessorFullNameSpaceInstance);
            return Activator.CreateInstance(info, new object[] { null }) as iPreprocessor;
        }

        private string asmBase;
        public Assembly LoaddAssembly(string assemblyName)
        {
            asmBase = System.IO.Path.GetDirectoryName(assemblyName);

            AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);
            byte[] buf = System.IO.File.ReadAllBytes(assemblyName);
            System.Reflection.Assembly asm = System.Reflection.Assembly.Load(buf);
            return asm;
        }

        private Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            //This handler is called only when the common language runtime tries to bind to the assembly and fails.

            //Retrieve the list of referenced assemblies in an array of AssemblyName.
            Assembly MyAssembly, objExecutingAssemblies;
            string strTempAssmbPath = "";
            objExecutingAssemblies = args.RequestingAssembly;
            AssemblyName[] arrReferencedAssmbNames = objExecutingAssemblies.GetReferencedAssemblies();

            //Loop through the array of referenced assembly names.
            foreach (AssemblyName strAssmbName in arrReferencedAssmbNames)
            {
                //Check for the assembly names that have raised the "AssemblyResolve" event.
                if (strAssmbName.FullName.Substring(0, strAssmbName.FullName.IndexOf(",")) == args.Name.Substring(0, args.Name.IndexOf(",")))
                {
                    //Build the path of the assembly from where it has to be loaded.                
                    strTempAssmbPath = asmBase + "\\" + args.Name.Substring(0, args.Name.IndexOf(",")) + ".dll";
                    break;
                }

            }
            //Load the assembly from the specified path.                    
            MyAssembly = Assembly.LoadFrom(strTempAssmbPath);

            //Return the loaded assembly.
            return MyAssembly;
        }

    }
}
