using Photon.Pun;
using UnityEngine;

public class NetworkManager : MonoBehaviourPunCallbacks
{
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinOrCreateRoom("ChemistryLab", new Photon.Realtime.RoomOptions(), null);
    }

    public override void OnJoinedRoom()
    {
        GameObject player = PhotonNetwork.Instantiate("NetworkedPlayer", Vector3.zero, Quaternion.identity);
        player.GetComponent<PlayerSync>().Init();
    }
}
