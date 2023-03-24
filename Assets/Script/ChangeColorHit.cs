using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorHit : MonoBehaviour
{
    Material thisMat;
    Color c;
    public float value;

    void Start()
    {
        thisMat = GetComponent<Renderer>().material;
        c = GetComponent<Renderer>().material.color;
        thisMat.EnableKeyword("_EMISSION");
        value = c.b;
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        thisMat.SetColor("_EmissionColor", new Vector4(c.r, c.g, c.b, 0) * 2);
    }
}