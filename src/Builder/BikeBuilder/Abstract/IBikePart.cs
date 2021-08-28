using Utils.Extensions;

namespace BikeBuilder.Abstract
{
    public interface IBikePart
    {
        public string Name => GetType().Name.ToSentence();
    }
}