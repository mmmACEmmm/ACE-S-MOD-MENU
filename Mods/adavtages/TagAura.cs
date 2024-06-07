using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Monkey_Magic_Menu.Mods.adavtages
{
    internal class changeTagAuraRange
    {
        private static int tagAuraIndex = 0;
        private static float tagAuraDistance = 0.777f;

        public static void ChangeTagAuraRange()
        {
            tagAuraIndex++;
            if (tagAuraIndex > 3)
            {
                tagAuraIndex = 0;
            }
            string[] names = new string[]
            {
                "Short",
                "Normal",
                "Far",
                "Maximum"
            };
            float[] distances = new float[]
            {
                0.777f,
                1.666f,
                3f,
                5f
            };

            tagAuraDistance = distances[tagAuraIndex];
            // Assuming GetIndex and overlapText are from another class, adjust accordingly
            // GetIndex("ctaRange").overlapText = "Change Tag Aura Distance <color=grey>[</color><color=green>" + names[tagAuraIndex] + "</color><color=grey>]</color>";
        }

        internal class physicalTagAura
        {
            public static void PhysicalTagAura()
            {
                foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
                {
                    Vector3 they = vrrig.headMesh.transform.position;
                    Vector3 notthem = GorillaTagger.Instance.offlineVRRig.head.rigTarget.position;
                    float distance = Vector3.Distance(they, notthem);

                    // Assuming rightHand is a boolean variable
                    bool rightHand = true; // Example initialization
                    if (GorillaTagger.Instance.offlineVRRig.mainSkin.material.name.Contains("fected") && !vrrig.mainSkin.material.name.Contains("fected") && GorillaLocomotion.Player.Instance.disableMovement == false && distance < tagAuraDistance)
                    {
                        // Assuming rightControllerTransform and leftControllerTransform are from Player.Instance
                        if (rightHand == true) { GorillaLocomotion.Player.Instance.rightControllerTransform.position = they; } else { GorillaLocomotion.Player.Instance.leftControllerTransform.position = they; }
                    }
                }
            }
        }
    }
}
