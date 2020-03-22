using System;
using System.IO;

namespace musicDriverInterface
{
    public interface iCompiler
    {
        MmlDatum[] Compile(
            Stream sourceMML
            , Func<string, Stream> appendFileReaderCallback
            );

        void Init();

        CompilerInfo GetCompilerInfo();

        void SetCompileSwitch(params object[] param);
    }
}
