using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Zombie : MonoBehaviour
{
    Vector3 startPosition;
    public GameObject Player;
    public GameObject Enemy;
    Vector3 PlayerPosition;
    float ZombieVelocity = 0.3f;// in unit/s
    int HP = 100;
    void Start()
    {
        startPosition = transform.position;
        PlayerPosition = Player.transform.position;
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "player")
        {
            HP = 0;
        }
    }

    void Update()
    {
        if (HP == 0)
        {
            Destroy(Enemy);
        }
        Rigidbody rigidbody = transform.GetComponent<Rigidbody>();
        Vector3 NewVelocity = Vector3.zero;
        float DistanceX = Player.transform.position.x - transform.position.x;
        float DistanceZ = Player.transform.position.z - transform.position.z;
        bool minusX = false;
        bool minusZ = false;

        if (DistanceX < 0)
        {
            DistanceX = -DistanceX;
            minusX = true;
        }
        if (DistanceZ < 0)
        {
            DistanceZ = -DistanceZ;
            minusZ = true;
        }

        if (DistanceX != 0)
            NewVelocity.x = Mathf.Sqrt((ZombieVelocity * ZombieVelocity) / ((DistanceZ / DistanceX) + 1));
        else
            NewVelocity.x = 0;

        if (DistanceZ != 0)
            NewVelocity.z = Mathf.Sqrt((ZombieVelocity * ZombieVelocity) / ((DistanceX / DistanceZ) + 1));
        else
            NewVelocity.z = 0;

        if (minusX)
            NewVelocity.x = -NewVelocity.x;
        if (minusZ)
            NewVelocity.z = -NewVelocity.z;

        rigidbody.velocity = NewVelocity;

    }
}
