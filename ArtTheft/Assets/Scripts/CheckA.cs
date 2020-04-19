using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckA : MonoBehaviour
{
    public float Count;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Count++;
        }
    }

}
