using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Monkey_Magic_Menu.Mods.visuals
{

    internal class Hat
{
    public static void kkkHat()
    {
        GameObject gameObject = GameObject.CreatePrimitive(0);
        gameObject.transform.position = GorillaTagger.Instance.offlineVRRig.headMesh.transform.position;
        gameObject.transform.rotation = GorillaTagger.Instance.offlineVRRig.headMesh.transform.rotation;
        gameObject.transform.position += new Vector3(0f, 0.2f, 0f);
        gameObject.transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);
        Shader shader = Shader.Find("GorillaTag/UberShader");
        Material material = new Material(shader);
        gameObject.GetComponent<Renderer>().material = material;
        Collider component = gameObject.GetComponent<Collider>();
        bool flag = component != null;
        if (flag)
        {
            UnityEngine.Object.Destroy(component);
        }
        UnityEngine.Object.Destroy(gameObject, Time.deltaTime);
        GameObject gameObject2 = GameObject.CreatePrimitive(0);
        gameObject2.transform.position = GorillaTagger.Instance.offlineVRRig.headMesh.transform.position;
        gameObject2.transform.rotation = GorillaTagger.Instance.offlineVRRig.headMesh.transform.rotation;
        gameObject2.transform.position += new Vector3(0f, 0.27f, 0f);
        gameObject2.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
        Shader shader2 = Shader.Find("GorillaTag/UberShader");
        Material material2 = new Material(shader2);
        gameObject2.GetComponent<Renderer>().material = material2;
        Collider component2 = gameObject2.GetComponent<Collider>();
        bool flag2 = component != null;
        if (flag2)
        {
            UnityEngine.Object.Destroy(component2);
        }
        UnityEngine.Object.Destroy(gameObject2, Time.deltaTime);
        GameObject gameObject3 = GameObject.CreatePrimitive(0);
        gameObject3.transform.position = GorillaTagger.Instance.offlineVRRig.headMesh.transform.position;
        gameObject3.transform.rotation = GorillaTagger.Instance.offlineVRRig.headMesh.transform.rotation;
        gameObject3.transform.position += new Vector3(0f, 0.33f, 0f);
        gameObject3.transform.localScale = new Vector3(0.15f, 0.15f, 0.15f);
        Shader shader3 = Shader.Find("GorillaTag/UberShader");
        Material material3 = new Material(shader3);
        gameObject3.GetComponent<Renderer>().material = material3;
        Collider component3 = gameObject3.GetComponent<Collider>();
        bool flag3 = component != null;
        if (flag3)
        {
            UnityEngine.Object.Destroy(component3);
        }
        UnityEngine.Object.Destroy(gameObject3, Time.deltaTime);
    }

}
}
