using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfAppUserControlandModel.Models;

namespace WpfAppUserControlandModel.ViewModels
{
    public class MusicPlayerViewModel : BaseViewModel
    {
        public MusicPlayer MusicPlayer { get; set; }
        public ICommand PlayCommand { get; set; }
        public ICommand StopCommand { get; set; }
        public ICommand NextCommand { get; set; }
        public ICommand BackCommand { get; set; }

        public string Title
        {
            get => this.MusicPlayer.CurrentSong.Name;
            set
            {
                if (this.MusicPlayer.CurrentSong.Name != value)
                {
                    this.MusicPlayer.CurrentSong.Name = value;
                    RaisePropertyChangedEvent();
                }
            }
        }

        public float Length
        {
            get => this.MusicPlayer.CurrentSong.Length;
            set
            {
                if(this.MusicPlayer.CurrentSong.Length != value)
                {
                    this.MusicPlayer.CurrentSong.Length = value;
                    RaisePropertyChangedEvent();
                }
            }
        }

        public MusicPlayerViewModel(MusicPlayer music)
        {
            MusicPlayer = music;
            PlayCommand = new BasicCommand(Play, canPlay);
            StopCommand = new BasicCommand(Stop, canStop);
            NextCommand = new BasicCommand(Next, canSkip);
            BackCommand = new BasicCommand(Back, canGoBack);
        }

        public void Play(object sender) 
        {
            MusicPlayer.Start();
            RaisePropertyChangedEvent("CurrentSong");
        }

        public bool canPlay(object sender)
        {
            if (MusicPlayer.isPlaying)
            {
                return false;
            }
            return true;
        }

        public void Stop(object sender)
        {
            MusicPlayer.Stop();
            RaisePropertyChangedEvent("CurrentSong");
        }

        public bool canStop(object sender)
        {
            if (MusicPlayer.isPlaying)
            {
                return true;
            }
            return false;
        }

        public void Next(object sender)
        {
            MusicPlayer.NextSong();
            RaisePropertyChangedEvent("CurrentSong");
        }

        public bool canSkip(object sender)
        {
            if (MusicPlayer.isPlaying)
            {
                return false;
            }
            return true;
        }

        public void Back(object sender)
        {
            MusicPlayer.BackSong();
            RaisePropertyChangedEvent("CurrentSong");
        }

        public bool canGoBack(object sender)
        {
            if (MusicPlayer.isPlaying)
            {
                return false;
            }
            return true;
        }
    }
}
