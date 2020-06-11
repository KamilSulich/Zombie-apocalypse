using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform SpawnPosition;
    public GameObject Zombie;
    Vector3 ToRandomPlace = Vector3.one;
    float Gametime = 0;
    int SpawnCount = 1;
    float spawnTime = 0.2f;// for example: 0.2 means spawn every 0.2s (at once)
    int howManyZombiesSpawn;
    private void Start()
    {
        if (PlayerPrefs.GetInt("difficulty") == 1)
        {
            spawnTime = 0.2f;
            howManyZombiesSpawn = 3;
        }
        else if (PlayerPrefs.GetInt("difficulty") == 2)
        {
            spawnTime = 0.1f;
            howManyZombiesSpawn = 6;
        }
        else 
        {
            spawnTime = 0.1f;
            howManyZombiesSpawn = 8;
        }

    }
    void Update()
    {
        for  (int i=0;i< howManyZombiesSpawn;i++)
        {
            SpawnZombie();
        }
    }

    private void SpawnZombie()
    {
        ToRandomPlace.y = -SpawnPosition.position.y + Zombie.transform.localScale.y / 2;
        ToRandomPlace.x = Random.Range(-25, 25);
        ToRandomPlace.z = Random.Range(-25, 25);

        while (ToRandomPlace.x * ToRandomPlace.x + ToRandomPlace.z * ToRandomPlace.z > 625)
        {
            ToRandomPlace.x = Random.Range(-25, 25);
            ToRandomPlace.z = Random.Range(-25, 25);
        }

        Gametime = Time.timeSinceLevelLoad;
        if (SpawnCount * spawnTime > Gametime  /*Input.GetMouseButton(0)*/)
        {
            Instantiate(Zombie, SpawnPosition.position + ToRandomPlace, SpawnPosition.rotation);
            SpawnCount++;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject AnotherZombie = collision.collider.gameObject;
        
    }
}
