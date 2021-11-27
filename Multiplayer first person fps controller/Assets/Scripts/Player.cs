using UnityEngine;
using Photon.Pun;
using TMPro;

public class Player : MonoBehaviour
{
    public PhotonView photonView;
    public GameObject usernameCanvas;
    public TMP_Text usernameText;

    void Awake()
    {
        if (photonView.IsMine)
        {
            usernameText.text = PhotonNetwork.NickName;
        }
        else
        {
            usernameText.text = photonView.Owner.NickName;
        }
    }

    void Update()
    {
        if (!photonView.IsMine)
        {
            usernameCanvas.SetActive(true);
        }
    }
}
