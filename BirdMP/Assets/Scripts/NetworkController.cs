using Photon.Pun;
//using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetworkController : MonoBehaviourPunCallbacks
{
    public GameObject testPrefab;
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void OnConnectedToMaster()
    {
        Debug.Log("Successfuly connected");
        Debug.Log(PhotonNetwork.CloudRegion);
        PhotonNetwork.AutomaticallySyncScene = true;
        
       // PhotonNetwork.Instantiate("testPrefab",new Vector3(),new Quaternion());

    }
}
