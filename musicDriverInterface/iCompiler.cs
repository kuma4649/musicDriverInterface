using System;
using System.IO;

namespace musicDriverInterface
{
    public interface iCompiler : iInterface
    {
        void Init();

        MmlDatum[] Compile(
            Stream sourceMML
            , Func<string, Stream> appendFileReaderCallback
            );

        CompilerInfo GetCompilerInfo();

        void SetCompileSwitch(params object[] param);

    }
}
