using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPatterns.State
{
    class PlayingState : State
    {
        public PlayingState(AudioPlayer ap) : base(ap) 
        {
            Console.WriteLine("Playing");
        }
        public override void Lock()
        {
            _audioPlayer.ChangeState(new LockedState(_audioPlayer));
        }
        public override void Play()
        {
            _audioPlayer.StopSong();
            _audioPlayer.ChangeState(new PausedState(_audioPlayer));
        }
        public override void Next()
        {
            _audioPlayer.NextSong();
        }
        public override void Previous()
        {
            _audioPlayer.PreviousSong();
        }
    }
}
