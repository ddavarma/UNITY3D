using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Second : MonoBehaviour
{
    // Start is called before the first frame update
    int a = 10;
    string ns = "CL";
    double c = 2.5;

    void cl()
    {
        Debug.Log(a);
        Debug.Log(ns);
        Debug.Log(c);

    }
    void Start()
    {
        cl();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
