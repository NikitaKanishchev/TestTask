using Photon.Pun;
using UnityEngine;
using UnityEngine.UI;

namespace PlayerLogic
{
    public class PlayerName : MonoBehaviourPunCallbacks
    {
        public InputField CreateInputName;
    
        private void Start()
        {
            PhotonNetwork.ConnectUsingSettings();
            CreateInputName.text = PlayerPrefs.GetString("name");
            PhotonNetwork.NickName = CreateInputName.text;
        }
        public void SaveName()
        {
            PlayerPrefs.SetString("name",CreateInputName.text);
            PhotonNetwork.NickName = CreateInputName.text;
        }
    }
}
