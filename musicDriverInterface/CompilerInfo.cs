using System.Collections.Generic;

namespace musicDriverInterface
{
    public class CompilerInfo : Information
    {
        public List<int> totalCount;
        public List<int> loopCount;
        public List<int> bufferCount;
        public int jumpClock;//ジャンプポイントまでのクロック数
        public List<int> jumpChannel;//ジャンプしたチャンネル
        public object addtionalInfo;

    }
}
