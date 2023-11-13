using UnityEngine;

namespace Root.Assets._Scripts.Game.Gameplay
{
    public class InputSystem : MonoBehaviour
    {
        public static bool IsPlay { get; set; } = false;

        public static bool IsTouch => Input.touchCount > 0 ? true : false;
        public static Touch GetTouch => Input.GetTouch(0);
    }
}