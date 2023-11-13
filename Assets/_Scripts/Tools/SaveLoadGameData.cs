using Newtonsoft.Json;
using Root.Assets._Scripts.Game;
using Root.Assets._Scripts.Main;
using UnityEngine;

namespace Root.Assets._Scripts.Tools
{
    public static class SaveLoadGameData
    {
        private const string NAME_DATA = "level";

        public static void Save(GameData game)
        {
            PlayerPrefs.SetInt(NAME_DATA, game.CurrentLevel);
            PlayerPrefs.Save();
        }

        public static GameData Load()
        {
            int level = 0;
            if (PlayerPrefs.HasKey(NAME_DATA))
                level = PlayerPrefs.GetInt(NAME_DATA);
            return new GameData(level);
        }
    }
}
