using System;
using System.Reflection;

namespace musicDriverInterface
{
    public class InstanceMarker
    {
        public iCompiler GetCompiler(string compilerDllFullPath, string compilerFullNameSpace)
        {
            Assembly asm = Assembly.LoadFrom(compilerDllFullPath);
            var info = asm.GetType(compilerFullNameSpace);
            return Activator.CreateInstance(info, new object[] { null }) as iCompiler;
        }

        public iDriver GetDriver(string driverDllFullPath, string driverFullNameSpace)
        {
            Assembly asm = Assembly.LoadFrom(driverDllFullPath);
            var info = asm.GetType(driverFullNameSpace);
            return Activator.CreateInstance(info, new object[] { null }) as iDriver;
        }

        public iPreprocessor GetPreprocessor(string preprocessorDllFullPath, string preprocessorFullNameSpace)
        {
            Assembly asm = Assembly.LoadFrom(preprocessorDllFullPath);
            var info = asm.GetType(preprocessorFullNameSpace);
            return Activator.CreateInstance(info, new object[] { null }) as iPreprocessor;
        }

    }
}
