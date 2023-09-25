using Photon.Pun;
using UnityEngine;
using UnityEngine.UI;

namespace PlayerLogic
{
    
    public class Player : MonoBehaviourPun
    {
        [SerializeField] public Text _playerName;
        
        [SerializeField] private CoinPicker _coinPicker;
        
        public CoinPicker CoinPicker => _coinPicker;

        private void Start()
        {
            _playerName.text = GetComponent<PhotonView>().Owner.NickName;
        }

        [PunRPC]
        public int GetCoinsValue()
        {
            return CoinPicker.Coin;
        }

    }
}
