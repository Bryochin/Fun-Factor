using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color_Anim : MonoBehaviour
{

    [SerializeField] public Animator Walls;

    void OnCollisionEnter(Collision collision)
    {
            Walls.SetBool("Trigger", true);
    }

    void OnCollisionExit(Collision collision)
    {
            Walls.SetBool("Trigger", false);
    }
}
