using System;
using App;
using Player;
using Photon.Pun;
using UnityEngine;
using View;
using Random = UnityEngine.Random;

public class SpawnPlayer : MonoBehaviour
{
    [SerializeField] private PlayerMovement _player = null;

    [SerializeField] private float _minX = -4;
    [SerializeField] private float _minY = -4;
    [SerializeField] private float _maxY = 4;
    [SerializeField] private float _maxX = 4;
    
    private GameBootstrap _gameBootstrap = null;

    private void Awake()
    {
        _gameBootstrap = FindObjectOfType<GameBootstrap>();
    }

    private void Start()
    {
        Vector2 randomPos = new Vector2(Random.Range(_minX, _minY), Random.Range(_maxX, _maxY));
        var player = PhotonNetwork.Instantiate(_player.name, randomPos, Quaternion.identity);
        player.GetComponent<PlayerMovement>().Init(_gameBootstrap.InputService);
        player.GetComponent<ActorUI>().Construct(player.GetComponent<PlayerHealth>());
    }
}
