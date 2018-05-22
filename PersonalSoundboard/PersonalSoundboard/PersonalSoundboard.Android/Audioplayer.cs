using PersonalSoundboard;
using System;
using System.IO;

namespace Audioplayer.Droid
{

    class AudioplayerCustom : ISimpleAudioPlayer
    {
        Android.Media.MediaPlayer _player;
        static int index = 0;
        public bool Load(Stream audioStream)
        {

            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), $"cache{index++}.mp3");
            var fileStream = File.Create(path);
            audioStream.CopyTo(fileStream);
            fileStream.Close();

            _player?.Dispose();
            _player = new Android.Media.MediaPlayer();
            _player.SetDataSource(path);
            _player.Prepare();

            return true;
        }

        

        public void Play()
        {
            if(_player == null)
            {
                return;
            }

            if (_player.IsPlaying)
            {
                _player.SeekTo(0);
            }

            _player.Start();
        }

        public void Stop()
        {
            _player?.Stop();
        }

        public void Pauze()
        {

        }
    }
}