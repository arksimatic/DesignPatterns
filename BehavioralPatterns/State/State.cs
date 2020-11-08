using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPatterns.State
{
    public abstract class State
    {
        protected AudioPlayer _audioPlayer;
        public State(AudioPlayer ap)
        {
            _audioPlayer = ap;
        }
        public abstract void Lock();
        public abstract void Play();
        public abstract void Next();
        public abstract void Previous();
    }
}
