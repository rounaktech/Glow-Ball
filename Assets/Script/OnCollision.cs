using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class OnCollision : MonoBehaviour
{
   
    public Transform ps;
    public GameObject ui;

    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            DestroyObject(gameObject);
            Instantiate(ps, transform.position, Quaternion.identity);
            ui.SetActive(true);

        }
    }

    void Update()
    {
        
    }
}
