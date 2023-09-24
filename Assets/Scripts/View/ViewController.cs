using App;
using UnityEngine;

namespace View
{
    public class ViewController : MonoBehaviour
    {
        private LobbyConnector _lobbyConnector = null;

        protected LobbyConnector LobbyConnector
        {
            get
            {
                return _lobbyConnector = _lobbyConnector == null
                    ? FindObjectOfType<LobbyConnector>()
                    : _lobbyConnector;
            }
        }
    }
}