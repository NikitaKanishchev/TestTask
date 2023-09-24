using TMPro;
using UnityEngine;

namespace View
{
    public class LobbyJoinToRoom : ViewController
    {
        [SerializeField] private TMP_InputField _joinInputField = null;

        public void JoinRoom()
        {
            LobbyConnector.JoinRoom(_joinInputField.text);
        }
    }
}