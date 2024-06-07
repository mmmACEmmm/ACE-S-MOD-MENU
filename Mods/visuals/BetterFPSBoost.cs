using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Monkey_Magic_Menu.Mods.visuals
{
    internal class betterFPSBoost
{
    public static void BetterFPSBoost()
    {
        foreach (Renderer v in Resources.FindObjectsOfTypeAll<Renderer>())
        {
            try
            {
                if (v.material.shader.name == "GorillaTag/UberShader")
                {
                    Material replacement = new Material(Shader.Find("GorillaTag/UberShader"));
                    replacement.color = v.material.color;
                    v.material = replacement;
                }
            }
            catch (System.Exception exception) { UnityEngine.Debug.LogError(string.Format("mat error {1} - {0}", exception.Message, exception.StackTrace)); }
        }
    }

}
}
