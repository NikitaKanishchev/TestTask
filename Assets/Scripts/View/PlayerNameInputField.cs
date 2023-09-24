using Photon.Pun;
using TMPro;
using UnityEngine;

namespace View
{
    public class PlayerNameInputField : MonoBehaviour
    {
        [SerializeField] private TMP_InputField _inputField = null;
        
        private const string PlayerNamePrefKey = "PlayerName";

        private void Start()
        {
            string defaultName = string.Empty;

            if (_inputField != null)
            {
                if (PlayerPrefs.HasKey(PlayerNamePrefKey))
                {
                    defaultName = PlayerPrefs.GetString(PlayerNamePrefKey);
                    _inputField.text = defaultName;
                }
            }

            PhotonNetwork.NickName = defaultName;
        }

        public void SetPlayerName(TMP_InputField value)
        {
            if (string.IsNullOrEmpty(value.text))
            {
                Debug.LogError("Player Name is null or empty");
                return;
            }

            PhotonNetwork.NickName = value.text;

            PlayerPrefs.SetString(PlayerNamePrefKey, value.text);
        }
    }
}