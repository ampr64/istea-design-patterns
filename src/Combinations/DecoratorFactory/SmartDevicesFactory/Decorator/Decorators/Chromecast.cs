using SmartDevicesFactory.Decorator.Components;
using System;

namespace SmartDevicesFactory.Decorator.Decorators
{
    public class Chromecast : ISmart
    {
        private RegularTelevision _tv;

        public Chromecast()
        {
        }

        public Chromecast(RegularTelevision tv) => _tv = tv;

        public void PlugInto(RegularTelevision tv) => _tv = tv;

        public void Unplug() => _tv = null;

        public void PlayNetflix()
        {
            if (CanPlay())
                Console.WriteLine($"Chromecast is now playing Netflix on {_tv.GetType()}.");
        }

        public void PlayYouTube()
        {
            if (CanPlay())
                Console.WriteLine($"Chromecast is now playing YouTube on {_tv.GetType()}.");
        }

        public void PlayTv()
        {
            if (CanPlay())
                _tv.PlayTv();
        }

        public bool CanPlay()
        {
            if (_tv is null)
            {
                Console.WriteLine("Chromecast is not connected to a TV.");
                return false;
            }
            if (!_tv.IsOn)
            {
                Console.WriteLine("TV needs to be on to use Chromecast.");
                return false;
            }

            return true;
        }
    }
}