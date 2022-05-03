using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Segundo : MonoBehaviour
{
    //SEGUNDO SCRIPT
    //COLOR RANDOM EN EL EVENTO UPDATE
    void Update()
    {
        GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
    }
}
