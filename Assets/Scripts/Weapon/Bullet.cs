using System.Collections;
using PlayerLogic;
using UnityEngine;

namespace Weapon
{
    public class Bullet : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D _bulletRigidbody = null;

        private void Start() => 
            StartCoroutine(ChangeVisibleAfterTime());

        public void ShootIntoPosition(Transform firePoint, float speed) => 
            _bulletRigidbody.AddForce(firePoint.up * speed, ForceMode2D.Impulse);

        private void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.TryGetComponent(out PlayerHealth playerHealth)) 
                playerHealth.TakeDamage(1);
        }

        private IEnumerator ChangeVisibleAfterTime()
        {
            yield return new WaitForSeconds(3f);
            gameObject.SetActive(false);
        }
    }
}