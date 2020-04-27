using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodVsBad : MonoBehaviour


{
    public GameObject Tst;
    // Start is called before the first frame update
    void Start()
    {

        if(Storage.A == 2 || Storage.B == 2 || Storage.B == 2 || Storage.B == 2)
        {
            Tst.SetActive(false);

        }
    }

}
