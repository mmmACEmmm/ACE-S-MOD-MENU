using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Monkey_Magic_Menu.Mods.Movement
{
    internal class fixwater
{
    public static void FixWater()
    {
        GameObject water = GameObject.Find("Environment Objects/LocalObjects_Prefab/Beach/B_WaterVolumes");
        Transform waterTransform = water.transform;
        for (int i = 0; i < waterTransform.childCount; i++)
        {
            GameObject v = waterTransform.GetChild(i).gameObject;
            v.layer = LayerMask.NameToLayer("Water");
        }
    }
}
}
