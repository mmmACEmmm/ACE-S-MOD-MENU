using System;
using System.Collections.Generic;
using System.Text;
using Photon.Pun;

namespace StupidTemplate.Mods
{
    internal class leftControllerSecondary
    {
        public static void LeftControllerSecondary()
        {
            if (ControllerInputPoller.instance.leftControllerSecondaryButton)
            {
                PhotonNetwork.Disconnect();
            }
        }
    }
}
