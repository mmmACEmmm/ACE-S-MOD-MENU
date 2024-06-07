using System;
using System.Collections.Generic;
using System.Text;

namespace Monkey_Magic_Menu.Mods.Movement
{
    internal class MosaSpeed
    {
        public static void Mosaspeed()
        {
            GorillaLocomotion.Player.Instance.maxJumpSpeed = 8f;
            GorillaLocomotion.Player.Instance.jumpMultiplier = 2f;
        }
    }
}