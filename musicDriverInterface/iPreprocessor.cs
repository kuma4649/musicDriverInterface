using System;
using System.IO;

namespace musicDriverInterface
{
    public interface iPreprocessor
    {
        Stream Preprocess(
            Stream sourceMML
            , Func<string, Stream> appendFileReaderCallback
            );

        void Init();

        PreprocessorInfo GetPreprocessorInfo();
    }
}
