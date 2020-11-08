using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPatterns.State
{
    class LockedState : State
    {
        public LockedState(AudioPlayer ap) : base(ap) 
        {
            Console.WriteLine("Locked");

        }
        public override void Lock() 
        {
            if (_audioPlayer.Playing) 
                _audioPlayer.ChangeState(new PlayingState(_audioPlayer));
            else 
                _audioPlayer.ChangeState(new PausedState(_audioPlayer));
        }
        public override void Play() { }
        public override void Next() { }
        public override void Previous() { }

    }
}
