using System;
using System.Collections.Generic;
using System.Text;
using Photon.Pun;

namespace StupidTemplate.Mods
{
    internal class gripDisconnectleftGrip
    {
        public static void GripDisconnestleftGrip()
        {
            if (ControllerInputPoller.instance.leftGrab) // Changed to leftGrab
            {
                PhotonNetwork.Disconnect();
            }
        }
    }
}
