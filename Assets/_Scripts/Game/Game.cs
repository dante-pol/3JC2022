using Root._Scripts.Tools;
using Root.Assets._Scripts.GUI;
using Root.Assets._Scripts.Main;
using UnityEngine;

namespace Root.Assets._Scripts.Game
{
    public class Game : MonoBehaviour
    {
        [SerializeField] private GameLevelBuilder _levelBuilder;
        [SerializeField] private GUIManager _guiManager;

        private GameBootstrap _gameBootstrap;
        private GameBackgroundController _gameBackground;

        private void Awake()
        {
            if (!IsInitGame())
            {
                ScenesLoader.Load(IDScenes.INIT_SCENE);
                return;
            }

            InitGameplay();
            BuildGameplay();
        }

        private bool IsInitGame()
            => (_gameBootstrap = GameBootstrap.Instance) != null ? true : false;

        private void InitGameplay()
        {
            _gameBackground = new GameBackgroundController();

            _guiManager.Init(_gameBootstrap.GetGameData);
            _levelBuilder.Init(_gameBackground);
        }

        private void BuildGameplay()
            => _levelBuilder.Build();
    }
}
