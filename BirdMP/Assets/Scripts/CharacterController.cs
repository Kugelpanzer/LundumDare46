using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviourPun
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PhotonView.Get(this).RPC("ChatMessage", RpcTarget.All, PhotonNetwork.LocalPlayer.NickName);
        }
    }
    [PunRPC]
    void ChatMessage(string a)
    {
        Debug.Log(string.Format("Player {0} ", a));
    }
}
