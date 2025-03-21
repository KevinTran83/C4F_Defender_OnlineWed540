using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 5;

    private Rigidbody rb;
    private HP hp;

    public GameObject target;
    
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Main Camera");

        rb = GetComponent<Rigidbody>();
        hp = GetComponent<HP>();

        if (target != null)
        {
            transform.LookAt(target.transform);
            rb.velocity = speed * transform.forward;
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (hp != null) hp.ChangeHP(-30);
    }

    void Update()
    {
        if (target == null) return;
        if (Vector3.Distance( transform.position,
                              target.transform.position
                             ) < 5
           )
        {
            HP targetHp = target.GetComponent<HP>();
            targetHp.ChangeHP(-50);
            Destroy(gameObject);
        }
    }
}
