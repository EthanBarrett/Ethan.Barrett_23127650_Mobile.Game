using UnityEngine;

public class DestroyBullet : MonoBehaviour
{
    public GameObject bullet;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(bullet);
        }

    }
}
