using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * speed;
        Invoke("SelfDestruct", 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SelfDestruct() { Destroy(gameObject); }
}
