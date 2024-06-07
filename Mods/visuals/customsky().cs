using System;
using UnityEngine;

namespace StupidTemplate.Mods
{

    internal class Custom_Sky
    {
        public static void CustomSky()
        {
            Material material = new Material(Shader.Find("GorillaTag/UberShader"));
            material.color = Color.Lerp(Custom_Sky.pink, Custom_Sky.deepPink, Mathf.PingPong(Time.time, 0.5f));
            GameObject.Find("Environment Objects/LocalObjects_Prefab/Standard Sky/newsky (1)").GetComponent<Renderer>().material = material;
            GameObject.Find("Environment Objects/LocalObjects_Prefab/Standard Sky").GetComponent<Renderer>().material = material;
        }

        private Renderer _renderer;

        public static Color pink = new Color(1f, 0.75f, 0.8f);

        public static Color deepPink = new Color(0.976f, 0.725f, 0.945f);
    }
}
