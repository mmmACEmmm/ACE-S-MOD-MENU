using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Monkey_Magic_Menu.Mods.Movement
{
    internal class joystickFly
{
    public static void JoystickFly()
    {
        Vector2 joy = ControllerInputPoller.instance.rightControllerPrimary2DAxis;

        if (Mathf.Abs(joy.x) > 0.3 || Mathf.Abs(joy.y) > 0.3)
        {
            GorillaLocomotion.Player.Instance.transform.position += (GorillaTagger.Instance.headCollider.transform.forward * Time.deltaTime * (joy.y * 10)) + (GorillaTagger.Instance.headCollider.transform.right * Time.deltaTime * (joy.x * 10));
            GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }
}
}
