using TMPro;
using UnityEngine;

namespace View
{
    public class LobbyCreatorRoom : ViewController
    {
        [SerializeField] private TMP_InputField _createInputField = null;

        public void CreateRoom()
        {
            LobbyConnector.CreateRoom(_createInputField.text);
        }
    }
}