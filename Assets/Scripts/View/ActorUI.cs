using Health;
using Photon.Pun;
using TMPro;
using UnityEngine;

namespace View
{
    public class ActorUI : MonoBehaviour
    {
        [SerializeField] private HpBar _hpBar;
    
        private IHealth _health;

        public void Construct(IHealth health)
        {
            _health = health;

            _health.HealthChanged += UpdateHpBar;
        }

        private void Start()
        {
            var health = GetComponent<IHealth>();
            
            if (health != null)
            {
                Construct(health);
            }
        }

        private void UpdateHpBar()
        {
            _hpBar.SetValue(_health.CurrentHp, _health.MaxHp);
        }

        private void OnDestroy()
        {
            if (_health != null)
            {
                _health.HealthChanged -= UpdateHpBar;
            }
        }
    }
}
