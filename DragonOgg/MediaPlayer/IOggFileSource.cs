using System;
using csvorbis;

namespace DragonOgg.MediaPlayer {

    public interface IOggFileSource {
        string FileName { get; }
        VorbisFile VorbisFile { get; }
        TagLib.File TagLibFile { get; }
    }
}

