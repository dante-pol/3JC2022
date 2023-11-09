using Root.Assets._Scripts.Main;
using System;
using UnityEngine;

namespace Root.Assets._Scripts.GUI
{
    public class GUIManager : MonoBehaviour
    {
        private UIGameProgress _gameProgress;

        public void Init(GameData getGameData)
        {
            _gameProgress = GetComponentInChildren<UIGameProgress>();
            _gameProgress.Init(getGameData);
        }
    }
}