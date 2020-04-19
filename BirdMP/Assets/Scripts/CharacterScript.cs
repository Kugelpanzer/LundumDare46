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
        float r1 = Random.Range(0f, 4f);
        float r2 = Random.Range(2f, 5f);
        Debug.Log(r1);
        Debug.Log(r2);
        rb.MovePosition(new Vector2(0, 0));
        rb.AddForce(Vector2.up);
    }
    // Start is called before the first frame update
    void Start()
    {
        SetPlayerScript();
        //PhotonView.Get(this).RPC("SetPlayerObject", RpcTarget.All, this.gameObject);
        rb = GetComponent<Rigidbody2D>();
       
    }
    public void SetPlayerScript()
    {
        GameObject.Find("NetworkController").GetComponent<CharacterController>().playerObject = this.gameObject;
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
