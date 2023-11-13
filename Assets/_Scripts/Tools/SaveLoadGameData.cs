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
            string jsonString = JsonConvert.SerializeObject(game);

            PlayerPrefs.SetString(NAME_DATA, jsonString);
            PlayerPrefs.Save();
        }

        public static GameData Load()
        {
            if (!PlayerPrefs.HasKey(NAME_DATA))
            {
                var game = new GameData();
                string jsonString = JsonConvert.SerializeObject(game);

                PlayerPrefs.SetString(NAME_DATA, jsonString);
                PlayerPrefs.Save();
                return game;
            }

            string data = PlayerPrefs.GetString(NAME_DATA);

            GameData gameData = JsonConvert.DeserializeObject<GameData>(data);

            return gameData;
        }
    }
}
