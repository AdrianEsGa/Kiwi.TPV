using Kiwi.Tpv.App.Properties;
using System;
using System.IO;

namespace Kiwi.Tpv.App.Util
{
    public static class SoundController
    {
        public static void PlayChicoteSound()
        {
            var random = new Random().Next(1, 3);

            switch (random)
            {
                case 1:
                    PlaySound(Resources.PimPam);
                    break;

                case 2:
                    PlaySound(Resources.TrucuTrucu);
                    break;
            }
        }

        public static void PlayJomitaSound()
        {
            PlaySound(Resources.Jomita);
        }
        private static void PlaySound(Stream stream)
        {
            try
            {
                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(stream);
                snd.Play();
            }
            catch (Exception ex)
            {
                //ignored
            }
        }

    }
}
