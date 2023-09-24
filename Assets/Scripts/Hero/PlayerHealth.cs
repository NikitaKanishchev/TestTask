using System;
using Health;
using UnityEngine;

namespace Player
{
    public class PlayerHealth : MonoBehaviour, IHealth
    {
        [SerializeField] private float _maxHealth = 5;
        [SerializeField] private float _currentHealth = 5;
        
        public event Action HealthChanged;

        public float CurrentHp
        {
            get => _currentHealth;
            set => _currentHealth = value;
        }

        public float MaxHp
        {
            get => _maxHealth;
            set => _maxHealth = value;
        }

        public void TakeDamage(float damage)
        {
            CurrentHp -= damage;

            HealthChanged?.Invoke();
        }
    }
}