using System;
using System.Collections.Generic;
using System.Text;

namespace Monkey_Magic_Menu
{
    internal class leftGrabSpeedBoost
    {
    public static void LeftGrabSpeedBoost()
    {
        if (ControllerInputPoller.instance.leftGrab)
        {
            GorillaLocomotion.Player.Instance.maxJumpSpeed = 9;
            GorillaLocomotion.Player.Instance.jumpMultiplier = 2;
        }
    }

}
}
