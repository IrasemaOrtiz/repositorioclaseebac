using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tercero : MonoBehaviour
{
    //SEGUNDO SCRIPT
    //COLOR RANDOM EN EL EVENTO FIXEDUPDATE
    void FixedUpdate()
    {
        GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }
}
