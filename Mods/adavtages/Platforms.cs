using UnityEngine;
using UnityEngine.InputSystem;

namespace Monkey_Magic_Menu.Mods.adavtages
{
    internal class Platforms //ACE's
    {
        public static GameObject rplat;
        public static GameObject lplat;
        public static GameObject platformsL;
        public static GameObject platformsR;
        public static bool rplatEnabled = false;
        public static bool lplatEnabled = false;

        public static bool sticky = false;

        public static int platChanger = 1;
        public static float yOffset = -0.05f; // Adjust this value to change the spawn height

        public static void Plattys(Color platformColor)
        {
            if (ControllerInputPoller.instance.rightGrab || Mouse.current.rightButton.isPressed)
            {
                if (!rplatEnabled)
                {
                    rplat = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    rplat.GetComponent<Renderer>().material.color = platformColor;
                    rplat.transform.position = GorillaLocomotion.Player.Instance.rightControllerTransform.position + Vector3.up * yOffset;
                    rplat.transform.rotation = GorillaLocomotion.Player.Instance.rightControllerTransform.rotation;
                    rplat.transform.localScale = new Vector3(0.01f, 0.25f, 0.25f);
                    platformsR = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    platformsR.GetComponent<Renderer>().material.color = platformColor;
                    platformsR.transform.localPosition = rplat.transform.localPosition;
                    platformsR.transform.localRotation = rplat.transform.localRotation;
                    platformsR.transform.localScale = new Vector3(0.009f, 0.26f, 0.26f);
                    rplatEnabled = true;
                }
            }
            if (ControllerInputPoller.instance.leftGrab || Mouse.current.leftButton.isPressed)
            {
                if (!lplatEnabled)
                {
                    lplat = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    lplat.GetComponent<Renderer>().material.color = platformColor;
                    lplat.transform.position = GorillaLocomotion.Player.Instance.leftControllerTransform.position + Vector3.up * yOffset;
                    lplat.transform.rotation = GorillaLocomotion.Player.Instance.leftControllerTransform.rotation;
                    lplat.transform.localScale = new Vector3(0.01f, 0.25f, 0.25f);
                    platformsL = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    platformsL.GetComponent<Renderer>().material.color = platformColor;
                    platformsL.transform.position = lplat.transform.position;
                    platformsL.transform.rotation = lplat.transform.rotation;
                    platformsL.transform.localScale = new Vector3(0.009f, 0.26f, 0.26f);
                    lplatEnabled = true;
                }
            }
            if (!ControllerInputPoller.instance.rightGrab)
            {
                if (rplatEnabled)
                {
                    GameObject.Destroy(rplat);
                    GameObject.Destroy(platformsR);
                    rplatEnabled = false;
                }
            }
            if (!ControllerInputPoller.instance.leftGrab)
            {
                if (lplatEnabled)
                {
                    GameObject.Destroy(lplat);
                    GameObject.Destroy(platformsL);
                    lplatEnabled = false;
                }
            }
        }
    }
}
