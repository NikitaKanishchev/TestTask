using Photon.Pun;
using UnityEngine.SceneManagement;

namespace App
{
    public class ConnectingToServer : MonoBehaviourPunCallbacks
    {
        private void Start()
        {
            PhotonNetwork.ConnectUsingSettings();
        }

        public override void OnConnectedToMaster()
        {
            SceneManager.LoadScene("Scenes/Lobby");
        }
    }
}
