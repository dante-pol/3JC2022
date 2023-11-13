using Root.Assets._Scripts.GUI;
using Root.Assets._Scripts.Player;

namespace Root.Assets._Scripts.Game.Gameplay
{
    public class GameLoss
    {
        private GUIManager _guiManager;
        private Ball _ball;

        public GameLoss(GUIManager gUIManager, Ball ball)
        {
            _guiManager = gUIManager;
            _ball = ball;

            _ball.OnDead += ActiveLoss;
        }

        public void ActiveLoss()
        {
            InputSystem.IsPlay = false;
            _guiManager.SetActivePanelLoss(true);
        }
    }
}
