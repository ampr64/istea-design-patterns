namespace SmartDevicesFactory.Decorator.Components
{
    public class SmartTelevision : Television, ISmart
    {
        public void PlayNetflix() => Play("Netflix");

        public void PlayYouTube() => Play("YouTube");
    }
}