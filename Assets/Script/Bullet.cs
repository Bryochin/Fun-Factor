using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float life = 3;
    public GameObject Explosion;
    public GameObject ExplosionBall;
    void Awake()
    {
        Destroy(gameObject, life);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        Destroy(collision.gameObject);
        Explosion.SetActive(true);

        if (collision.gameObject.tag == "End")
            Destroy(gameObject);

        if (collision.gameObject.tag == "Untagged")
        Explosion.SetActive(false);


        if (collision.gameObject.tag == "Ball")
        {
            Explosion.SetActive(false);
            ExplosionBall.SetActive(true);
        }

        else
        {
            ExplosionBall.SetActive(false);
        }
    }
}