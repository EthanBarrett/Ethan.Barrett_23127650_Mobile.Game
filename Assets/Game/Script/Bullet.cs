using UnityEngine;
using UnityEngine.InputSystem;

public class Bullet : MonoBehaviour
{
    public Transform bulletspawn;
    public GameObject bulletPrefab;
    public float bulletspeed = 15;
    private float lastShot = 0f;
     public float cooldown = 0.1f;

    

    
    /* void Update()
     {
         TouchInput();
     }

         void TouchInput()
     {
         if (Input.touchCount > 1)
         {
             Touch touch = Input.GetTouch(1);

             if (touch.phase == TouchPhase.Began || touch.phase == TouchPhase.Stationary)
             {
                 if (canShoot())
                 {
                     Shoot();
                 }
             }  

         }

     }


     bool canShoot()
     {
         return Time.time >= lastShot + cooldown;
     }

     */


        public void Shoot()
    {
        if (Time.time < lastShot + cooldown) return;

        var bullet = Instantiate(bulletPrefab, bulletspawn.position, bulletspawn.rotation);
        bullet.GetComponent<Rigidbody>().linearVelocity = bulletspawn.forward * bulletspeed;

        Destroy(bullet, 2.5f); 

        lastShot = Time.time;
    }

  


}
