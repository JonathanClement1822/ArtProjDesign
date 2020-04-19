using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculations : MonoBehaviour
{
    public float Val1 = 100.0f;
    public float Val2;
    private float Final;

    private void Start()
    {
        Final = Val1 - Val2;
        if (Final > 0)
        {
            Debug.Log("out of 10 of your choices, You have stolen " + Final + " Art pieces!");
        }
    }
    void Update()
    {
       
    }
}
