using System;
using UnityEngine.SceneManagement;

namespace Root.Assets._Scripts.Tools
{
    public enum IDScenes { INIT_SCENE = 0, GAME_SCENE = 1}

    public static class ScenesLoader
    {
        public static void Load(IDScenes id, Action onLoaded= null)
        {
            SceneManager.LoadScene((int) id);
            onLoaded?.Invoke();
        }
    }
}
