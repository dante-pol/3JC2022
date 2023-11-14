using Root.Assets._Scripts.Tools;
using UnityEngine;
using UnityEngine.UI;

namespace Root.Assets._Scripts.GUI
{
    public class UIPanelLoss : MonoBehaviour
    {
        [SerializeField] private Button _btn_Restart;

        private void OnEnable()
        {
            _btn_Restart.onClick.AddListener(() =>
            {
                ScenesLoader.Load(IDScenes.GAME_SCENE);
            });
        }

        private void OnDisable()
        {
            _btn_Restart.onClick.RemoveAllListeners();
        }
    }
}