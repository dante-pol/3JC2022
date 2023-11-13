using Root.Assets._Scripts.Game;
using Root.Assets._Scripts.Game.Gameplay;
using Root.Assets._Scripts.Main;
using Root.Assets._Scripts.Player;
using UnityEngine;
using UnityEngine.UI;

namespace Root.Assets._Scripts.GUI
{
    public class GUIManager : MonoBehaviour
    {
        public UIGameProgress GameProgress => _gameProgress;
        [SerializeField] private UIGameProgress _gameProgress;

        public UIPanelWin PanelWin => _panelWin;
        [SerializeField] private UIPanelWin _panelWin;

        public UIPanelLoss PanelLoss => _panelLoss;
        [SerializeField] private UIPanelLoss _panelLoss;

        [SerializeField] private Button _btn_Play;

        public void Init(GameLevelBuilder gameLevelBuilder, GameData getGameData, Ball ball)
        {
            _gameProgress.Init(gameLevelBuilder, getGameData, ball);
        }

        private void OnEnable()
            => _btn_Play.onClick.AddListener(() =>
            {
                InputSystem.IsPlay = true;
                _btn_Play.gameObject.SetActive(false);
            });

        private void OnDisable()
            => _btn_Play.onClick.RemoveAllListeners();

        public void SetActivePanelWin(bool value)
            => _panelWin.gameObject.SetActive(value);

        public void SetActivePanelLoss(bool value)
            => _panelLoss.gameObject.SetActive(value);
    }
}