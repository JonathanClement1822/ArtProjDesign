using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckInfo : MonoBehaviour
{
    public Image image;
    void Start()
    {
       
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            image = GetComponent<Image>();
            image.color = new Color(image.color.r, image.color.g, image.color.b, 0f);

        }
        if (Input.GetMouseButtonUp(0)) {

            image = GetComponent<Image>();
            image.color = new Color(image.color.r, image.color.g, image.color.b, 100f);

        }
    }
}
