using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Monkey_Magic_Menu.Mods.adavtages
{

    internal class fly
{
    public static void Fly()
    {
        if (ControllerInputPoller.instance.rightControllerPrimaryButton)
        {
            GorillaLocomotion.Player.Instance.transform.position += GorillaTagger.Instance.headCollider.transform.forward * Time.deltaTime * 10;
            GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }
}
}
