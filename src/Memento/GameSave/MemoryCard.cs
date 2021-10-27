namespace SaveGame
{
    public class MemoryCard
    {
        private GameSave _gameSave;

        public void PersistSave(GameSave gameSave) => _gameSave = gameSave;

        public GameSave GetSave() => _gameSave;
    }
}