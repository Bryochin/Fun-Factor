using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon_Anim : MonoBehaviour
{

    [SerializeField] public Animator Walls;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Walls.SetBool("Trigger", true);
        }

        else
        {
            Walls.SetBool("Trigger", false);
        }
    }
}
