using Root.Assets._Scripts.Game.Gameplay;
using Root.Assets._Scripts.Main;
using UnityEngine;
using UnityEngine.UI;

namespace Root.Assets._Scripts.GUI
{
    public class GUIManager : MonoBehaviour
    {
        public UIGameProgress GameProgress => _gameProgress;
        private UIGameProgress _gameProgress;

        [SerializeField] private Button _btn_Play;

        public void Init(GameData getGameData)
        {
            _gameProgress = GetComponentInChildren<UIGameProgress>();
            _gameProgress.Init(getGameData);
        }

        private void OnEnable()
        {
            _btn_Play.onClick.AddListener(() => 
            { 
                InputSystem.IsPlay = true;
                _btn_Play.gameObject.SetActive(false);
            });
        }

        private void OnDisable()
        {
            _btn_Play.onClick.RemoveAllListeners();
        }
    }
}