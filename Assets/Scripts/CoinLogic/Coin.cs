using Photon.Pun;

namespace PlayerLogic
{
    public class Coin : MonoBehaviourPunCallbacks
    {
        private PhotonView view;
        
        private void Start() => 
            view = GetComponent<PhotonView>();
    
    }
}


