using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectToHit : MonoBehaviour
{
    public float ObjectHeath = 100f;

    public void ObjectHitDamage(float amount)
    {
        ObjectHeath -= amount;
        if(ObjectHeath <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
