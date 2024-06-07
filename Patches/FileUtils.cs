﻿using UnityEngine;
using BepInEx;
using StupidTemplate.Classes;
using System.Linq;
using StupidTemplate.Mods;
using static StupidTemplate.Settings;
using static StupidTemplate.Menu.Main;
using Photon.Pun;
using Photon.Realtime;
using System.IO;
using System.Diagnostics;
using ExitGames.Client.Photon;
using GorillaNetworking;
using static UnityEngine.UI.GridLayoutGroup;
using GorillaLocomotion;
using System.Reflection;
using System.Net;
using System;

namespace StupidTemplate
{
    internal class FileUtils
    {
        static void VerifyThing()
        {
           

            if (!Directory.Exists("BepInEx/plugins/504Brandon/themes"))
            {
                Directory.CreateDirectory("BepInEx/plugins/504Brandon/themes");
            }

            if (!Directory.Exists("BepInEx/plugins/504Brandon/images"))
            {
                Directory.CreateDirectory("BepInEx/plugins/504Brandon/images");
            }
        }

        public static string ReadTXTFile(string name = "coolness")
        {
            VerifyThing();

            if (File.Exists("BepInEx/plugins/504Brandon/" + name + ".txt"))
            {
                return File.ReadAllText("BepInEx/plugins/504Brandon/" + name + ".txt");
            }
            else
            {
                MakeTXTFile(name);
                return null;
            }
        }

        public static void MakeTXTFile(string name = "coolness", string contents = "", bool shouldOpen = false)
        {
            VerifyThing();
            File.WriteAllText("BepInEx/plugins/504Brandon/" + name + ".txt", contents);

            if (shouldOpen)
                OpenTXTFile(name);
        }

        public static void OpenTXTFile(string name = "coolness")
        {
            VerifyThing();

            string filePath = System.IO.Path.Combine(System.Reflection.Assembly.GetExecutingAssembly().Location, "504Brandon/" + name + ".txt");
            filePath = filePath.Split("BepInEx\\")[0] + "BepInEx/plugins/504Brandon/" + name + ".txt";
            try
            {
                Process.Start(filePath);
            }
            catch
            {
                UnityEngine.Debug.Log("Could not open process " + filePath);
            }
        }

        public static Texture2D LoadTheme(string resourcePath, string fileName)
        {
            Texture2D texture = new Texture2D(2, 2);

            VerifyThing();

            if (!File.Exists("BepInEx/plugins/504brandon/images/" + fileName))
            {
                UnityEngine.Debug.Log("Downloading " + fileName);
                WebClient stream = new WebClient();
                stream.DownloadFile(resourcePath, "BepInEx/plugins/504brandon/images/" + fileName);
            }

            byte[] bytes = File.ReadAllBytes("BepInEx/plugins/504brandon/images/" + fileName);
            texture.LoadImage(bytes);

            return texture;
        }
    }
}
