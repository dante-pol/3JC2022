using UnityEngine;

namespace Root.Assets._Scripts.Tools
{
    public class ScreenCust : MonoBehaviour
    {
        private int _count;

        private void Update()
        {
            if (Input.GetMouseButtonDown(1))
                Cust();
        }

        private void Cust()
            => ScreenCapture.CaptureScreenshot($"img_{_count++}.png");
    }
}
