using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Monkey_Magic_Menu.Mods.Movement
{
    internal class autoRun
{
    private static Vector3 CalculatePreferredPosition()
    {
        Transform headPosition = GorillaTagger.Instance.headCollider.transform;
        float xOffset = MathF.Cos(Time.frameCount);
        float yOffset = -0.5f - MathF.Sin(Time.frameCount);

        Vector3 newPosition = headPosition.position +
                              headPosition.forward * xOffset +
                              new Vector3(0, yOffset, 0);
        return newPosition;
    }
}
}
