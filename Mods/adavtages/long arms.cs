using System;
using System.Collections.Generic;
using System.Text;

namespace Monkey_Magic_Menu.Mods.adavtages
{
    internal class long_arms
    {
        public static void weirdlongArms()
        {
            GorillaLocomotion.Player.Instance.leftControllerTransform.transform.position = GorillaTagger.Instance.leftHandTransform.position + GorillaTagger.Instance.leftHandTransform.forward * 0.1f;
            GorillaLocomotion.Player.Instance.rightControllerTransform.transform.position = GorillaTagger.Instance.rightHandTransform.position + GorillaTagger.Instance.rightHandTransform.forward * 0.1f;
        }
    }
}
