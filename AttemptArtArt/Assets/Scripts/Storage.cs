using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Storage : MonoBehaviour
{
    static public int A = 1;
    static public int B = 1;
    static public int C = 1;
    static public int D = 1;
    public GameObject a;
    public GameObject b;
    public GameObject c;
    public GameObject d;


    // Start is called before the first frame update
    void Start()
    {

        if (A == 2)
        {
            a.SetActive(false);
        }

        if (B == 2)
        {
            b.SetActive(false);
        }

        if (C == 2)
        {
            c.SetActive(false);
        }

        if (D == 2)
        {
            d.SetActive(false);
        }

       


    }

    
}
