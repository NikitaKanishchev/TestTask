using System;
using Photon.Pun;
using Photon.Realtime;

namespace App
{
    public class LobbyConnector : MonoBehaviourPunCallbacks
    {
        private void Start()
        {
            PhotonNetwork.AutomaticallySyncScene = true;
        }

        public void CreateRoom(string createRoom)
        {
            RoomOptions ro = new RoomOptions {MaxPlayers = 4};
            PhotonNetwork.CreateRoom(createRoom, ro);
        }

        public void JoinRoom(string joinRoom)
        {
            PhotonNetwork.JoinRoom(joinRoom);
        }

        public override void OnJoinedRoom()
        {
            PhotonNetwork.LoadLevel("Game");
        }
    }
}