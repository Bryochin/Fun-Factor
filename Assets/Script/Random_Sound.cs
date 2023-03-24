using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random_Sound : MonoBehaviour
{

    [SerializeField] AudioClip[] sounds;

    AudioSource myAudioSource;

    // Start is called before the first frame update
    void Start()
    {
        myAudioSource = GetComponent<AudioSource>();
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
            Sounds();
    }
    void Sounds()
    {
        AudioClip clip = sounds[UnityEngine.Random.Range(0, sounds.Length)];
        myAudioSource.PlayOneShot(clip);
    }
}
