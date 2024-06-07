using System;
using System.Collections.Generic;
using System.Text;

namespace Monkey_Magic_Menu.Mods.visuals
{
    internal class MouthMovement
    {
        public static void DisableMouthMovement()
        {
            GorillaTagger.Instance.offlineVRRig.GetComponent<GorillaMouthFlap>().enabled = false;
        }

        public static void EnableMouthMovement()
        {
            GorillaTagger.Instance.offlineVRRig.GetComponent<GorillaMouthFlap>().enabled = true;
        }
    }
}
