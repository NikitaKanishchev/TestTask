using Photon.Pun;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public Bullet bulletPrefab;
    public float bulletForce = 20f;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
            Shoot();
    }

    private void Shoot()
    {
        GameObject bullet = PhotonNetwork.Instantiate(bulletPrefab.name, firePoint.position, firePoint.rotation);
        //bullet.GetComponent<Bullet>().ShootIntoPosition(firePoint,bulletForce);
    }

}
