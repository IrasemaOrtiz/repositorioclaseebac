using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Segundo : MonoBehaviour
{
    //SEGUNDO SCRIPT
    //COLOR RANDOM EN EL EVENTO UPDATE
    void Update()
    {
        GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }
}
