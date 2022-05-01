using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorUno : MonoBehaviour
{
    public GameObject PrefabCube;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
        
    }

    // Update is called once per frame
    void Update()
    {
     


    }
}
