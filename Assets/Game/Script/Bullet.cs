using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Transform bulletspawn;
    public GameObject bulletPrefab;
    public float bulletspeed = 20;
    private float lastShot = 0f;
    public float cooldown = 0.2f;


     void Start()
    {


    }


    void Update()
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

    void Shoot()
    { 
        var bullet = Instantiate(bulletPrefab, bulletspawn.position, bulletspawn.rotation);
        bullet.GetComponent<Rigidbody>().linearVelocity = bulletspawn.forward * bulletspeed;

        Destroy(bullet, 2.5f); 

        lastShot = Time.time;
    }

  


}
