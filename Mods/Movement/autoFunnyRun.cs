using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace StupidTemplate.Mods
{

    internal class autoFunnyRun
{
    public static void AutoFunnyRun()
    {
        if (ControllerInputPoller.instance.rightGrab)
        {
            if (ControllerInputPoller.instance.leftGrab)
            {
                float time = Time.frameCount;
                GorillaTagger.Instance.rightHandTransform.position = GorillaTagger.Instance.headCollider.transform.position + (GorillaTagger.Instance.headCollider.transform.forward * MathF.Cos(time) / 10) + new Vector3(0, -0.5f - (MathF.Sin(time) / 7), 0) + (GorillaTagger.Instance.headCollider.transform.right * -0.05f);
                GorillaTagger.Instance.leftHandTransform.position = GorillaTagger.Instance.headCollider.transform.position + (GorillaTagger.Instance.headCollider.transform.forward * MathF.Cos(time + 180) / 10) + new Vector3(0, -0.5f - (MathF.Sin(time + 180) / 7), 0) + (GorillaTagger.Instance.headCollider.transform.right * 0.05f);
            }
            else
            {
                float time = Time.frameCount;
                GorillaTagger.Instance.rightHandTransform.position = GorillaTagger.Instance.headCollider.transform.position + (GorillaTagger.Instance.headCollider.transform.forward * MathF.Cos(time) / 10) + new Vector3(0, -0.5f - (MathF.Sin(time) / 7), 0);
            }
        }
    }
}
}
