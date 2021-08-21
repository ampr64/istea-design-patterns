using PlugAdapter.Concrete;

namespace PlugAdapter.Adapter
{
    public class PlugToMiniPlugAdapter : MiniPlug
    {
        private readonly SoundCard soundCard;

        public PlugToMiniPlugAdapter(SoundCard soundCard) => this.soundCard = soundCard ?? throw new System.ArgumentNullException(nameof(soundCard));

        public new int Frequency => soundCard.Frequency / 2;
    }
}