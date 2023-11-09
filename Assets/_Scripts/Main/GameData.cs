using System;

namespace Root.Assets._Scripts.Main
{
    [Serializable]
    public struct GameData
    {
        public int CurrentLevel => _currentLevel;

        private int _currentLevel;
    }
}
