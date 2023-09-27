using CoinLogic;
using UnityEngine;
using Photon.Pun;
using PlayerLogic;

namespace View
{
    public class PopupCanvasController : MonoBehaviourPun
    {
        [SerializeField] private Canvas _canvas = null;
        
        [SerializeField] private WinPanelController _winPanel = null;

        public PhotonView PhotonView { get; private set; }
        
        private PlayerBase _activePlayerBase = null;

        private CoinPicker picker;
        private void Awake()
        {
            _canvas.worldCamera = Camera.main;
            PhotonView = GetComponent<PhotonView>();
            _activePlayerBase = ActivePlayerBase();
            Debug.Log("Player"+ _activePlayerBase.name);
        }

        private PlayerBase ActivePlayerBase() => 
            FindObjectOfType<PlayerBase>();

        [PunRPC]
        public void ShowResults()
        {
            _winPanel.SetNickName(_activePlayerBase.photonView.Owner.NickName);
            _winPanel.SetQuantityCoin(_activePlayerBase.CoinPicker.Coin);
            _winPanel.gameObject.SetActive(true);
        }

    }
}