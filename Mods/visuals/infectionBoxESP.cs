using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Monkey_Magic_Menu.Mods.visuals
{
    internal class infectionBoxESP
{
    public static void InfectionBoxESP()
    {
        bool flag = false;
        foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
        {
            bool flag2 = vrrig.mainSkin.material.name.Contains("fected");
            if (flag2)
            {
                flag = true;
                break;
            }
        }
        bool flag3 = flag;
        if (flag3)
        {
            bool flag4 = !GorillaTagger.Instance.offlineVRRig.mainSkin.material.name.Contains("fected");
            if (flag4)
            {
                foreach (VRRig vrrig2 in GorillaParent.instance.vrrigs)
                {
                    bool flag5 = vrrig2.mainSkin.material.name.Contains("fected") && vrrig2 != GorillaTagger.Instance.offlineVRRig;
                    if (flag5)
                    {
                        Color color = new Color32(byte.MaxValue, 111, 0, byte.MaxValue);
                        GameObject gameObject = GameObject.CreatePrimitive((PrimitiveType)3);
                        gameObject.transform.position = vrrig2.transform.position;
                        UnityEngine.Object.Destroy(gameObject.GetComponent<BoxCollider>());
                        gameObject.transform.localScale = new Vector3(0.5f, 0.5f, 0f);
                        gameObject.transform.LookAt(GorillaTagger.Instance.headCollider.transform.position);
                        gameObject.GetComponent<Renderer>().material.shader = Shader.Find("GUI/Text Shader");
                        gameObject.GetComponent<Renderer>().material.color = color;
                        UnityEngine.Object.Destroy(gameObject, Time.deltaTime);
                    }
                }
            }
            else
            {
                foreach (VRRig vrrig3 in GorillaParent.instance.vrrigs)
                {
                    bool flag6 = !vrrig3.mainSkin.material.name.Contains("fected") && vrrig3 != GorillaTagger.Instance.offlineVRRig;
                    if (flag6)
                    {
                        Color playerColor = vrrig3.playerColor;
                        GameObject gameObject2 = GameObject.CreatePrimitive((PrimitiveType)3);
                        gameObject2.transform.position = vrrig3.transform.position;
                        UnityEngine.Object.Destroy(gameObject2.GetComponent<BoxCollider>());
                        gameObject2.transform.localScale = new Vector3(0.5f, 0.5f, 0f);
                        gameObject2.transform.LookAt(GorillaTagger.Instance.headCollider.transform.position);
                        gameObject2.GetComponent<Renderer>().material.shader = Shader.Find("GUI/Text Shader");
                        gameObject2.GetComponent<Renderer>().material.color = playerColor;
                        UnityEngine.Object.Destroy(gameObject2, Time.deltaTime);
                    }
                }
            }
        }
        else
        {
            foreach (VRRig vrrig4 in GorillaParent.instance.vrrigs)
            {
                bool flag7 = vrrig4 != GorillaTagger.Instance.offlineVRRig;
                if (flag7)
                {
                    Color playerColor2 = vrrig4.playerColor;
                    GameObject gameObject3 = GameObject.CreatePrimitive((PrimitiveType)3);
                    gameObject3.transform.position = vrrig4.transform.position;
                    UnityEngine.Object.Destroy(gameObject3.GetComponent<BoxCollider>());
                    gameObject3.transform.localScale = new Vector3(0.5f, 0.5f, 0f);
                    gameObject3.transform.LookAt(GorillaTagger.Instance.headCollider.transform.position);
                    gameObject3.GetComponent<Renderer>().material.shader = Shader.Find("GUI/Text Shader");
                    gameObject3.GetComponent<Renderer>().material.color = playerColor2;
                    UnityEngine.Object.Destroy(gameObject3, Time.deltaTime);
                }
            }
        }
    }

}
}
