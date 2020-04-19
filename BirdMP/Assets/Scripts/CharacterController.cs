using Photon.Pun;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviourPun
{

    PhotonView photonView ;
    // Start is called before the first frame update
    void Start()
    {
        photonView = PhotonView.Get(this);
        //photonView.RPC("ChatMessage", RpcTarget.All, "jup", "and jup.");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            /*if (PhotonNetwork.LocalPlayer.NickName == "1")
            {*/
                photonView.RPC("ChatMessage", RpcTarget.All, PhotonNetwork.LocalPlayer.NickName);
            /*}*/
        }
    }
    [PunRPC]
    void ChatMessage(string a)
    {
        Debug.Log(string.Format("Player {0} ", a));
    }
}
