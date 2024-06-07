using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace StupidTemplate.Mods
{
    internal class autoDance
    {
        public static void AutoDance()
        {
            float time = Time.time; // Using Time.time for smoother, continuous motion

            // Move right hand in a circular motion
            GorillaTagger.Instance.rightHandTransform.position = GorillaTagger.Instance.headCollider.transform.position +
                (GorillaTagger.Instance.headCollider.transform.forward * MathF.Cos(time) / 10) +
                new Vector3(0, -0.5f - (MathF.Sin(time) / 7), 0) +
                (GorillaTagger.Instance.headCollider.transform.right * 0.05f * MathF.Cos(time * 2));

            // Move left hand in a circular motion
            GorillaTagger.Instance.leftHandTransform.position = GorillaTagger.Instance.headCollider.transform.position +
                (GorillaTagger.Instance.headCollider.transform.forward * MathF.Cos(time + 180) / 10) +
                new Vector3(0, -0.5f - (MathF.Sin(time + 180) / 7), 0) +
                (GorillaTagger.Instance.headCollider.transform.right * -0.05f * MathF.Cos(time * 2));
        }
    }
}
