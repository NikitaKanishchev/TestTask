using System.Collections;
using UnityEngine;
using Photon.Pun;
using PlayerLogic;
using View;

public class SpawnPopUp : MonoBehaviourPun
{
    [SerializeField] private SpawnPlayer _spawnPlayer;
    [SerializeField] private GameObject _popUp;

    private void Awake()
    {
        _spawnPlayer.PlayerSpawned += SpawnPlayerOnPlayerSpawned;
    }

    private void SpawnPlayerOnPlayerSpawned(PlayerDeath playerDeath)
    {
        playerDeath.PlayerDead += PlayerDeathOnPlayerDead;

    }

    private void PlayerDeathOnPlayerDead()
    {
        StartCoroutine(CoolDownBeforeResults());
    }

    private IEnumerator CoolDownBeforeResults()
    {
        yield return new WaitForSeconds(1f);
        ShowResults();
    }
    private void ShowResults()
    {
        var canvas = PhotonNetwork.Instantiate(_popUp.gameObject.name, Vector3.zero, Quaternion.identity);
        canvas.GetComponent<PopupCanvasController>().PhotonView.RPC("ShowResults", RpcTarget.All);
    }
}