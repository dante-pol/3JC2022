using Root._Scripts.Tools;
using UnityEngine;

namespace Root.Assets._Scripts.Main
{
    public class GameBootstrap : MonoBehaviour
    {
        public void Start()
        {
            ScenesLoader.Load(IDScenes.GAME_SCENE);
        }
    }
}
