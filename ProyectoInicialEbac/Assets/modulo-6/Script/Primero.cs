using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Primero : MonoBehaviour
{
    //PRIMER SCRIPT
    //COLOR RANDOM EN EL EVENTO AWAKE
    void Awake()
    {
        GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
    }
}
