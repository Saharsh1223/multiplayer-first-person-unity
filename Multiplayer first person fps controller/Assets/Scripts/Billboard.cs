using UnityEngine;

public class Billboard : MonoBehaviour
{
    public Transform cam;

    void Start()
    {
        //cam = Camera.main.transform;
    }

    void Update()
    {
        transform.LookAt(transform.position + cam.rotation * Vector3.forward, cam.rotation * Vector3.up);
    }
}
