using UnityEngine;
using System.Collections;

public class NetwrkMan : MonoBehaviour {

    // Use this for initialization
    public string roomName = "VVR";
    public string prefabName = "Car";
    public Transform spawnPoint;
    public int carCount = 0;
    
    void Start () {
        PhotonNetwork.ConnectUsingSettings("v1.0.0");
	}
	
	void OnJoinedLobby()
    {
        RoomOptions roomOptions = new RoomOptions() { isVisible = false, maxPlayers = 4 };
        PhotonNetwork.JoinOrCreateRoom(roomName, roomOptions, TypedLobby.Default);


    }

    void OnJoinedRoom()
    {
        PhotonNetwork.Instantiate(prefabName,
                                    spawnPoint.position,
                                    spawnPoint.rotation,
                                    0);

        
    }
}
