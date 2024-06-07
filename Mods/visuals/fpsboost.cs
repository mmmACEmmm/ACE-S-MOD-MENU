using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Monkey_Magic_Menu.Mods.visuals
{
    internal class fpsboost
    {
        public static void EnableFPSBoost()
        {
            QualitySettings.globalTextureMipmapLimit = 99999;
        }
    }
}
