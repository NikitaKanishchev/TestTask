using Photon.Pun;

namespace CoinLogic
{
    public class Coin : MonoBehaviourPunCallbacks
    {
        private PhotonView view;
        
        private void Start() => 
            view = GetComponent<PhotonView>();
    
    }
}


