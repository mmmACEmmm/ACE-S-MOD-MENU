using System;
using System.Collections.Generic;
using System.Text;
using Photon.Pun;
using UnityEngine;

namespace Monkey_Magic_Menu.Mods.visuals
{
    internal class boxESP
    {
        public static void BoxESP()
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
                        GameObject gameObject = GameObject.CreatePrimitive((PrimitiveType)3);
                        UnityEngine.Object.Destroy(gameObject.GetComponent<BoxCollider>());
                        UnityEngine.Object.Destroy(gameObject.GetComponent<Rigidbody>());
                        UnityEngine.Object.Destroy(gameObject, Time.deltaTime);
                        gameObject.transform.localScale = new Vector3(0.7f, 1.5f, 0.7f);
                        gameObject.transform.position = vrrig.transform.position;
                        Color color = new Color32(byte.MaxValue, 0, 0, 50);
                        Color color2 = new Color32(0, byte.MaxValue, 0, 50);
                        gameObject.GetComponent<Renderer>().material.shader = Shader.Find("GUI/Text Shader");
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
                            Color color3 = gradient.Evaluate(num);
                            color3.a = 0.75f;
                            gameObject.GetComponent<Renderer>().material.color = color3;
                        }
                        else
                        {
                            bool flag7 = vrrig.mainSkin.material.name.Contains("fected");
                            bool flag8 = flag7;
                            if (flag8)
                            {
                                color.a = 0.25f;
                                gameObject.GetComponent<Renderer>().material.color = Color.red;
                            }
                            else
                            {
                                color2.a = 0.25f;
                                gameObject.GetComponent<Renderer>().material.color = Color.green;
                            }
                        }
                    }
                }
            }
        }
    }
}

