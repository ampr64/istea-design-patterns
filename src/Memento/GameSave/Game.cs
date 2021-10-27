using System;

namespace SaveGame
{
    public class Game
    {
        private int _saveCount;

        public string PlayerName { get; init; }

        public int CurrentHp { get; private set; } = 100;

        public Game(string playerName)
        {
            if (string.IsNullOrWhiteSpace(playerName)) throw new ArgumentException($"'{nameof(playerName)}' cannot be null or whitespace.", nameof(playerName));

            PlayerName = playerName;
        }

        public void TakeDamage(int hitPoints)
        {
            if (hitPoints < 0) throw new ArgumentException($"{nameof(hitPoints)} cannot be a negative value.");
            CurrentHp = hitPoints > CurrentHp ? 0 : CurrentHp - hitPoints;
        }

        public GameSave SaveProgress()
        {
            if (!CanSave())
            {
                Console.WriteLine("Game cannot be saved more than three times!");
                return null;
            }
            
            _saveCount += 1;
            return new GameSave(this);
        }

        private bool CanSave() => _saveCount < 3;

        public override string ToString() => $"Player name: {PlayerName} - HP: {CurrentHp} - Number of saves: {_saveCount}";
    }
}