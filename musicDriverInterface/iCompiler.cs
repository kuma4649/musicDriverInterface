using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musicDriverInterface
{
    public interface iCompiler
    {
        string OutFileName { get; set; }

        void Init();

        MmlDatum[] StartToMmlData(
            string srcPath
            , string wrkPath
            , Action<string> dispMessage
            );

        CompilerInfo GetCompilerInfo();

    }
}
