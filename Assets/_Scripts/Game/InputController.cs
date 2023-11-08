using UnityEngine;

namespace Root.Assets._Scripts.Game
{
    public class InputController : MonoBehaviour
    {
        public static bool IsTouch => Input.touchCount > 0 ? true : false;
        public static Touch GetTouch => Input.GetTouch(0);
    }
}