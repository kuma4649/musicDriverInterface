using System.Collections.Generic;

namespace musicDriverInterface
{
    public class CompilerInfo : Information
    {
        public List<string> partType;//partタイプ(PMDDotNETの場合は"YM2608","FM3chex","PPZ8"
        public List<int> partNumber;//part基準の絶対位置 (ドライバによっては全パートのリストができるわけではないので必要)
        public List<string> partName;//part名
        public List<int> totalCount;
        public List<int> loopCount;
        public List<int> bufferCount;
        public int jumpClock;//ジャンプポイントまでのクロック数
        public List<int> jumpChannel;//ジャンプしたチャンネル
        public object addtionalInfo;
        public string formatType;//出力データのフォーマット形式(複数のフォーマットを出力できるコンパイラ向けの識別情報となります)

    }
}
