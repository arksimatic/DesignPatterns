using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPatterns.State
{
    public class AudioPlayer
    {
        State _state;
        public bool Playing { get; private set; }

        public AudioPlayer()
        {
            _state = new PausedState(this);
            Playing = false;
        }

        public void ChangeState(State state) => _state = state;


        public void ClickLock() => _state.Lock();
        public void ClickPlay() => _state.Play();
        public void ClickNext() => _state.Next();
        public void ClickPrevious() => _state.Previous();


        public void NextSong()
        {
            Console.WriteLine("-Next song");
        }
        public void PreviousSong()
        {
            Console.WriteLine("-Previous song");
        }
        public void StartSong()
        {
            Playing = true;
            Console.WriteLine("-Song is playing");
        }
        public void StopSong()
        {
            Playing = false;
            Console.WriteLine("-Song stopped playing");
        }
    }
}
