using System;
using System.Collections.Generic;
using System.Text;
using StupidTemplate.Classes;

namespace StupidTemplate
{
    internal class nametag
    {
        public static void Nametag()
        {
            foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
            {
                bool flag = vrrig != GorillaTagger.Instance.offlineVRRig;
                if (flag)
                {
                    string text = string.Concat(new string[]
                    {
                        (vrrig.playerColor.r * 9f).ToString(),
                        ", ",
                        (vrrig.playerColor.g * 9f).ToString(),
                        ", ",
                        (vrrig.playerColor.b * 9f).ToString()
                    });
                    vrrig.playerText.resizeTextMaxSize = int.MaxValue;
                    vrrig.playerText.text = string.Concat(new string[]
                    {
                        RigManager.GetPlayerFromVRRig(vrrig).NickName,
                        "\n",
                        text,
                        "\nPlayer Token: ",
                        RigManager.GetPlayerFromVRRig(vrrig).UserId
                    });
                }
            }
        }
    }
}