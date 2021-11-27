using UnityEngine;
using Photon.Pun;

public class Connect : MonoBehaviourPunCallbacks
{
    public GameObject connectPanel;
    public GameObject lobbyPanel;

    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
        Debug.Log("Connecting");
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Conncted");
        connectPanel.SetActive(false);
        lobbyPanel.SetActive(true);
    }
}
