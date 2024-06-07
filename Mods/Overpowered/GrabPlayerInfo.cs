using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using Photon.Pun;

namespace Monkey_Magic_Menu.Mods.Overpowered
{ 
    internal class RestartGame
{
    public static void GrabPlayerInfo()
    {
        string text = "Room: " + PhotonNetwork.CurrentRoom.Name;
        foreach (Photon.Realtime.Player player in PhotonNetwork.PlayerList)
        {
            float r = 0f;
            float g = 0f;
            float b = 0f;
            try
            {
                VRRig plr = GorillaGameManager.instance.FindPlayerVRRig(player);
                r = plr.playerColor.r * 255;
                g = plr.playerColor.r * 255;
                b = plr.playerColor.r * 255;
            }
            catch { UnityEngine.Debug.Log("Failed to log colors, rig most likely nonexistent"); }
            try
            {
                text += "\n====================================\n";
                text += string.Concat(new string[]
                {
                        "Player Name: \"",
                        player.NickName,
                        "\", Player ID: \"",
                        player.UserId,
                        "\", Player Color: (R: ",
                        r.ToString(),
                        ", G: ",
                        g.ToString(),
                        ", B: ",
                        b.ToString(),
                        ")"
            });
            }
            catch { UnityEngine.Debug.Log("Failed to log player"); }
        }
        text += "\n====================================\n";
        text += "Text file generated with ii's Stupid Menu";
        string fileName = "iisStupidMenu/" + PhotonNetwork.CurrentRoom.Name + " - Player Info.txt";
        if (!Directory.Exists("iisStupidMenu"))
        {
            Directory.CreateDirectory("iisStupidMenu");
        }
        File.WriteAllText(fileName, text);

        //string filePath = System.IO.Path.Combine(Application.dataPath, fileName);
        string filePath = System.IO.Path.Combine(System.Reflection.Assembly.GetExecutingAssembly().Location, fileName);
        filePath = filePath.Split("BepInEx\\")[0] + fileName;
        //filePath = filePath.Split("\\")[0] + "/" + filePath.Split("\\")[1];
        try
        {
            Process.Start(filePath);
        }
        catch
        {
            UnityEngine.Debug.Log("Could not open process " + filePath);
        }
    }
}
}


