using System.Text.Json;

namespace SaveGame
{
    public class GameSave
    {
        private readonly Game _state;

        public GameSave(Game state) => _state = JsonSerializer.Deserialize<Game>(JsonSerializer.Serialize(state));

        public Game Restore() => JsonSerializer.Deserialize<Game>(JsonSerializer.Serialize(_state));
    }
}