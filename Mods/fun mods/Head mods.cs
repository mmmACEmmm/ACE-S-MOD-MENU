using System;
using GorillaLocomotion;

namespace StupidTemplate.Mods
{
    internal class HeadMod
    {
        internal class FixHead
        {
            public static void fixHead()
            {
                GorillaTagger.Instance.offlineVRRig.head.trackingRotationOffset.x = 0f;
                GorillaTagger.Instance.offlineVRRig.head.trackingRotationOffset.y = 0f;
                GorillaTagger.Instance.offlineVRRig.head.trackingRotationOffset.z = 0f;
            }
        }

        internal class UpsideDownHead
        {
            public static void upsideDownHead()
            {
                GorillaTagger.Instance.offlineVRRig.head.trackingRotationOffset.z = 180f;
            }
        }

        internal class BrokenNeck
        {
            public static void brokenNeck()
            {
                GorillaTagger.Instance.offlineVRRig.head.trackingRotationOffset.z = 90f;
            }
        }

        internal class BackwardsHead
        {
            public static void backwardsHead()
            {
                GorillaTagger.Instance.offlineVRRig.head.trackingRotationOffset.y = 180f;
            }
        }

        internal class SpinHeadX
        {
            public static void spinHeadX()
            {
                GorillaTagger.Instance.offlineVRRig.head.trackingRotationOffset.x += 10f;
            }
        }

        internal class SpinHeadY
        {
            public static void spinHeadY()
            {
                GorillaTagger.Instance.offlineVRRig.head.trackingRotationOffset.y += 10f;
            }
        }

        internal class SpinHeadZ
        {
            public static void spinHeadZ()
            {
                GorillaTagger.Instance.offlineVRRig.head.trackingRotationOffset.z += 10f;
            }
        }
    }
}
