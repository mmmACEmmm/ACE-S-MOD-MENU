using System;
using System.Collections.Generic;
using System.Text;

namespace Monkey_Magic_Menu.Mods.visuals
{
    internal class daytime
    {

        public static void DayTime()
        {
            BetterDayNightManager.instance.SetTimeOfDay(1);
        }

    }
}
