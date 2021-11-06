using SmartDevicesFactory.Decorator;
using SmartDevicesFactory.Decorator.Components;
using SmartDevicesFactory.Decorator.Decorators;
using SmartDevicesFactory.Factory;

namespace SmartDevicesFactory
{
    class Program
    {
        static void Main()
        {
            var tvFactory = new TelevisionFactory();
            var chromecastFactory = new ChromecastFactory();

            IDevice tvDevice = tvFactory.Create<RegularTelevision>();
            var smartTv = tvFactory.Create<SmartTelevision>();

            var chromecast = chromecastFactory.Create<Chromecast>();

            ((RegularTelevision)tvDevice).TurnOn();
            ((RegularTelevision)tvDevice).PlayTv();
            ((RegularTelevision)tvDevice).TurnOn();
            ((RegularTelevision)tvDevice).PlayTv();
            ((RegularTelevision)tvDevice).TurnOff();

            smartTv.TurnOff();
            smartTv.PlayTv();
            smartTv.PlayNetflix();
            smartTv.PlayYouTube();
            smartTv.TurnOn();
            smartTv.PlayTv();
            smartTv.PlayNetflix();
            smartTv.PlayYouTube();

            chromecast.PlayNetflix();
            chromecast.PlayYouTube();
            chromecast.PlayTv();

            ((RegularTelevision)tvDevice).TurnOff();

            chromecast.PlugInto((RegularTelevision)tvDevice);
            tvDevice = chromecast;
            ((ISmart)tvDevice).PlayNetflix();
            ((ISmart)tvDevice).PlayYouTube();
            ((Chromecast)tvDevice).PlayTv();


        }
    }
}