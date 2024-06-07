using System;
using System.Collections.Generic;
using System.Text;
using Photon.Pun;

namespace Monkey_Magic_Menu.Mods.adavtages
{
    internal class Server_
    {
        public static void EUServers()
        {
            PhotonNetwork.ConnectToRegion("eu");
        }

        public static void USServers()
        {
            PhotonNetwork.ConnectToRegion("us");
        }

        public static void USWServers()
        {
            PhotonNetwork.ConnectToRegion("usw");
        }
    }
}
