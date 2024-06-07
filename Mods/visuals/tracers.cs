using System;
using System.Collections.Generic;
using System.Text;
using GorillaLocomotion;
using Photon.Pun;
using UnityEngine;

namespace Monkey_Magic_Menu.Mods.visuals
{
    internal class tracers
{
    public static void Tracers()
    {
        bool flag = PhotonNetwork.InLobby || PhotonNetwork.InRoom;
        if (flag)
        {
            foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
            {
                bool flag2 = !vrrig.isOfflineVRRig;
                bool flag3 = flag2;
                if (flag3)
                {
                    GameObject gameObject = new GameObject("Line");
                    LineRenderer lineRenderer = gameObject.AddComponent<LineRenderer>();
                    lineRenderer.startColor = (lineRenderer.endColor = Color.blue);
                    lineRenderer.startWidth = (lineRenderer.endWidth = 0.01f);
                    lineRenderer.positionCount = 2;
                    lineRenderer.SetPositions(new Vector3[]
                    {
                    Player.Instance.rightControllerTransform.position,
                    vrrig.transform.position
                    });
                    lineRenderer.material.shader = Shader.Find("GUI/Text Shader");
                    UnityEngine.Object.Destroy(gameObject, Time.deltaTime);
                }
            }
        }
    }

}
}
