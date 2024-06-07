using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Monkey_Magic_Menu.Mods.Overpowered
{
    internal class DisableNetworkTriggers
    {
        public static void disableNetworkTriggers()
        {

            GameObject.Find("JoinRoomTriggers_Prefab").SetActive(false);

        }
    }
}