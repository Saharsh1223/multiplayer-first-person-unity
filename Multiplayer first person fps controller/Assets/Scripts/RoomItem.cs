using UnityEngine;
using Photon.Pun;
using TMPro;

public class RoomItem : MonoBehaviour
{
    public TMP_Text roomName;
    Lobby lobby;

    void Start()
    {
        lobby = FindObjectOfType<Lobby>();
    }

    public void SetRoomName(string name)
    {
        roomName.text = name;
    }

    public void JoinRoom()
    {
        lobby.JoinRoom(roomName.text);
    }
}
