using UnityEngine;

namespace Root.Assets._Scripts.Game
{
    public class GameBackgroundController
    {
        public Color[] _colors = { 
            new Color(254, 250, 224),
            new Color(250, 237, 205), 
            new Color(233, 237, 281), 
            new Color(255, 200, 221),
            new Color(205, 180, 219),
            new Color(189, 224, 254), 
            new Color(227, 213, 202),
            new Color(237, 237, 233),
            new Color(212, 163, 115),
            new Color(219, 231, 228),
        };

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
