﻿namespace musicDriverInterface
{
    public enum enmMMLType
    {
        unknown,
        CompileSkip,    // !
        Tempo,          // T
        Instrument,     // @
        Volume,         // v
        TotalVolume,    // V
        Octave,         // o
        OctaveUp,       // >
        OctaveDown,     // <
        VolumeUp,       // )
        VolumeDown,     // (
        Length,         // l
        LengthClock,    // #
        Pan,            // p
        Detune,         // D
        DirectMode,     // DON DOF
        PcmMode,        // m
        PcmMap,         // mon mof
        Gatetime,       // q
        GatetimeDiv,    // Q
        Envelope,       // E
        ExtendChannel,  // EX
        HardEnvelope,   // EH
        LoopPoint,      // L
        Repeat,         // [
        RepeatEnd,      // ]
        Renpu,          // {
        RenpuEnd,       // }
        RepertExit,     // /
        Lfo,            // M
        LfoSwitch,      // S
        Y,              // y
        Noise,          // w
        NoiseToneMixer, // P
        KeyShift,       // K
        AddressShift,   // A
        MIDICh,         // CH
        MIDIControlChange, // CC
        Note,           // c d e f g a b
        Rest,           // r
        RestNoWork,     // R
        Bend,           // _
        Tie,            // &
        TiePC,          // ^
        TieMC,          // ~
        ToneDoubler,    // , 0
        Lyric,          // "
        SusOnOff,       // so sf
        JumpPoint,      // J
        Velocity,       // U
        SkipPlay,       // caret位置からの演奏のための特殊コマンド
        DCSGCh3Freq,    // wf
        TraceLocate,    // トレース機能向けロケータ
        ClockCounter,   // C
        RelativeVolumeSetting, //@v
        Effect,         // X
        Synchronous,    // *
    }
}
