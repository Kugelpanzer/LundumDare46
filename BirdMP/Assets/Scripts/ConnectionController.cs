using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConnectionController : MonoBehaviourPunCallbacks
{
    public Button connectButton;
    public InputField roomNameField;

    public override void OnConnectedToMaster()
    {
        Debug.Log("CONNECTED TO " + PhotonNetwork.ServerSettingsFileName);
    }

    public void Connect()
    {
        PhotonNetwork.JoinRoom(roomNameField.text);
    }
    public override void OnJoinRoomFailed(short returnCode, string message)
    {
        PhotonNetwork.CreateRoom(roomNameField.text, new Photon.Realtime.RoomOptions() { IsVisible = true, IsOpen = true, MaxPlayers = (byte)2 });
    }
    public void OnConnectedToServer()
    {
        Debug.Log("CONNECTED TO SERVER ???");
    }

}
