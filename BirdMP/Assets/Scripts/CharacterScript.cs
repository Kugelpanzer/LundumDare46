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
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
