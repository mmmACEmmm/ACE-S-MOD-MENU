using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Monkey_Magic_Menu.Mods.visuals
{
    internal class negativeColor
{
    public static void NegativeColor()
    {
        PlayerPrefs.SetFloat("redValue", 0f);
        PlayerPrefs.SetFloat("greenValue", -2.1474836E+09f);
        PlayerPrefs.SetFloat("blueValue", 0f);
        GorillaTagger.Instance.UpdateColor(0f, -2.1474836E+09f, 0f);
        PlayerPrefs.Save();
        GorillaTagger.Instance.myVRRig.RPC("InitializeNoobMaterial", 0, new object[]
        {
        0,
        int.MinValue,
        0,
        false
        });
    }

}
}
