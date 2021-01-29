using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("HELLO WORLD");
    }

    // Update is called once per frame
    void Update()
    {
        //Hello! Change me, ask Charles
        transform.Rotate(new Vector3(2,2,2)); 
    }
}
