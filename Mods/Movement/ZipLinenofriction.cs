using GorillaLocomotion.Gameplay;
using System;
using System.Collections.Generic;
using System.Text;

namespace Monkey_Magic_Menu.Mods.Movement
{
    internal class zipLinenofriction
    {
        public static void ZipLinenofriction()
        {
            GorillaZiplineSettings[] array = UnityEngine.Object.FindObjectsOfType<GorillaZiplineSettings>();
            GorillaZipline[] array2 = UnityEngine.Object.FindObjectsOfType<GorillaZipline>();
            foreach (GorillaZiplineSettings gorillaZiplineSettings in array)
            {
                gorillaZiplineSettings.minSlidePitch = 50f;
                gorillaZiplineSettings.maxSlidePitch = 50f;
                gorillaZiplineSettings.maxSlideVolume = 50f;
                gorillaZiplineSettings.maxSpeed = 100f;
                gorillaZiplineSettings.gravityMulti = 50f;
                gorillaZiplineSettings.friction = 0f;
                gorillaZiplineSettings.maxFriction = 0f;
                gorillaZiplineSettings.maxFrictionSpeed = 0f;
            }
        }
    }
}