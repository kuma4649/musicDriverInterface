using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musicDriverInterface
{
    public interface iDriver :iInterface
    {
        void Init(
            List<ChipAction> chipsAction
            , MmlDatum[] srcBuf
            , Func<string, Stream> appendFileReaderCallback
            , object addtionalOption
            );

        //-------
        //data Information
        //-------

        /// <summary>
        /// 演奏データ取得
        /// </summary>
        /// <returns></returns>
        MmlDatum[] GetDATA();

        byte[] GetPCMFromSrcBuf();

        Tuple<string, ushort[]>[] GetPCMTable();

        ChipDatum[] GetPCMSendData();

        List<Tuple<string, string>> GetTags();

        //-------
        //rendering
        //-------

        /// <summary>
        /// レンダリング開始
        /// </summary>
        /// <param name="renderingFreq">frame/sec</param>
        /// <param name="chipsMasterClock">音源毎の周波数(音源名,周波数)</param>
        void StartRendering(int renderingFreq , Tuple<string, int>[] chipsMasterClock);

        /// <summary>
        /// レンダリング終了
        /// </summary>
        void StopRendering();

        /// <summary>
        /// 1frame当たりのレンダリング
        /// </summary>
        void Rendering();

        /// <summary>
        /// 音源へ出力
        /// </summary>
        /// <param name="reg"></param>
        void WriteRegister(ChipDatum reg);

        //--------
        //Command
        //--------

        /// <summary>
        /// 曲の再生開始
        /// </summary>
        /// <param name="musicNumber">曲番号(0～)</param>
        void MusicSTART(int musicNumber);

        /// <summary>
        /// 現在再生中の曲を停止
        /// </summary>
        void MusicSTOP();

        /// <summary>
        /// 現在再生中の曲をフェードアウト
        /// </summary>
        void FadeOut();

        /// <summary>
        /// ドライバの内部情報を取得する
        /// </summary>
        object GetWork();

        /// <summary>
        /// 効果音の発音
        /// </summary>
        void ShotEffect();

        /// <summary>
        /// 演奏中か否か
        /// </summary>
        /// <returns>-1 : エラー終了  0 : 終了  1 : 再生中</returns>
        int GetStatus();

        /// <summary>
        /// 無限ループ系コマンドの最大回数
        /// </summary>
        /// <param name="loopCounter">-1:無限 0以上:繰り返し回数</param>
        int SetLoopCount(int loopCounter);

        /// <summary>
        /// 取得時点の曲のループ回数
        /// </summary>
        /// <returns>回数</returns>
        int GetNowLoopCounter();

        void SetDriverSwitch(params object[] param);

    }
}
