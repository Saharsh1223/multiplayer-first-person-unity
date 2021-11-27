using UnityEngine;
using Photon.Pun;

public class GameManager : MonoBehaviour
{
    public GameObject playerPrefab;

    void Start()
    {
        PhotonNetwork.Instantiate(playerPrefab.name, new Vector3(Random.Range(-5f, 5f), Random.Range(3f, 5f), Random.Range(-5f, 5f)), playerPrefab.transform.rotation);
    }
}
