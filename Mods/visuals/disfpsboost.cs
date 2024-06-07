using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Monkey_Magic_Menu.Mods.visuals
{
    internal class disfpsboost
    {
        public static void DisableFPSBoost()
        {
            QualitySettings.globalTextureMipmapLimit = 1;
        }
    }
}
