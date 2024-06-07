using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Monkey_Magic_Menu.Mods.adavtages
{
    internal class TPGun
    {
        public static void Tpgun()
        {
            RaycastHit raycastHit;
            Physics.Raycast(GorillaLocomotion.Player.Instance.rightControllerTransform.transform.position, GorillaLocomotion.Player.Instance.rightControllerTransform.transform.forward, out raycastHit);
            GameObject gameObject = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            gameObject.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
            gameObject.transform.position = raycastHit.point;
            UnityEngine.Object.Destroy(gameObject.GetComponent<BoxCollider>());
            UnityEngine.Object.Destroy(gameObject.GetComponent<Rigidbody>());
            UnityEngine.Object.Destroy(gameObject.GetComponent<Collider>());
            UnityEngine.Object.Destroy(gameObject, Time.deltaTime);
            bool rightGrab = ControllerInputPoller.instance.rightGrab;
            if (rightGrab)
            {
                GorillaLocomotion.Player.Instance.transform.position = gameObject.transform.position;
                GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity = gameObject.transform.position;
            }
        }
    }
}