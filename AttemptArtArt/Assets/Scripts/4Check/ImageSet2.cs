using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageSet2 : MonoBehaviour
{
 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Storage.B++;

        }
    }
}
