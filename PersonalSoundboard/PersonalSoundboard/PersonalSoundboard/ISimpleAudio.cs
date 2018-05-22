using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PersonalSoundboard
{
    public interface ISimpleAudioPlayer
    {
        bool Load(Stream audioStream);

        void Play();

        void Pauze();

        void Stop();
    }
}
