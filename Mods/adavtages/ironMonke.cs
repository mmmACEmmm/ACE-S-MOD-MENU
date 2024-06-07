using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Monkey_Magic_Menu.Mods.adavtages
{
    internal class ironMonke
    {
        public static void IronMonke()
        {
            if (ControllerInputPoller.instance.rightGrab)
            {
                GorillaTagger.Instance.offlineVRRig.PlayHandTapLocal(115, false, 0.1f);
                GorillaTagger.Instance.StartVibration(false, GorillaTagger.Instance.tapHapticStrength / 10f, GorillaTagger.Instance.tapHapticDuration);
                GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().AddForce(new Vector3(15f * GorillaLocomotion.Player.Instance.rightControllerTransform.right.x, 15f * GorillaLocomotion.Player.Instance.rightControllerTransform.right.y, 15f * GorillaLocomotion.Player.Instance.rightControllerTransform.right.z), ForceMode.Acceleration);
            }
            if (ControllerInputPoller.instance.leftGrab)
            {
                GorillaTagger.Instance.offlineVRRig.PlayHandTapLocal(115, true, 0.1f);
                GorillaTagger.Instance.StartVibration(true, GorillaTagger.Instance.tapHapticStrength / 10f, GorillaTagger.Instance.tapHapticDuration);
                GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().AddForce(new Vector3(15f * GorillaLocomotion.Player.Instance.leftControllerTransform.right.x * -1f, 15f * GorillaLocomotion.Player.Instance.leftControllerTransform.right.y * -1f, 15f * GorillaLocomotion.Player.Instance.leftControllerTransform.right.z * -1f), ForceMode.Acceleration);
            }
        }

    }
}
