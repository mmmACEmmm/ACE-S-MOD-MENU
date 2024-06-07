using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Rendering;
using UnityEngine;
using UnityEngine.Networking;

namespace Monkey_Magic_Menu.Mods.visuals
{
    internal class enableRemoveLeaves : MonoBehaviour
    {
        public static Material oldmat = null;
        public static Material noleafmat = null;
        public static Texture2D forestTexture = null;
        public static List<GameObject> atlases = new List<GameObject> { };

        public static void EnableRemoveLeaves()
        {
            // Start the coroutine to load the texture
            Instance.StartCoroutine(LoadTextureAndApply());
        }

        private static IEnumerator LoadTextureAndApply()
        {
            foreach (GameObject g in Resources.FindObjectsOfTypeAll<GameObject>())
            {
                if (g.activeSelf && g.name.Contains("forestatlas (combined") && g.GetComponent<Renderer>() != null && g.GetComponent<Renderer>().material.name.Contains("forest"))
                {
                    if (oldmat == null)
                    {
                        oldmat = g.GetComponent<Renderer>().material;
                    }

                    if (noleafmat == null)
                    {
                        noleafmat = new Material(Shader.Find("Universal Render Pipeline/Lit"));

                        noleafmat.SetFloat("_Surface", 1);
                        noleafmat.SetFloat("_Blend", 0);
                        noleafmat.SetFloat("_SrcBlend", (float)BlendMode.SrcAlpha);
                        noleafmat.SetFloat("_DstBlend", (float)BlendMode.OneMinusSrcAlpha);
                        noleafmat.SetFloat("_ZWrite", 0);
                        noleafmat.EnableKeyword("_SURFACE_TYPE_TRANSPARENT");
                        noleafmat.renderQueue = (int)RenderQueue.Transparent;

                        noleafmat.SetFloat("_Glossiness", 0.0f);
                        noleafmat.SetFloat("_Metallic", 0.0f);

                        if (forestTexture == null)
                        {
                            yield return Instance.StartCoroutine(LoadTextureFromURL("https://raw.githubusercontent.com/iiDk-the-actual/ModInfo/main/forestatlasv2.png", "noLeavesTexture"));
                            forestTexture.filterMode = FilterMode.Point;
                            forestTexture.wrapMode = TextureWrapMode.Clamp;
                        }

                        noleafmat.color = new Color(1, 1, 1, 1);
                        noleafmat.mainTexture = forestTexture;
                    }

                    g.GetComponent<Renderer>().material = noleafmat;
                    g.GetComponent<Renderer>().sortingOrder = UnityEngine.Random.Range(0, 255);

                    atlases.Add(g);
                }
            }
            hasFoundAllBoards = false;
        }

        private static IEnumerator LoadTextureFromURL(string url, string fallbackPath)
        {
            UnityWebRequest request = UnityWebRequestTexture.GetTexture(url);
            yield return request.SendWebRequest();

            if (request.result == UnityWebRequest.Result.ConnectionError || request.result == UnityWebRequest.Result.ProtocolError)
            {
                Debug.LogWarning($"Failed to load texture from URL: {request.error}. Loading fallback texture.");

                Texture2D fallbackTexture = Resources.Load<Texture2D>(fallbackPath);
                if (fallbackTexture != null)
                {
                    forestTexture = fallbackTexture;
                }
                else
                {
                    Debug.LogError("Failed to load fallback texture.");
                }
            }
            else
            {
                forestTexture = ((DownloadHandlerTexture)request.downloadHandler).texture;
            }
        }

        public static void DisableRemoveLeaves()
        {
            foreach (GameObject l in atlases)
            {
                l.GetComponent<Renderer>().material = oldmat;
            }
            atlases.Clear();
            hasFoundAllBoards = false;
        }

        private static enableRemoveLeaves _instance;
        private static bool hasFoundAllBoards;

        private static enableRemoveLeaves Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GameObject("enableRemoveLeaves").AddComponent<enableRemoveLeaves>();
                    DontDestroyOnLoad(_instance.gameObject);
                }
                return _instance;
            }
        }
    }
}
