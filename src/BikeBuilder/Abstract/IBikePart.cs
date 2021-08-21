using BikeBuilder.ExtensionMethods;

namespace BikeBuilder.Abstract
{
    public interface IBikePart
    {
        public string Name => GetType().Name.ToSentence();
    }
}