using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float turnSpeed = 50f;

    // Update is called once per frame
    void Update()
    {
            transform.Rotate(Vector3.left * turnSpeed * Input.GetAxis("Vertical") * Time.deltaTime);
    }
}
