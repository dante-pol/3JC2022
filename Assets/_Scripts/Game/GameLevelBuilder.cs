using Root.Assets._Scripts.GUI;
using Root.Assets._Scripts.Player;
using Root.Assets._Scripts.Ring;
using UnityEngine;

namespace Root.Assets._Scripts.Game
{
    public class GameLevelBuilder : MonoBehaviour
    {
        #region DataGenerator
        [Header("Data generator")]
        [SerializeField][Range(1, 10)] private int _offsetBetweenContainers;
        [SerializeField][Range(5, 100)] private int _countContainers;
        public int OffsetBetweenContainers => _offsetBetweenContainers;
        public int CountContainers => _countContainers;
        #endregion

        #region DataRing
        [Header("Data ring")]
        [SerializeField][Range(800, 5000)] private float _explosionForce;
        [SerializeField][Range(2, 10)] private float _explosionRadius;
        #endregion

        [SerializeField] private RingContainer[] _ringContainersPrefabs;
        [SerializeField] private Ball _ball;
        [SerializeField] private Transform _parentContainer;
        
        private GameBackgroundController _gameBackground;
        private GUIManager _guiManager;

        public void Init(GameBackgroundController gameBackground, GUIManager guiManager)
        {
            _gameBackground = gameBackground;
            _guiManager = guiManager;
        }

        public void Build()
        {
            CreateGameZone();
            SetStyleZone();
            UpdateGUI();
        }

        private void CreateGameZone()
        {
            for (int i = 1; i <= _countContainers; i++)
            {
                var item = Instantiate(
                    _ringContainersPrefabs[Random.Range(0, _ringContainersPrefabs.Length)],
                    _parentContainer);

                item.Inisialization(_explosionForce, _explosionRadius);
                item.transform.position = new Vector3(0, i * _offsetBetweenContainers, 0);
            }
        }

        private void SetStyleZone()
        {
            _gameBackground.ChangeBackground();
        }

        private void UpdateGUI()
        {
            _guiManager.GameProgress.InitGUI();

            _guiManager.SetActivePanelWin(false);
            _guiManager.SetActivePanelLoss(false);
        }
    }
}