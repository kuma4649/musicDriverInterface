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

    }
}
