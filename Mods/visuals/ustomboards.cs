using UnityEngine;
using UnityEngine.UI;

namespace Monkey_Magic_Menu.Mods.visuals
{
    internal class customboards // Corrected class name from "ustomboards" to "customboards"
    {
        public static void Customboards()
        {
            GameObject.Find("motdtext").GetComponent<Text>().text = "hi there my name is ace i am so cool";
            GameObject.Find("COC Text").GetComponent<Text>().text = "hi there my name is ace i am so cool";
            GameObject.Find("CodeOfConduct").GetComponent<Text>().text = "ACE'S MOD MENU";
            GameObject.Find("motd").GetComponent<Text>().text = "ACE'S MOD MENU";
            Material mat = new Material(Shader.Find("GorillaTag/UberShader"));
            mat.color = Color.Lerp(Color.black, Color.white, Mathf.PingPong(Time.time, 1f));
            GameObject.Find("Environment Objects/LocalObjects_Prefab/TreeRoom/TreeRoomInteractables/StaticUnlit/screen").GetComponent<Renderer>().material = mat;
            GameObject.Find("Environment Objects/LocalObjects_Prefab/TreeRoom/TreeRoomInteractables/StaticUnlit/motdscreen").GetComponent<Renderer>().material = mat;
            GameObject.Find("Environment Objects/LocalObjects_Prefab/Forest/Terrain/campgroundstructure/scoreboard/REMOVE board").GetComponent<Renderer>().material = mat;
            GameObject.Find("Environment Objects/LocalObjects_Prefab/TreeRoom/TreeRoomInteractables/Wall Monitors Screens/wallmonitorforest").GetComponent<Renderer>().material = mat;
            GameObject.Find("Environment Objects/LocalObjects_Prefab/TreeRoom/TreeRoomInteractables/Wall Monitors Screens/wallmonitorcave").GetComponent<Renderer>().material = mat;
            GameObject.Find("Environment Objects/LocalObjects_Prefab/TreeRoom/TreeRoomInteractables/Wall Monitors Screens/wallmonitorskyjungle").GetComponent<Renderer>().material = mat;
            GameObject.Find("Environment Objects/LocalObjects_Prefab/TreeRoom/TreeRoomInteractables/Wall Monitors Screens/wallmonitorcosmetics").GetComponent<Renderer>().material = mat;
            GameObject.Find("Environment Objects/LocalObjects_Prefab/TreeRoom/TreeRoomInteractables/Wall Monitors Screens/wallmonitorcanyon").GetComponent<Renderer>().material = mat;
        }
    }
}
