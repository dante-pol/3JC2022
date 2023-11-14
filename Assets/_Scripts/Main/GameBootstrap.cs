using Root.Assets._Scripts.Tools;
using UnityEngine;

namespace Root.Assets._Scripts.Main
{
    public class GameBootstrap : MonoBehaviour
    {
        public static GameBootstrap Instance { get; private set; } = null;
        
        public GameData GetGameData { get; private set; }

        public void Start()
        {
            if (IsInitGame()) return;

            Instance = this;
            DontDestroyOnLoad(gameObject);

            LoadGameData();

            LoadGame();
        }

        private bool IsInitGame()
            => Instance != null ? true : false;

        private void LoadGameData()
            => GetGameData = SaveLoadGameData.Load();

        private void LoadGame()
            => ScenesLoader.Load(IDScenes.GAME_SCENE);
    }
}
