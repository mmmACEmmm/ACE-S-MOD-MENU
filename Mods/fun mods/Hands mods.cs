using System;
using GorillaLocomotion;
using UnityEngine;

namespace StupidTemplate.Mods
{
    internal class HandMod
    {
        internal class FlipHands
        {
            public static void flipHands()
            {
                Vector3 lh = GorillaTagger.Instance.leftHandTransform.position;
                Vector3 rh = GorillaTagger.Instance.rightHandTransform.position;
                Quaternion lhr = GorillaTagger.Instance.leftHandTransform.rotation;
                Quaternion rhr = GorillaTagger.Instance.rightHandTransform.rotation;

                GorillaLocomotion.Player.Instance.rightControllerTransform.transform.position = lh;
                GorillaLocomotion.Player.Instance.leftControllerTransform.transform.position = rh;

                GorillaLocomotion.Player.Instance.rightControllerTransform.transform.rotation = lhr;
                GorillaLocomotion.Player.Instance.leftControllerTransform.transform.rotation = rhr;
            }
        }

        internal class FixHandTaps
        {
            public static void fixHandTaps()
            {
                GorillaTagger.Instance.handTapVolume = 0.1f;
            }
        }

        internal class LoudHandTaps
        {
            public static void loudHandTaps()
            {
                GorillaTagger.Instance.handTapVolume = int.MaxValue;
            }
        }

        internal class SilentHandTaps
        {
            public static void silentHandTaps()
            {
                GorillaTagger.Instance.handTapVolume = 0;
            }
        }

        internal class EnableInstantHandTaps
        {
            public static void enableInstantHandTaps()
            {
                GorillaTagger.Instance.tapCoolDown = 0f;
            }
        }

        internal class DisableInstantHandTaps
        {
            public static void disableInstantHandTaps()
            {
                GorillaTagger.Instance.tapCoolDown = 0.33f;
            }
        }
    }
}
