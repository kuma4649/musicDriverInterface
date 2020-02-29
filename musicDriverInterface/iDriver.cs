using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musicDriverInterface
{
    public interface iDriver
    {
        void Init(string fileName
            , Action<ChipDatum> chipWriteRegister
            , Action<long, int> chipWaitSend
            , MmlDatum[] srcBuf
            , object addtionalOption
            );

        //-------
        //data Information
        //-------

        MmlDatum[] GetDATA();

        List<Tuple<string, string>> GetTags();

        byte[] GetPCMFromSrcBuf();

        Tuple<string, ushort[]>[] GetPCMTable();

        ChipDatum[] GetPCMSendData();

        //-------
        //rendering
        //-------

        void StartRendering(int renderingFreq = 44100, int chipMasterClock = 7987200);

        void StopRendering();

        void Rendering();

        void WriteRegister(ChipDatum reg);

        //--------
        //Command
        //--------

        void MusicSTART(int musicNumber);

        void MusicSTOP();

        void FadeOut();

        object GetWork();

        void ShotEffect();

        int GetStatus();
    }
}
