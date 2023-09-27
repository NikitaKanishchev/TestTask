using System;
using Photon.Pun;
using PlayerLogic;
using UnityEngine;

namespace CoinLogic
{
    public class CoinPicker : MonoBehaviourPun
    {
        private int _coin = 0;
        
        public int Coin => _coin;

        public event Action<float> CoinCollected; 
        private void OnTriggerEnter2D(Collider2D coll)
        {
            if (coll.gameObject.TryGetComponent(out Coin coin))
            {
                ++_coin;
                CoinCollected?.Invoke(_coin);
                Destroy(coin.gameObject);
            }
        }
    }
}

          
    
