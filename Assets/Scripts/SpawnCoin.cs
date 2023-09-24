using UnityEngine;
using Photon.Pun;

public class SpawnCoin : MonoBehaviourPunCallbacks
{
    [SerializeField] private Coin _coin = null;

    [SerializeField] private float _minX = -4;
    [SerializeField] private float _maxX = 3;
    [SerializeField] private float _minZ = -4;
    [SerializeField] private float _maxZ = 4;

    private void Start()
    {
        Vector3 randomPos = new Vector3(Random.Range(_minX, _minZ), 0, Random.Range(_maxX, _maxZ));
        PhotonNetwork.Instantiate(_coin.name, randomPos, _coin.transform.rotation);
    }
}
