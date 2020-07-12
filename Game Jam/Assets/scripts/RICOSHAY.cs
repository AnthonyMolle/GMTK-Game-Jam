using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RICOSHAY : MonoBehaviour
{

    public float moveSpeed = 5f;

    Vector3 m_dir;
    public Rigidbody2D m_rigid2D; 

     void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("bouncible"))
        {
            Vector2 _wallNormal = other.contacts[0].normal;
            m_dir = Vector2.Reflect(m_rigid2D.velocity, _wallNormal).normalized;

            m_rigid2D.velocity = m_dir * moveSpeed;
        }
    }


}
