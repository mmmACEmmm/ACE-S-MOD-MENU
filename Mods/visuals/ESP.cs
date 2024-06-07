using System;
using System.Collections.Generic;
using System.Text;
using Photon.Pun;
using UnityEngine;

namespace Monkey_Magic_Menu.Mods.visuals
{
    internal class ESP
    {
        public static void esp()
        {
            bool flag = PhotonNetwork.InRoom || PhotonNetwork.InLobby;
            bool flag2 = flag;
            if (flag2)
            {
                foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
                {
                    bool flag3 = vrrig != GorillaTagger.Instance.offlineVRRig;
                    bool flag4 = flag3;
                    if (flag4)
                    {
                        bool flag5 = true;
                        bool flag6 = flag5;
                        if (flag6)
                        {
                            GradientColorKey[] array = new GradientColorKey[3];
                            array[0].color = new Color32(101, 3, 56, 1);
                            array[0].time = 0f;
                            array[1].color = new Color32(99, 179, 166, 1);
                            array[1].time = 0.5f;
                            array[2].color = new Color32(101, 3, 56, 1);
                            array[2].time = 1f;
                            Gradient gradient = new Gradient();
                            gradient.colorKeys = array;
                            float num = Mathf.PingPong(Time.time / 2f, 1f);
                            Color color = gradient.Evaluate(num);
                            color.a = 0.25f;
                            vrrig.mainSkin.material.color = color;
                            vrrig.mainSkin.material.shader = Shader.Find("GUI/Text Shader");
                        }
                        else
                        {
                            bool flag7 = vrrig.mainSkin.material.name.Contains("fected");
                            bool flag8 = flag7;
                            if (flag8)
                            {
                                vrrig.mainSkin.material.color = new Color32(byte.MaxValue, 25, 1, 100);
                                vrrig.mainSkin.material.shader = Shader.Find("GUI/Text Shader");
                            }
                            else
                            {
                                vrrig.mainSkin.material.color = new Color32(25, byte.MaxValue, 1, 100);
                                vrrig.mainSkin.material.shader = Shader.Find("GUI/Text Shader");
                            }
                        }
                    }
                }
            }
        }
    }
}


