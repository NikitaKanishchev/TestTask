using System;
using Photon.Pun;
using TMPro;
using UnityEngine;


public class CoinPicker : MonoBehaviourPunCallbacks
{
    private float _coins = 0;

    public event Action<float> CoinCollected; 
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.TryGetComponent(out Coin coin))
        {
            ++_coins;
            CoinCollected?.Invoke(_coins);
            Destroy(coin.gameObject);
        }
    }
}

          
    
