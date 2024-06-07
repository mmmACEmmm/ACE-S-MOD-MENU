using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Monkey_Magic_Menu.Mods.adavtages
{
    internal class wallwalk
    {
        public static void WallWalkMod()
        {
            RaycastHit raycastHit;
            Physics.Raycast(GorillaLocomotion.Player.Instance.rightControllerTransform.position, -GorillaLocomotion.Player.Instance.rightControllerTransform.right, out raycastHit, 100f, int.MaxValue);
            RaycastHit raycastHit2;
            Physics.Raycast(GorillaLocomotion.Player.Instance.leftControllerTransform.position, GorillaLocomotion.Player.Instance.leftControllerTransform.right, out raycastHit2, 100f, int.MaxValue);
            if (ControllerInputPoller.instance.rightGrab)
            {
                if (raycastHit.distance < raycastHit2.distance)
                {
                    if (raycastHit.distance < 1f)
                    {
                        Vector3 normalized = (raycastHit.point - GorillaLocomotion.Player.Instance.rightControllerTransform.position).normalized;
                        Physics.gravity = normalized * 9.81f;
                    }
                    else
                    {
                        Physics.gravity = new Vector3(0f, -9.81f, 0f);
                    }
                }
                if (raycastHit.distance == raycastHit2.distance)
                {
                    Physics.gravity = new Vector3(0f, -9.81f, 0f);
                }
            }
            else
            {
                Physics.gravity = new Vector3(0f, -9.81f, 0f);
            }
            if (ControllerInputPoller.instance.leftGrab)
            {
                if (raycastHit.distance > raycastHit2.distance)
                {
                    if (raycastHit2.distance < 1f)
                    {
                        Vector3 normalized2 = (raycastHit2.point - GorillaLocomotion.Player.Instance.leftControllerTransform.position).normalized;
                        Physics.gravity = normalized2 * 9.81f;
                    }
                    else
                    {
                        Physics.gravity = new Vector3(0f, -9.81f, 0f);
                    }
                }
                if (raycastHit.distance == raycastHit2.distance)
                {
                    Physics.gravity = new Vector3(0f, -9.81f, 0f);
                }
            }
            else
            {
                Physics.gravity = new Vector3(0f, -9.81f, 0f);
            }
        }

    }
}
