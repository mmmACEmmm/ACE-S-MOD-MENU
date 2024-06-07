using System;
using System.Collections.Generic;
using System.Text;
using Photon.Pun;

namespace StupidTemplate.Mods
{
    internal class rightControllerSecondary
    {
        public static void RightControllerSecondary()
        {
            if (ControllerInputPoller.instance.rightControllerSecondaryButton || ControllerInputPoller.instance.rightControllerSecondaryButton)
            {
                PhotonNetwork.Disconnect();
            }
        }
    }
}
