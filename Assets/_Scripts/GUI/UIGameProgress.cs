using Root.Assets._Scripts.Game;
using Root.Assets._Scripts.Main;
using Root.Assets._Scripts.Player;
using UnityEngine;
using UnityEngine.UI;

namespace Root.Assets._Scripts.GUI
{
    public class UIGameProgress : MonoBehaviour
    {
        [SerializeField] private Text _txtNextLevel;
        [SerializeField] private Text _txtCurrentLevel;
        [SerializeField] private Image _imgHolder;

        private const int LEVEL_STEP = 1;
        private float _holderStep;

        private GameData _gameData;

        public void Init(GameLevelBuilder gameLevelBuilder, GameData gameData, Ball ball)
        {
            _gameData = gameData;
            _holderStep = 1.0f / gameLevelBuilder.CountContainers;
            ball.OnPassing += UpdatePlaceHolder;
        }

        public void InitGUI()
        {
            UpdateGameProgress();
            _imgHolder.fillAmount = 0;
        }

        public void UpdateGameProgress()
        {
            _txtCurrentLevel.text = _gameData.CurrentLevel.ToString();
            _txtNextLevel.text = (_gameData.CurrentLevel + LEVEL_STEP).ToString();
        }

        public void UpdatePlaceHolder()
            => _imgHolder.fillAmount += _holderStep;
    }
}
