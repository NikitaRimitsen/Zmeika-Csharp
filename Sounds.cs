﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace Zmeika_Csharp
{
    class Sounds
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        private string pathToMedia;

        public Sounds(string pathToResources)
        {

            pathToMedia = pathToResources;
        }

        public void Play(string sound)
        {
            player.URL = pathToMedia + ("game.mp3");
            player.settings.volume = 30;
            player.controls.play();
            player.settings.setMode("loop", true);
        }
        public void Stop(string sound)
        {
            player.URL = pathToMedia + sound;
            player.controls.stop();
        }
        public void PlayEat()
        {
            player.URL = pathToMedia + "eda.mp3";
            player.settings.volume = 40;
            player.controls.play();
        }
    }
}
