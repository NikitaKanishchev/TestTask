using System;

namespace Health
{
    public interface IHealth
    {
        event Action HealthChanged;
        float CurrentHp { get; set; }
        float MaxHp { get; set; }
        void TakeDamage(float damage);
    }
}