using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_Bullet02 : MonoBehaviour
{

    public AudioSource audioPlayer;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
            audioPlayer.Play();

        else
        {
            audioPlayer.Stop();
        }
    }
}
