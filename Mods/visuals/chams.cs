using System;
using Photon.Pun;
using UnityEngine;

namespace Mods.visuals
{

    internal class chams
    {

        public static void Chams()
        {
            bool inRoom = PhotonNetwork.InRoom;
            if (inRoom)
            {
                bool flag = GorillaGameManager.instance.GameModeName().ToString().Contains("INFECTION");
                if (flag)
                {
                    bool flag2 = GorillaTagger.Instance.offlineVRRig.mainSkin.material.name.Contains("fected");
                    if (flag2)
                    {
                        foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
                        {
                            bool flag3 = vrrig != GorillaTagger.Instance.offlineVRRig;
                            if (flag3)
                            {
                                bool flag4 = vrrig.mainSkin.material.name.Contains("fected");
                                if (flag4)
                                {
                                    vrrig.mainSkin.material.shader = Shader.Find("GUI/Text Shader");
                                    vrrig.mainSkin.material.color = Color.Lerp(new Color(1f, 0f, 0f, 0.3f), new Color(1f, 0f, 0.4f, 0.3f), Mathf.PingPong(Time.time, 1f));
                                }
                                else
                                {
                                    bool flag5 = !vrrig.mainSkin.material.name.Contains("fected");
                                    if (flag5)
                                    {
                                        vrrig.mainSkin.material.shader = Shader.Find("GUI/Text Shader");
                                        vrrig.mainSkin.material.color = Color.Lerp(new Color(0f, 1f, 0f, 0.3f), new Color(0f, 1f, 0.7f, 0.3f), Mathf.PingPong(Time.time, 1f));
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        bool flag6 = !GorillaTagger.Instance.offlineVRRig.mainSkin.material.name.Contains("fected");
                        if (flag6)
                        {
                            foreach (VRRig vrrig2 in GorillaParent.instance.vrrigs)
                            {
                                bool flag7 = vrrig2 != GorillaTagger.Instance.offlineVRRig;
                                if (flag7)
                                {
                                    bool flag8 = vrrig2.mainSkin.material.name.Contains("fected");
                                    if (flag8)
                                    {
                                        vrrig2.mainSkin.material.shader = Shader.Find("GUI/Text Shader");
                                        vrrig2.mainSkin.material.color = Color.Lerp(new Color(1f, 0f, 0f, 0.3f), new Color(1f, 0f, 0.4f, 0.3f), Mathf.PingPong(Time.time, 1f));
                                    }
                                    else
                                    {
                                        bool flag9 = !vrrig2.mainSkin.material.name.Contains("fected");
                                        if (flag9)
                                        {
                                            vrrig2.mainSkin.material.shader = Shader.Find("GUI/Text Shader");
                                            vrrig2.mainSkin.material.color = Color.Lerp(new Color(0f, 1f, 0f, 0.3f), new Color(0f, 1f, 0.7f, 0.3f), Mathf.PingPong(Time.time, 1f));
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
