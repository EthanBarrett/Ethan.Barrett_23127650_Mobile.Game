using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public GameObject Enemy;
    public GameObject PlayerObj;
    public float speed;
    public float Health = 5;
     void Start()
    {
        if (PlayerObj == null)
        {
            PlayerObj = GameObject.FindWithTag("Player");
           
        }
      
    }
    void Update()
    {
        if (PlayerObj != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, PlayerObj.transform.position, speed * Time.deltaTime);
        }
           
        if (Health <= 0)
        {
            Destroy(Enemy);
        }        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            Health -= 5;
        }
        
    }
}
