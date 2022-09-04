using UnityEngine;

namespace Noran.Extension
{
    public class NoranExtensionInputController
    {
        private FloatingJoystick leftJoystick;
        private FloatingJoystick rightJoystick;
        private GameObject player;

        public NoranExtensionInputController(GameObject player, FloatingJoystick left, FloatingJoystick right)
        {
            this.player = player;
            leftJoystick = left;
            rightJoystick = right;
        }

        public void ChangePosition()
        {
            player.transform.position +=
                player.transform.forward * leftJoystick.Vertical * 5f * Time.deltaTime;
        }

        public void ChangeRotation()
        {
            player.transform.Rotate(new Vector3(0, rightJoystick.Horizontal, 0));
        }
    }
}
