using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppUserControlandModel.Models
{
    public class MusicPlayer
    {
        public List<Song> Songs {  get; set; }
        public IPlayable CurrentSong { get; set; }
        public bool isPlaying { get; set; }

        public MusicPlayer(List<Song> Q) 
        { 
            Songs = Q;
        }

        public void Start()
        {
            CurrentSong = Songs[0];
            isPlaying = true;
        }

        public void Stop()
        {
            CurrentSong = null;
            isPlaying = false;
        }

        public void NextSong()
        {
            for(int i = 0; i < Songs.Count; i++)
            {
                if (Songs[i - 1] == CurrentSong)
                {
                    CurrentSong = Songs[i];
                }
            }
        }

        public void BackSong()
        {
            for (int i = 0; i < Songs.Count; i++)
            {
                if (Songs[i] == CurrentSong)
                {
                    CurrentSong = Songs[i - 1];
                }
            }
        }
    }
}
