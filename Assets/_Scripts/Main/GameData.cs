using System;

namespace Root.Assets._Scripts.Main
{
    [Serializable]
    public class GameData
    {
        public int CurrentLevel 
            => _currentLevel;

        private int _currentLevel;

        public GameData()
            => _currentLevel = 0;

        public void IncreaseLevel()
            => _currentLevel++;
    }
}
