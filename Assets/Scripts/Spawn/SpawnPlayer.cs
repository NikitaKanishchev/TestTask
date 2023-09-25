using System;
using App;
using Photon.Pun;
using PlayerLogic;
using UnityEngine;
using View;
using Random = UnityEngine.Random;

public class SpawnPlayer : MonoBehaviour
{
    [SerializeField] private PlayerMovement _player = null;

    [SerializeField] private float _minX = -3;
    [SerializeField] private float _minY = -3;
    [SerializeField] private float _maxY = 3;
    [SerializeField] private float _maxX = 3;
    
    private GameBootstrap _gameBootstrap = null;
    public event Action<PlayerDeath> PlayerSpawned = null;

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
        PlayerSpawned?.Invoke(player.GetComponent<PlayerDeath>());
    }
    
}
