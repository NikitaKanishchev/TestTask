using System;
using Photon.Pun;
using UnityEngine;

public class NickNamesGetter : MonoBehaviour
{

    public void GetNames()
    {
        PhotonView[] playersInGame = FindObjectsOfType<PhotonView>();
        foreach (var player in playersInGame)
        {
            Debug.Log("There is someone named: " + player.Owner.NickName +
                      " in the game!");
        }
    }
}