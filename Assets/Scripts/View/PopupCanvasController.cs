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
        
        private Player _activePlayer = null;

        private CoinPicker picker;
        private void Awake()
        {
            _canvas.worldCamera = Camera.main;
            PhotonView = GetComponent<PhotonView>();
            _activePlayer = ActivePlayer();
        }

        private Player ActivePlayer() => 
            FindObjectOfType<Player>();

        [PunRPC]
        public void ShowResults()
        {
            _winPanel.SetNickName(_activePlayer.photonView.Owner.NickName);
            _winPanel.SetQuantityCoin(_activePlayer.CoinPicker.Coin);
            _winPanel.gameObject.SetActive(true);
        }

    }
}