using Photon.Pun;
using UnityEngine;

public class SharedObjectController : MonoBehaviourPun
{
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    [PunRPC]
    public void GrabObject(Vector3 position, Quaternion rotation)
    {
        rb.MovePosition(position);
        rb.MoveRotation(rotation);
    }
}
