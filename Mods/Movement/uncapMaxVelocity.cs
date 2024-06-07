using System;
using System.Collections.Generic;
using System.Text;

namespace Monkey_Magic_Menu.Mods.Movement
{
    internal class uncapMaxVelocity
{
    public static void UncapMaxVelocity()
    {
        GorillaLocomotion.Player.Instance.maxJumpSpeed = 99999f;
    }
}
}
