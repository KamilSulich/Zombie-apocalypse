using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletController : MonoBehaviour
{
    public float speed=40;
    // Start is called before the first frame update
    public float lifetime = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        lifetime -= Time.deltaTime;
        if (lifetime<=0)
        {
            Destroy(gameObject);
        }
    }
}
