using Photon.Realtime;
using UnityEngine;
using Photon.Realtime;

namespace Photon.Pun
{
    public class Bullet : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D _bulletRigidbody = null;
        public object ner;

        public void ShootIntoPition(Transform firePoint, float speed)
        {
            _bulletRigidbody.AddForce(firePoint.up * speed, ForceMode2D.Impulse);
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            //if (other.gameObject.TryGetComponent(out PlayerHealth playerHealth))
            {
            //    playerHealth.TakeDamage(1);
            }
        }
    }
}