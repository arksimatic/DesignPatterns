using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPatterns.State
{
    class PausedState : State
    {
        public PausedState(AudioPlayer ap) : base(ap) 
        {
            Console.WriteLine("Paused");
        }
        public override void Lock()
        {
            _audioPlayer.ChangeState(new LockedState(_audioPlayer));
        }
        public override void Play() 
        {
            _audioPlayer.StartSong();
            _audioPlayer.ChangeState(new PlayingState(_audioPlayer));
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
