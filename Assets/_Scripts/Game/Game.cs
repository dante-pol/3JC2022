using UnityEngine;

namespace Root.Assets._Scripts.Game
{
    public class Game : MonoBehaviour
    {
        [SerializeField] private GameLevelBuilder _levelBuilder;
        [SerializeField] private GUIManager _guiManager;
        
        private GameBackgroundController _gameBackground;

        private void Awake()
        {
            _gameBackground = new GameBackgroundController();

            _guiManager.Init();
            _levelBuilder.Init(_gameBackground);

            _levelBuilder.Build();
        }
    }
}
