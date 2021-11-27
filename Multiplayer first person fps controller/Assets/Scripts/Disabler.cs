using UnityEngine;
using Photon.Pun;

public class Disabler : MonoBehaviour
{
    public PhotonView photonView;
    [Space]
    public PlayerLook playerLook;
    public PlayerMovement playerMovement;
    public WallRun wallRun;
    [Space]
    public GameObject cameraHolder;

    void Update()
    {
        if (!photonView.IsMine)
        {
            playerLook.enabled = false;
            playerMovement.enabled = false;
            wallRun.enabled = false;

            cameraHolder.SetActive(false);
        }
    }
}
