using System;
using System.IO;

namespace musicDriverInterface
{
    public interface iPreprocessor :iInterface
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
