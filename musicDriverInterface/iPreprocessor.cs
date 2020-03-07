using System;
using System.IO;

namespace musicDriverInterface
{
    public interface iPreprocessor
    {
        void Preprocess(
            Stream sourceMML
            , Stream destMML
            , Func<string, Stream> appendFileReaderCallback
            );

        void Init();

        PreprocessorInfo GetPreprocessorInfo();
    }
}
