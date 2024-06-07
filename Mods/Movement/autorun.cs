using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine.InputSystem;
using UnityEngine;

namespace Monkey_Magic_Menu.Mods.Movement
{
    internal class autorun
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

    public static void AutoRun()
    {
        bool left = false;
        bool right = false;

        if (!left && ControllerInputPoller.instance.rightGrab || !left && Mouse.current.rightButton.isPressed)
        {
            Vector3 runPosition = CalculatePreferredPosition();
            GorillaTagger.Instance.rightHandTransform.position = runPosition;
            right = true;
        }
        else { right = false; }

        if (!right && ControllerInputPoller.instance.leftGrab || !right && Mouse.current.leftButton.isPressed)
        {
            Vector3 runPosition = CalculatePreferredPosition();
            GorillaTagger.Instance.leftHandTransform.position = runPosition;
            left = true;
        }
        else { left = false; }
    }

}
}
