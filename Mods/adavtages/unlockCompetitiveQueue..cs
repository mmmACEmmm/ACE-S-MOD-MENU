using System;
using System.Collections.Generic;
using System.Text;
using GorillaNetworking;

namespace Monkey_Magic_Menu.Mods.adavtages
{
    internal class unlockCompetitiveQueue
    {
        public static void UnlockCompetitiveQueue()
        {
            GorillaComputer.instance.CompQueueUnlockButtonPress();
        }
    }
}
