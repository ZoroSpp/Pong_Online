using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using TMPro;

public class CreateAndJoinRooms : MonoBehaviourPunCallbacks
{
    public TMP_InputField createinput;
    public TMP_InputField joininput;
    

    public void CreateRoom()
    {
        //GameObject.Find("SpawnPlayers").GetComponent<SpawnPlayers>().x = 0;
        PhotonNetwork.CreateRoom(createinput.text);
    }
    public void JoinRoom()
    {
        //GameObject.Find("SpawnPlayers").GetComponent<SpawnPlayers>().x = 1;
        PhotonNetwork.JoinRoom(joininput.text);
    }
    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("OnlineMode");
    }
}
