using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 

public class Zombie : MonoBehaviour
{
    Vector3 startPosition;
    public GameObject Player;
    Vector3 PlayerPosition;
    float ZombieVelocity = 5f;// in unit/s
    
    void Start()
    {
        startPosition = transform.position;
        PlayerPosition = Player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody rigidbody = transform.GetComponent<Rigidbody>();
        Vector3 NewVelocity = rigidbody.velocity;
        float Distancex = Player.transform.position.x - transform.position.x;
        float Distancez = Player.transform.position.z - transform.position.z;

        NewVelocity.x = Distancex;
        NewVelocity.z = Distancez;     

        Debug.Log("Distancex=" + Distancex+ " ,NewVelocity.x="+NewVelocity.x);


        Debug.Log(rigidbody.velocity.magnitude);

        //rigidbody.position = Vector3.Lerp(startPosition, PlayerPosition,0.2f);
        rigidbody.velocity = NewVelocity;

    }
}
