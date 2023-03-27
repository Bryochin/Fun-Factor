using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color_Anim : MonoBehaviour
{

    [SerializeField] private Animator myAnim;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            myAnim.SetBool("Trigger", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            myAnim.SetBool("Trigger", false);
        }
    }
}
