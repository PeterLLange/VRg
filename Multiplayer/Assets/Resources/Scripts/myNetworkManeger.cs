using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class myNetworkManeger : NetworkManager
{

    public override void OnServerAddPlayer(NetworkConnection conn, short playerControllerId)
    {
        GameObject player;
        PlayerOptions Options = gameObject.GetComponent<PlayerOptions>();
        if (Options.usingVR )
            player = Instantiate(Resources.Load("Players/VRPlayer"), transform.position, Quaternion.identity) as GameObject;

        else
            player = Instantiate(Resources.Load("Players/testPlayer"), transform.position, Quaternion.identity) as GameObject;

        NetworkServer.AddPlayerForConnection(conn, player, playerControllerId);
    }
}
