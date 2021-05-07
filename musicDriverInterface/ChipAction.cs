using System.IO;

namespace musicDriverInterface
{
    public abstract class ChipAction
    {
        /// <summary>
        /// チップ判断向け
        /// </summary>
        public abstract string GetChipName();
        /// <summary>
        /// チップデータ送信向け
        /// </summary>
        /// <param name="cd"></param>
        public abstract void WriteRegister(ChipDatum cd);
        /// <summary>
        /// PCMデータ送信向け
        /// </summary>
        public abstract void WritePCMData(byte[] data,int startAddress,int endAddress);
        /// <summary>
        /// ウェイト向け
        /// </summary>
        public abstract void WaitSend(long t1, int t2);
    }
}