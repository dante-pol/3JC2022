using Root._Scripts.Tools;
using Root.Assets._Scripts.Game.Gameplay;
using Root.Assets._Scripts.GUI;
using Root.Assets._Scripts.Main;
using Root.Assets._Scripts.Player;
using UnityEngine;

namespace Root.Assets._Scripts.Game
{
    public class Game : MonoBehaviour
    {
        [SerializeField] private GameLevelBuilder _levelBuilder;
        [SerializeField] private GUIManager _guiManager;
        [SerializeField] private GameWin _gameWin;
        [SerializeField] private Ball _ball;

        private GameBootstrap _gameBootstrap;
        private GameBackgroundController _gameBackground;
        private GameLoss _gameLoss;

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
            _levelBuilder.Init(_gameBackground, _guiManager);
            _gameWin.Init(_gameBootstrap.GetGameData, _guiManager);
            
            _gameLoss = new GameLoss(_guiManager, _ball);
        }

        private void BuildGameplay()
            => _levelBuilder.Build();
    }
}
