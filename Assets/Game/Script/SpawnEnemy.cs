using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] GameObject spawned;
    [SerializeField] Transform spawnPoint;
    [SerializeField] float spawncool = 1f;

    private float spawnTime;

     void Start()
    {
        spawnTime = spawncool;
    }

     void Update()
    {
        if (spawnTime > 0) spawnTime -= Time.deltaTime;

        if (spawnTime <= 0)
        {
            Spawn();
            spawnTime = spawncool;
        }
    }

    void Spawn()
    {
        
        var spawn = Instantiate(spawned, spawnPoint.position, spawnPoint.rotation);

       
    }



}
