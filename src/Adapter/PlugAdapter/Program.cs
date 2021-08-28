using PlugAdapter.Adapter;
using PlugAdapter.Concrete;

namespace PlugAdapter
{
    class Program
    {
        static void Main()
        {
            var miniPlug = new MiniPlug();
            var soundCard = new SoundCard();
            var adapter = new PlugToMiniPlugAdapter(soundCard);
            
            var headphones = new Headphones(miniPlug);
            headphones.PrintPlugInfo();

            headphones = new(adapter);
            headphones.PrintPlugInfo();
        }
    }
}