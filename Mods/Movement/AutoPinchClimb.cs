using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace StupidTemplate.Mods
{
    internal class autoPinchClimb
{
    public static void AutoPinchClimb()
    {
        if (ControllerInputPoller.instance.rightGrab)
        {
            float time = Time.frameCount / 3f;
            GorillaTagger.Instance.rightHandTransform.position = GorillaTagger.Instance.headCollider.transform.position + (GorillaTagger.Instance.headCollider.transform.right * (0.4f + (MathF.Cos(time) * 0.4f))) + (GorillaTagger.Instance.headCollider.transform.up * (MathF.Sin(time) * 0.6f)) + (GorillaTagger.Instance.headCollider.transform.forward * 0.75f);
            GorillaTagger.Instance.leftHandTransform.position = GorillaTagger.Instance.headCollider.transform.position + (GorillaTagger.Instance.headCollider.transform.right * -(0.4f + (MathF.Cos(time) * 0.4f))) + (GorillaTagger.Instance.headCollider.transform.up * (MathF.Sin(time) * 0.6f)) + (GorillaTagger.Instance.headCollider.transform.forward * 0.75f);
        }
    }

}
}
