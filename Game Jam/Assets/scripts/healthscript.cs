using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthscript : MonoBehaviour
{

    private int health = 5;

    private Material flashWhite;
    private Material defaultMaterial;
    SpriteRenderer sr;


    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        flashWhite = Resources.Load("flashWhite", typeof(Material)) as Material;
        defaultMaterial = sr.material;
    }

    // Update is called once per frame

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("bullet"))
        {
            Destroy(collision.gameObject);
            health--;
            sr.material = flashWhite;
            if (health <= 0)
            {
                Killself();
            }
            else
            {
                Invoke("ResetMaterial", .1f);
            }
        }
    }

    void Killself()
    {
        Destroy(gameObject);
    }
}
