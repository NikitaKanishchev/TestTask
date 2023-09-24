using System.Collections.Generic;
using Player;
using UnityEngine;

namespace View
{
    public class PopupCanvasController : MonoBehaviour
    {
        [SerializeField] private Canvas _canvas = null;
        
        [SerializeField] private GameObject _winPanel = null;
        
        private List<PlayerDeath> _playerDeaths = null;

        private void Awake()
        {
            _canvas.worldCamera = Camera.main;
            
            foreach (var player in FindObjectsOfType<PlayerDeath>())
            {
                _playerDeaths.Add(player);
            }

            foreach (var playerDeath in _playerDeaths)
            {
                playerDeath.PlayerDead += PlayerDeathOnPlayerDead;
            }
        }

        private void PlayerDeathOnPlayerDead()
        {
            _winPanel.SetActive(true);
        }
    }
}