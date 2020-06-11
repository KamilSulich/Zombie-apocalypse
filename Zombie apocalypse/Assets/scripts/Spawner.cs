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
    private void Start()
    {

    }
    void Update()
    {
        SpawnZombie();
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
