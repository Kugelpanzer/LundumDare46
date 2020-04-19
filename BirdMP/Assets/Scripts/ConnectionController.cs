﻿using Photon.Pun;
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
        PhotonNetwork.JoinRandomRoom();
        //PhotonNetwork.JoinRoom(roomNameField.text);
    }
    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        Debug.Log("Failed to join server");
        PhotonNetwork.CreateRoom(roomNameField.text, new Photon.Realtime.RoomOptions() { IsVisible = true, IsOpen = true, MaxPlayers = (byte)2 });
    }
    public override void OnJoinedRoom()
    {
        Debug.Log("Logovanje uspelo");
    }
    public void OnConnectedToServer()
    {
        Debug.Log("CONNECTED TO SERVER ???");
    }

}
