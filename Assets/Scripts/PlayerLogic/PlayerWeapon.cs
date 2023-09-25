using Photon.Pun;
using UnityEngine;
using Bullet = Weapon.Bullet;

namespace PlayerLogic
{
    public class PlayerWeapon : MonoBehaviour
    {
        [SerializeField] private Bullet _bullet = null;
        [SerializeField] private Transform _firePoint = null;
        [SerializeField] private float _bulletSpeed = 5f;
        
        public void Fire()
        {
            GameObject bullet = PhotonNetwork.Instantiate(_bullet.name, _firePoint.position, Quaternion.identity);
            bullet.GetComponent<Bullet>().ShootIntoPosition(_firePoint, _bulletSpeed);
        }
    }
}