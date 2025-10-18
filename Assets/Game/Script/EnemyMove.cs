using UnityEngine;

public class EnemyMove : MonoBehaviour
{
   
    public GameObject PlayerObj;
    public float speed;

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
           
        
        
    }
}
