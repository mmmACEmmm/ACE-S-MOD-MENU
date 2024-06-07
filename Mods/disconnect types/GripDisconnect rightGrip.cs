using System;
using System.Collections.Generic;
using System.Text;
using Photon.Pun;

namespace StupidTemplate.Mods
{
    internal class gripDisconnectrightGrip
    {
        public static void GripDisconnectrightGrip()
        {
            if (ControllerInputPoller.instance.rightGrab)
            {
                PhotonNetwork.Disconnect();
            }
        }
    }
}
