using System;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using TMPro;

public class Lobby : MonoBehaviourPunCallbacks
{
    public TMP_InputField createInput;
    public TMP_InputField usernameInput;
    public byte maxPlayers;
    [Space]
    public RoomItem roomItemPrefab;
    public Transform contentObj;

    List<RoomItem> roomItemsList = new List<RoomItem>();

    void Start()
    {
        PhotonNetwork.JoinLobby();
    }

    public void CreateRoom()
    {
        if(createInput.text.Length > 0)
        {
            RoomOptions roomOptions = new RoomOptions();

            roomOptions.IsOpen = true;
            roomOptions.IsVisible = true;
            roomOptions.MaxPlayers = maxPlayers;

            PhotonNetwork.CreateRoom(createInput.text, roomOptions);
        }
    }

    public void OnUsernameInputChange()
    {
        PhotonNetwork.NickName = usernameInput.text;
    }

    public void SetName()
    {
        PhotonNetwork.NickName = usernameInput.text;
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void JoinRoom(string roomName)
    {
        PhotonNetwork.JoinRoom(roomName);
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("Main");
    }

    public override void OnRoomListUpdate(List<RoomInfo> roomList)
    {
        UpdateRoomList(roomList);
    }

    void UpdateRoomList(List<RoomInfo> list)
    {
        foreach (RoomItem item in roomItemsList)
        {
            Destroy(item.gameObject);
        }
        roomItemsList.Clear();

        foreach (RoomInfo info in list)
        {
            RoomItem newRoom = Instantiate(roomItemPrefab, contentObj);
            newRoom.SetRoomName(info.Name);
            roomItemsList.Add(newRoom);
        }
    }
}
