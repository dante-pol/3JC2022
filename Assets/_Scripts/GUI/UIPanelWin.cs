using Root.Assets._Scripts.Tools;
using UnityEngine;
using UnityEngine.UI;

namespace Root.Assets._Scripts.GUI
{
    public class UIPanelWin : MonoBehaviour
    {
        [SerializeField] private Button _btn_Next;

        private void OnEnable()
        {
            _btn_Next.onClick.AddListener(() =>
            {
                ScenesLoader.Load(IDScenes.GAME_SCENE);
            });
        }

        private void OnDisable()
        {
            _btn_Next.onClick.RemoveAllListeners();
        }
    }
}