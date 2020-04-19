using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class CharacterScript : MonoBehaviourPun
{
    Rigidbody2D rb;
    //[PunRPC]
    public void AddVelocity()
    {
        rb.MovePosition(new Vector2(0, 0));
        rb.AddForce(Vector2.up);
    }
    // Start is called before the first frame update
    void Start()
    {
        PhotonView.Get(this).RPC("SetPlayerObject", RpcTarget.All, this.gameObject);
        rb = GetComponent<Rigidbody2D>();
       
    }
    public void SetPlayerScript(GameObject gj)
    {
        GameObject.Find("NetworkController").GetComponent<CharacterController>().playerObject = gj;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
