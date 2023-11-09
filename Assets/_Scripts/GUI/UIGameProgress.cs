using Root.Assets._Scripts.Main;
using UnityEngine;
using UnityEngine.UI;

namespace Root.Assets._Scripts.GUI
{
    public class UIGameProgress : MonoBehaviour
    {
        private const int STEP = 1;
        
        [SerializeField] private Text _txtNextLevel;
        [SerializeField] private Text _txtCurrentLevel;
        [SerializeField] private Image _imgHolder;

        private GameData _gameData;

        public void Init(GameData gameData)
        {
            _gameData = gameData;
        }

        public void UpdateGameProgress()
        {
            _txtCurrentLevel.text = _gameData.CurrentLevel.ToString();
            _txtNextLevel.text = (_gameData.CurrentLevel + STEP).ToString();
        }

        public void UpdatePlaceHolder(float value)
        {
            if (value <= 0)
                _imgHolder.fillAmount = 0;
            else if (value >= 1)
                _imgHolder.fillAmount = 1;
            else
                _imgHolder.fillAmount = value;
        }
    }
}
