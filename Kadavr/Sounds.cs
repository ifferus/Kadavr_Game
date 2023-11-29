using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace Kadavr
{
    internal class Sounds
    {
        public bool played = false;
        Random rnd;

        public WindowsMediaPlayer Shoot = new WindowsMediaPlayer
        {
            URL = "audio\\shoot.mp3"
        };
        public WindowsMediaPlayer Song = new WindowsMediaPlayer
        {
            URL = "audio\\main.mp3"
        };
        public WindowsMediaPlayer Howl = new WindowsMediaPlayer
        {
            URL = "audio\\howl.mp3"
        };
        public WindowsMediaPlayer Hit = new WindowsMediaPlayer
        {
            URL = "audio\\hit.mp3"
        };
        public WindowsMediaPlayer speechShoot_1 = new WindowsMediaPlayer
        {
            URL = "audio\\speechShoot.mp3"
        };
        public WindowsMediaPlayer speechShoot_2 = new WindowsMediaPlayer
        {
            URL = "audio\\speechShootTwo.mp3"
        };
        public WindowsMediaPlayer speechShoot_3 = new WindowsMediaPlayer
        {
            URL = "audio\\speechShootThree.mp3"
        };
        public WindowsMediaPlayer speechShoot_4 = new WindowsMediaPlayer
        {
            URL = "audio\\speechShootFour.mp3"
        };
        public WindowsMediaPlayer speechDeath = new WindowsMediaPlayer
        {
            URL = "audio\\speechDeath.mp3"
        };
        public WindowsMediaPlayer mainMenu = new WindowsMediaPlayer
        {
            URL = "audio\\mainMenu.mp3"
        };

        public void StopAllSounds()
        {
            Shoot.controls.stop();
            Howl.controls.stop();
            Hit.controls.stop();
            speechShoot_1.controls.stop();
            speechShoot_2.controls.stop();
            speechShoot_3.controls.stop();
            speechShoot_4.controls.stop();
            speechDeath.controls.stop();
            Song.controls.stop();
            mainMenu.controls.stop();
        }
        public void SoundsMainTheme()
        {
            Song.settings.setMode("loop", true);
            Song.settings.volume = 50;
            Song.controls.play();
        }

        public void SoundsMainMenu()
        {
            mainMenu.settings.setMode("loop", true);
            mainMenu.settings.volume = 50;
            mainMenu.controls.play();
        }

        public void SoundsShoot()
        {
            Shoot.settings.volume = 60;
            Shoot.controls.play();
        }


        public void SoundsHowl()
        {
            Howl.settings.volume = 60;
            Howl.controls.play();
        }

        public void SoundsHit()
        {
            Hit.settings.volume = 60;
            Hit.controls.play();
        }

        public void SoundsSpeech()
        { 
            Random rnd = new Random();
            int i = rnd.Next(0, 100);
            if (played == false ) {
                if (i < 25)
                {
                    speechShoot_1.controls.play();
                    played = true;
                }
                if (i > 25 && i < 50)
                {
                    speechShoot_2.controls.play();
                    played = true;
                }
                if (i > 50 && i < 75)
                {
                    speechShoot_3.controls.play();
                    played = true;
                }
                if (i > 75 && i < 100)
                {
                    speechShoot_4.controls.play();
                    played = true;
                }
            }
            played = false;
        }
        
        public void SoundsSpeechDeath()
        {
            speechDeath.settings.volume = 60;
            speechDeath.controls.play();
        }
    }
}
