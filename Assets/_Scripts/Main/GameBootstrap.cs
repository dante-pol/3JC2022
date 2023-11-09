using Root._Scripts.Tools;
using Root.Assets._Scripts.Tools;
using System;
using UnityEngine;

namespace Root.Assets._Scripts.Main
{
    public class GameBootstrap : MonoBehaviour
    {
        public static GameBootstrap Instance { get; private set; }
        
        public GameData GetGameData { get; private set; }

        public void Start()
        {
            if (IsInitGame()) return;

            LoadGameData();

            LoadGame();
        }

        private void LoadGameData()
            => GetGameData = SaveLoadGameData.Load();

        private bool IsInitGame()
            => Instance != null ? true : Instance = this;

        private void LoadGame()
            => ScenesLoader.Load(IDScenes.GAME_SCENE);
    }
}
