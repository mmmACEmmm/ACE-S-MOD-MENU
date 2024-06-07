using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Monkey_Magic_Menu.Mods.visuals
{
    internal class makeEveryoneRGB
{
    public static void MakeEveryoneRGB()
    {
        float time = Time.time;
        float num = Mathf.Sin(time * 2f) * 0.5f + 0.5f;
        float num2 = Mathf.Sin(time * 1.5f) * 0.5f + 0.5f;
        float num3 = Mathf.Sin(time * 2.5f) * 0.5f + 0.5f;
        foreach (VRRig vrrig in (VRRig[])UnityEngine.Object.FindObjectsOfType(typeof(VRRig)))
        {
            vrrig.mainSkin.material.color = new Color(num, num2, num3);
        }
    }

}
}
