using Root.Assets._Scripts.GUI;
using Root.Assets._Scripts.Main;
using Root.Assets._Scripts.Tools;
using UnityEngine;

namespace Root.Assets._Scripts.Game.Gameplay
{
    public class GameWin : MonoBehaviour
    {
        private GUIManager _guiManager;
        private GameData _gameData;

        public void Init(GameData gameData, GUIManager gUIManager)
        {
            _guiManager = gUIManager;
            _gameData = gameData;
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                ActiveWin();
                ConfigGame();
            }
        }

        private void ActiveWin()
        {
            InputSystem.IsPlay = false;
            _guiManager.SetActivePanelWin(true);
        }

        private void ConfigGame()
        {
            _gameData.IncreaseLevel();
            SaveLoadGameData.Save(_gameData);
        }
    }
}
