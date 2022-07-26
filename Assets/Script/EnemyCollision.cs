using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour

{
    public ParticleSystem destroy;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            DestroyObject(gameObject);
            Instantiate(destroy, transform.position, Quaternion.identity);
          

        }
    }

    void Update()
    {

    }
}
