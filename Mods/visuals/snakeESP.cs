using System;
using System.Collections.Generic;
using System.Text;
using Photon.Pun;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Monkey_Magic_Menu.Mods.visuals
{
    internal class snakeESP
{
    public static void SnakeESP()
    {
        bool flag = PhotonNetwork.InRoom || PhotonNetwork.InLobby;
        if (flag)
        {
            foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
            {
                bool flag2 = vrrig != GorillaTagger.Instance.offlineVRRig;
                if (flag2)
                {
                    GameObject gameObject = GameObject.CreatePrimitive(0);
                    gameObject.transform.localScale = new Vector3(0.095f, 0.095f, 0.095f);
                    gameObject.transform.position = vrrig.transform.position;
                    gameObject.transform.rotation = vrrig.transform.rotation;
                    Collider component = gameObject.GetComponent<Collider>();
                    bool flag3 = component != null;
                    if (flag3)
                    {
                        Object.Destroy(component);
                    }
                    Shader shader = Shader.Find("GUI/Text Shader");
                    Material material = new Material(shader);
                    gameObject.GetComponent<Renderer>().material = material;
                    float num = Mathf.PingPong(Time.time / 2f, 1f);
                    material.color = Color.Lerp(Color.magenta, Color.black, num);
                    Object.Destroy(gameObject, 0.5f);
                }
            }
        }
    }

}
}
