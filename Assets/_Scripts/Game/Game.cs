using UnityEngine;

namespace Root.Assets._Scripts.Game
{
    public class Game : MonoBehaviour
    {
        [SerializeField] GameLevelBuilder _levelBuilder;
        [SerializeField] GUIManager _guiManager;

        private void Awake()
        {
            _levelBuilder.Build();
            _guiManager.Init();
        }
    }
}
