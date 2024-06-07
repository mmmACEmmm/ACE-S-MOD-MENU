using System;
using System.Collections.Generic;
using System.Text;
using Photon.Pun;
using UnityEngine;

namespace Monkey_Magic_Menu.Mods.visuals
{
    internal class ssigma
{
    public static void Sigma()
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
                    gameObject.transform.position = vrrig.transform.position;
                    gameObject.transform.rotation = vrrig.transform.rotation;
                    gameObject.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                    Shader shader = Shader.Find("GUI/Text Shader");
                    Material material = new Material(shader);
                    gameObject.GetComponent<Renderer>().material = material;
                    float num = Mathf.PingPong(Time.time / 1f, 0.9f);
                    material.color = Color.Lerp(Color.black, Color.yellow, num);
                    UnityEngine.Object.Destroy(gameObject, Time.deltaTime);
                }
            }
        }
    }

}
}
