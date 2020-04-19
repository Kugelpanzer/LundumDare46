using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviourPun
{
    public GameObject playerObject;
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
        playerObject.GetComponent<CharacterScript>().AddVelocity();
        Debug.Log(string.Format("Player {0} ", a));
    }
}
