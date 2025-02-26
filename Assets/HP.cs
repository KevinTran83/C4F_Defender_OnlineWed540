using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour
{
    public float currentHP;
    public float maxHP = 100;

    // Start is called before the first frame update
    void Start()
    {
        currentHP = maxHP;
    }

    public void ChangeHP(float amount)
    {
        currentHP += amount;
        currentHP = Mathf.Clamp(currentHP, 0, maxHP);
        if (currentHP <= 0) Destroy(gameObject);
    }
}
