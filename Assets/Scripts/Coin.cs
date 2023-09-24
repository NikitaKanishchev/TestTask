using System;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class Coin : MonoBehaviourPunCallbacks
{
    private PhotonView view;

    private void Start() => 
        view = GetComponent<PhotonView>();
    
}


