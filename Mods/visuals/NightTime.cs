using System;
using System.Collections.Generic;
using System.Text;

namespace Monkey_Magic_Menu.Mods.visuals
{
    internal class nightTime
    {
        public static void NightTime()
        {
            BetterDayNightManager.instance.SetTimeOfDay(0);
        }

    }
}
