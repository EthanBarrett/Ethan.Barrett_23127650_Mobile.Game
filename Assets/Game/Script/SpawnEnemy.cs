using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] GameObject spawned;
    [SerializeField] Transform spawnPoint;
    [SerializeField] float spawncool = 1f;
    [SerializeField] int MaxSpawnCount = 3;

    private float spawnTime;
    private int currentEnemies = 0;
    bool Max = false;

     void Start()
    {
        spawnTime = spawncool;
    }

     void Update()
    {
        if (currentEnemies == MaxSpawnCount)
        {
            Max = true;
        }
            

        if (spawnTime > 0) spawnTime -= Time.deltaTime;

        if (spawnTime <= 0)
        {
            Spawn();
            spawnTime = spawncool;
        }


    }

    void Spawn()
    {

        if (Max == false)
        {
            GameObject spawn = Instantiate(spawned, spawnPoint.position, spawnPoint.rotation);
        }
        else
            return;
        

        currentEnemies++;

       
       
    }

    public void EnemyDied()
    {
        currentEnemies--;
    }

}
