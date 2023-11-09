using UnityEngine;

namespace Root.Assets._Scripts.Game
{
    public class GameBackgroundController
    {
        public Color[] _colors = { Color.yellow, Color.red, Color.blue, Color.grey};

        private Camera _camera;
        private int _previousIndex;

        public GameBackgroundController()
        {
            _camera = Camera.main;
            _previousIndex = -1;
        }

        public void ChangeBackground()
        {
            int index = DefineColor();

            _camera.backgroundColor = _colors[index];

            _previousIndex = index;
        }

        private int DefineColor()
        {
            int index;

            do index = Random.Range(0, _colors.Length);
            while (index == _previousIndex);

            return index;
        }
    }
}
