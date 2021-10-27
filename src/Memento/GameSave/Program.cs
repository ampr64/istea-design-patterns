namespace SaveGame
{
    class Program
    {
        static void Main()
        {
            var game = new Game("Alvaro");
            var memoryCard = new MemoryCard();

            memoryCard.PersistSave(game.SaveProgress());

            var restoredGame1 = memoryCard.GetSave().Restore();
            restoredGame1.TakeDamage(60);
            memoryCard.PersistSave(restoredGame1.SaveProgress());

            var restoredGame2 = memoryCard.GetSave().Restore();
            restoredGame2.TakeDamage(30);
        }
    }
}