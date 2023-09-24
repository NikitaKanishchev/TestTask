using UnityEngine;
using Photon.Pun;
using TMPro;
using UnityEngine.UI;

namespace HpBar
{
    
    public class Player : MonoBehaviourPunCallbacks
    {

        [SerializeField] public Text _playerName;
        [SerializeField] private GameObject _healthBar;
        [SerializeField] public TMP_Text _coin;

        void Start()
        {
            _playerName.text = GetComponent<PhotonView>().Owner.NickName;
        }

    }
}
