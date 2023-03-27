using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_Bullet : MonoBehaviour
{

    public AudioSource audioPlayer;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
            audioPlayer.Play();

        else
        {
            audioPlayer.Stop();
        }
    }
}
