
using System.Collections.Generic;
using System.Text;

namespace Monkey_Magic_Menu.Mods.adavtages
{
    internal class modmenuprotector
    {
        public static void Modmenuprotector()
    {
            if (ControllerInputPoller.instance.leftControllerSecondaryButton == true)
            {
                GorillaTagger.Instance.offlineVRRig.enabled = false;
            }
            else
            {
                GorillaTagger.Instance.offlineVRRig.enabled = true;
            }
        }
    }
}

