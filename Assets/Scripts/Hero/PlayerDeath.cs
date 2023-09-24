using System;
using UnityEngine;

namespace Player
{
    public class PlayerDeath : MonoBehaviour
    {
        [SerializeField] private PlayerHealth _playerHealth = null;

        public event Action PlayerDead;
        
        private bool _isDead;
        
        private void Awake()
        {
            _playerHealth.HealthChanged += OnHealthChanged;
        }

        private void OnHealthChanged()
        {
            if (ReadyToDie())
            {
                Die();
            }
        }

        private bool ReadyToDie() => 
            !_isDead && _playerHealth.CurrentHp <= 0;

        private void Die()
        {
            _isDead = true;
            PlayerDead?.Invoke();
            gameObject.SetActive(false);   
        }

        private void OnDestroy()
        {
            _playerHealth.HealthChanged -= OnHealthChanged;
        }
        
    }
}