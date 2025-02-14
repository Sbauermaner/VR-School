using Photon.Pun;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PlayerSync : MonoBehaviourPun, IPunObservable
{
    private Transform leftHand;
    private Transform rightHand;

    void Init()
    {
        if (photonView.IsMine)
        {
            leftHand = GameObject.Find("LeftHand").transform;
            rightHand = GameObject.Find("RightHand").transform;
        }
    }

    void Update()
    {
        if (!photonView.IsMine) return;
        // Синхронизация позиций рук
    }

    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if (stream.IsWriting)
        {
            stream.SendNext(leftHand.position);
            stream.SendNext(rightHand.position);
        }
        else
        {
            transform.position = (Vector3)stream.ReceiveNext();
            transform.rotation = (Quaternion)stream.ReceiveNext();
        }
    }
}
